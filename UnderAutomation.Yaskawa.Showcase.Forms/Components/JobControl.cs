using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class JobControl : UserControl, IUserControl, ISelectableControl<IRobotControl>
{
    static JobControl()
    {
        TypeDescriptor.AddAttributes(typeof(RobotJobData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotStatusData), new ReadOnlyAttribute(true));
    }

    YaskawaRobot _robot;

    public IRobotControl SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    public JobControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;

    public string Title => "Job";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;

        RefreshList();

    }

    public void PeriodicUpdate()
    {
        if (!FeatureEnabled) return;
        var statusReader = SelectedProtocol as IStatusReader;
        if (statusReader != null)
        {
            gridExecuting.SelectedObject = statusReader.GetExecutingJobInformation();
            gridStatus.SelectedObject = statusReader.GetStatusInformation();
        }
        btnGetCallStack.Enabled = SelectedProtocol == Robot.HighSpeedEServer;
    }

    #endregion

    private void btnSelect_Click(object sender, EventArgs e)
    {
        SelectedProtocol.SelectJob(cbJobs.Text, (int)udJobLine.Value);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshList();
    }

    private void RefreshList()
    {
        if (!FeatureEnabled) return;

        var fileReader = SelectedProtocol as IFileReader;
        if (fileReader is null) return;

        var files = fileReader.GetFileList("*.JBI");

        if (files is null) return;

        cbJobs.Items.Clear();

        foreach (var file in files)
        {
            cbJobs.Items.Add(Path.GetFileNameWithoutExtension(file));
        }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        SelectedProtocol.StartJob();
    }

    private void btnServoOff_Click(object sender, EventArgs e)
    {
        SelectedProtocol.SetServo(false);
    }

    private void btnServoOn_Click(object sender, EventArgs e)
    {
        SelectedProtocol.SetServo(true);
    }

    private void btnGetCallStack_Click(object sender, EventArgs e)
    {
        RobotJobStackData stack = Robot.HighSpeedEServer.GetJobStack((int)udTaskId.Value);

        txtCallStack.Text = string.Join(Environment.NewLine, stack.Jobs);
    }
}
