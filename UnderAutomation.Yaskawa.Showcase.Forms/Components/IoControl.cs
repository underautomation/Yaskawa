using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class IoControl : UserControl, IUserControl, ISelectableControl<IIOAccess>
{
    YaskawaRobot _robot;

    public IIOAccess SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    public IoControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();

        foreach (var item in Enum.GetValues(typeof(IOType)))
        {
            cbType.Items.Add(item);
        }
        cbType.SelectedIndex = 0;

        grid.SelectedObject = new byte[2];

        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;

    public string Title => "Inputs / Outputs";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;


    }

    public void PeriodicUpdate()
    {
        var isHses = SelectedProtocol == Robot.HighSpeedEServer;
        cbType.Enabled = isHses;
        if (!isHses)
        {
            btnWrite.Enabled = true;
        }
    }
    #endregion

    private void btnRead_Click(object sender, EventArgs e)
    {
        if (SelectedProtocol == Robot.HighSpeedEServer)
        {
            IOType type = (IOType)cbType.SelectedItem;
            RobotIOData data = Robot.HighSpeedEServer.ReadIO(type, (ushort)nudGroup.Value, (int)nudCount.Value);
            grid.SelectedObject = data.Value;

            var strValue = new string[data.Value.Length];

            for (int i = 0; i < strValue.Length; i++)
            {
                strValue[i] = $"#{(IoHelpers.ConvertIOGroupToBitAddress(type, (ushort)(nudGroup.Value + i), 0) / 10).ToString("0000")} : {data.Value[i]}";
            }

            gridName.SelectedObject = strValue;
        }
        else
        {
            byte[] data = SelectedProtocol.ReadIO((int)nudGroup.Value, (int)nudCount.Value);
            grid.SelectedObject = data;
            gridName.SelectedObject = null;
        }
    }

    private void btnWrite_Click(object sender, EventArgs e)
    {
        if (SelectedProtocol == Robot.HighSpeedEServer)
        {
            Robot.HighSpeedEServer.WriteIoNetworkInput((ushort)nudGroup.Value, (byte[])grid.SelectedObject);
        }
        else
        {
            SelectedProtocol.WriteIO((int)nudGroup.Value, (byte[])grid.SelectedObject);
        }
    }

    private void cbType_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnWrite.Enabled = SelectedProtocol != Robot.HighSpeedEServer || IOType.NetworkInput.Equals(cbType.SelectedItem);
    }
}
