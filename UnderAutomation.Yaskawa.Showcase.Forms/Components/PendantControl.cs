using System;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class PendantControl : UserControl, IUserControl, ISelectableControl<IRobotControl>
{
    YaskawaRobot _robot;

    public IRobotControl SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    public PendantControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();

        foreach (var mode in Enum.GetValues(typeof(RobotMode)))
            cbMode.Items.Add(mode);
        cbMode.SelectedIndex = 0;

        foreach (var cycle in Enum.GetValues(typeof(RobotCycleType)))
            cbCycle.Items.Add(cycle);
        cbCycle.SelectedIndex = 0;

        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;

    public string Title => "Teach Pendant";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;


    }

    public void PeriodicUpdate()
    {

    }
    #endregion

    private void btnPopup_Click(object sender, System.EventArgs e)
    {
        SelectedProtocol.Display(txtMessage.Text);
    }

    private void btnLock_Click(object sender, System.EventArgs e)
    {
        SelectedProtocol.SetTeachPendantLockState(true);
    }

    private void btnUnlock_Click(object sender, System.EventArgs e)
    {
        SelectedProtocol.SetTeachPendantLockState(false);
    }

    private void btnSetMode_Click(object sender, EventArgs e)
    {
        SelectedProtocol.SetMode((RobotMode)cbMode.SelectedItem);
    }

    private void btnSetCycle_Click(object sender, EventArgs e)
    {
        SelectedProtocol.SetCycle((RobotCycleType)cbCycle.SelectedItem);
    }
}
