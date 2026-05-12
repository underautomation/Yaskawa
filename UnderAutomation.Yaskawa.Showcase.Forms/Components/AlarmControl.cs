using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class AlarmControl : UserControl, IUserControl, ISelectableControl<IAlarmReader>
{
    static AlarmControl()
    {
        // make grid readonly
        TypeDescriptor.AddAttributes(typeof(RobotStatusData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotSystemInformation), new ReadOnlyAttribute(true));
    }

    YaskawaRobot _robot;

    public IAlarmReader SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    public AlarmControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
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

}
