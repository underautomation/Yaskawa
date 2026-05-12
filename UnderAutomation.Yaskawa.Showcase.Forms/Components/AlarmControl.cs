using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;
using UnderAutomation.Yaskawa.HostControl.Internal;

public partial class AlarmControl : UserControl, IUserControl, ISelectableControl<IAlarmReader>
{
    static AlarmControl()
    {
        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(RobotStatusData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotSystemInformation), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotAlarmData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotAlarmDataExtended), new ReadOnlyAttribute(true));
    }

    YaskawaRobot _robot;

    public IAlarmReader SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    public AlarmControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();

        foreach (var alarm in Enum.GetValues(typeof(RobotRecentAlarm)))
            cbRecentAlarm.Items.Add(alarm);
        cbRecentAlarm.SelectedIndex = 0;

        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;

    public string Title => "Alarms and system info";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;

        var alarms = SelectedProtocol.GetActiveAlarms();

        lstActiveAlarms.UpdateList(
            alarms,
            a => a.OccurringTime,
            a => a.Code,
            a => a.SubCode,
            a => "",
            a => a.Message
        );
    }

    public void PeriodicUpdate()
    {
        btnReset.Enabled = SelectedProtocol is IRobotControl;

        var isHses = SelectedProtocol == Robot.HighSpeedEServer;
        cbRecentAlarm.Enabled = isHses;
        btnGetAlarm.Enabled = isHses;
        btnGetAlarmExtended.Enabled = isHses;

        var hostControl = SelectedProtocol as HostControlClientBase;
        btnGetAlarmWithMessages.Enabled = hostControl != null;
        btnErrorCancel.Enabled = hostControl != null;
    }
    #endregion

    private void btnReset_Click(object sender, EventArgs e)
    {
        ((IRobotControl)SelectedProtocol).AlarmReset();
        OnOpen();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        OnOpen();
    }

    private void btnGetAlarm_Click(object sender, EventArgs e)
    {
        var data = Robot.HighSpeedEServer.GetAlarm((RobotRecentAlarm)cbRecentAlarm.SelectedItem);
        gridAlarm.SelectedObject = data;
        gridAlarm.ExpandAllGridItems();
    }

    private void btnGetAlarmExtended_Click(object sender, EventArgs e)
    {
        var data = Robot.HighSpeedEServer.GetAlarmExtended((RobotRecentAlarm)cbRecentAlarm.SelectedItem);
        gridAlarm.SelectedObject = data;
        gridAlarm.ExpandAllGridItems();
    }

    private void btnGetAlarmWithMessages_Click(object sender, EventArgs e)
    {
        var data = ((HostControlClientBase)SelectedProtocol).GetAlarmWithMessages();
        gridAlarm.SelectedObject = data;
        gridAlarm.ExpandAllGridItems();
    }

    private void btnErrorCancel_Click(object sender, EventArgs e)
    {
        ((HostControlClientBase)SelectedProtocol).ErrorCancel();
    }

}
