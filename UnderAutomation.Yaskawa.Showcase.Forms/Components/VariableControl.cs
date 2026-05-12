using System.ComponentModel;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class VariableControl : UserControl, IUserControl, ISelectableControl<IVariableAccess>
{
    YaskawaRobot _robot;

    public IVariableAccess SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    public VariableControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;

        TypeDescriptor.AddAttributes(typeof(RobotPositionIntData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

        InitializeComponent();
        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;

    public string Title => "Variables";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;


    }

    public void PeriodicUpdate()
    {
        btnWriteByte.Enabled = grid.SelectedObject is byte[];
        btnWriteRegister.Enabled = grid.SelectedObject is short[];
        btnWriteInteger.Enabled = grid.SelectedObject is short[];
        btnWriteDouble.Enabled = grid.SelectedObject is Int32[];
        btnWriteReal.Enabled = grid.SelectedObject is float[];
        btnWrite32Char.Enabled = grid.SelectedObject is string[];
        btnWritePositionVariable.Enabled = grid.SelectedObject is RobotPositionIntData[];

        var isHses = SelectedProtocol == Robot.HighSpeedEServer;
        btnReadRegister.Enabled = isHses;
        btnWriteRegister.Enabled = isHses && grid.SelectedObject is short[];
        btnReadPositionVariable.Enabled = isHses;
        btnWritePositionVariable.Enabled = isHses && grid.SelectedObject is RobotPositionIntData[];
        btnReadBasePosition.Enabled = isHses;
        btnWriteBasePosition.Enabled = isHses && grid.SelectedObject is RobotBasePositionData[];
        btnReadExternalPosition.Enabled = isHses;
        btnWriteExternalPosition.Enabled = isHses && grid.SelectedObject is RobotExternalAxisData[];
    }
    #endregion

    private void btnReadByte_Click(object sender, EventArgs e)
    {
        var data = SelectedProtocol.ReadByte((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data;
    }

    private void btnWriteByte_Click(object sender, EventArgs e)
    {
        SelectedProtocol.WriteByte((int)nudIndex.Value, (byte[])grid.SelectedObject);
    }

    private void btnReadRegister_Click(object sender, EventArgs e)
    {
        var data = Robot.HighSpeedEServer.ReadRegister((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
    }

    private void btnWriteRegister_Click(object sender, EventArgs e)
    {
        Robot.HighSpeedEServer.WriteRegister((int)nudIndex.Value, (short[])grid.SelectedObject);
    }

    private void btnReadInteger_Click(object sender, EventArgs e)
    {
        var data = SelectedProtocol.ReadInteger((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data;
    }

    private void btnWriteInteger_Click(object sender, EventArgs e)
    {
        SelectedProtocol.WriteInteger((int)nudIndex.Value, (short[])grid.SelectedObject);
    }

    private void btnReadDouble_Click(object sender, EventArgs e)
    {
        var data = SelectedProtocol.ReadDoubleInteger((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data;
    }

    private void btnWriteDouble_Click(object sender, EventArgs e)
    {
        SelectedProtocol.WriteDoubleInteger((int)nudIndex.Value, (Int32[])grid.SelectedObject);
    }

    private void btnReadReal_Click(object sender, EventArgs e)
    {
        var data = SelectedProtocol.ReadReal((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data;
    }

    private void btnWriteReal_Click(object sender, EventArgs e)
    {
        SelectedProtocol.WriteReal((int)nudIndex.Value, (float[])grid.SelectedObject);
    }

    private void btnRead32Char_Click(object sender, EventArgs e)
    {
        var data = SelectedProtocol.Read16BytesChar((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data;
    }

    private void btnWrite32Char_Click(object sender, EventArgs e)
    {
        SelectedProtocol.Write16BytesChar((int)nudIndex.Value, (string[])grid.SelectedObject);
    }

    private void btnReadPositionVariable_Click(object sender, EventArgs e)
    {
        var data = Robot.HighSpeedEServer.ReadPositionVariable((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
        grid.ExpandAllGridItems();
    }

    private void btnWritePositionVariable_Click(object sender, EventArgs e)
    {
        Robot.HighSpeedEServer.WritePositionVariable((int)nudIndex.Value, (RobotPositionIntData[])grid.SelectedObject);
    }

    private void btnReadBasePosition_Click(object sender, EventArgs e)
    {
        var data = Robot.HighSpeedEServer.ReadBasePosition((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
        grid.ExpandAllGridItems();
    }

    private void btnWriteBasePosition_Click(object sender, EventArgs e)
    {
        Robot.HighSpeedEServer.WriteBasePosition((int)nudIndex.Value, (RobotBasePositionData[])grid.SelectedObject);
    }

    private void btnReadExternalPosition_Click(object sender, EventArgs e)
    {
        var data = Robot.HighSpeedEServer.ReadExternalPosition((int)nudIndex.Value, (int)nudCount.Value);
        grid.SelectedObject = data.Value;
        grid.ExpandAllGridItems();
    }

    private void btnWriteExternalPosition_Click(object sender, EventArgs e)
    {
        Robot.HighSpeedEServer.WriteExternalPosition((int)nudIndex.Value, (RobotExternalAxisData[])grid.SelectedObject);
    }

}
