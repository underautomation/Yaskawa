using System;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HostControl;
using UnderAutomation.Yaskawa.HostControl.Internal;

public partial class UserFrameControl : UserControl, ISelectableControl<IRobotClient>
{
    YaskawaRobot _robot;

    public IRobotClient SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    public UserFrameControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;

    public string Title => "User frames";

    public void OnClose() { }

    public void OnOpen() { }

    public void PeriodicUpdate()
    {
        var hostControl = SelectedProtocol as HostControlClientBase;
        bool enabled = hostControl != null;
        btnGetUserFrame.Enabled = enabled;
        btnSetUserFrame.Enabled = enabled;
        btnSetControlGroup.Enabled = enabled;
        btnSetTask.Enabled = enabled;
        btnSetFrameType.Enabled = enabled;
        btnErrorCancel.Enabled = enabled;
    }
    #endregion

    private HostControlClientBase HostControl => (HostControlClientBase)SelectedProtocol;

    private void btnGetUserFrame_Click(object sender, EventArgs e)
    {
        gridFrame.SelectedObject = HostControl.GetUserFrame((int)nudFrameNumber.Value);
    }

    private void btnSetUserFrame_Click(object sender, EventArgs e)
    {
        var frame = gridFrame.SelectedObject as HostControlUserFrameData;
        if (frame == null) return;
        HostControl.SetUserFrame((int)nudFrameNumber.Value, frame);
    }

    private void btnSetControlGroup_Click(object sender, EventArgs e)
    {
        HostControl.SetControlGroup((int)nudRobotGroup.Value, (int)nudStationGroup.Value);
    }

    private void btnSetTask_Click(object sender, EventArgs e)
    {
        HostControl.SetTask((int)nudTask.Value);
    }

    private void btnSetFrameType_Click(object sender, EventArgs e)
    {
        HostControl.SetFrameType((int)nudFrameType.Value);
    }

    private void btnErrorCancel_Click(object sender, EventArgs e)
    {
        HostControl.ErrorCancel();
    }
}
