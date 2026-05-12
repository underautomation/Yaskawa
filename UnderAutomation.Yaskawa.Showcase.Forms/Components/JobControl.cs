using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;
using UnderAutomation.Yaskawa.HostControl;
using UnderAutomation.Yaskawa.HostControl.Internal;

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

        foreach (var coord in Enum.GetValues(typeof(HostControlCoordinateSystem)))
            cbCoordSystem.Items.Add(coord);
        cbCoordSystem.SelectedIndex = 0;

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

        var hostControl = SelectedProtocol as HostControlClientBase;
        btnGetJobDirectory.Enabled = hostControl != null;
        btnDeleteJob.Enabled = hostControl != null;
        btnSetMasterJob.Enabled = hostControl != null;
        btnWaitCompletion.Enabled = hostControl != null;
        btnConvertToRelative.Enabled = hostControl != null;
        btnConvertToStandard.Enabled = hostControl != null;
        cbCoordSystem.Enabled = hostControl != null;
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

    private void btnGetJobDirectory_Click(object sender, EventArgs e)
    {
        var data = ((HostControlClientBase)SelectedProtocol).GetJobDirectory(string.IsNullOrEmpty(txtJobName.Text) ? "*" : txtJobName.Text);
        txtCallStack.Text = data?.JobNames == null ? string.Empty : string.Join(Environment.NewLine, data.JobNames);
    }

    private void btnDeleteJob_Click(object sender, EventArgs e)
    {
        ((HostControlClientBase)SelectedProtocol).DeleteJob(txtJobName.Text);
    }

    private void btnSetMasterJob_Click(object sender, EventArgs e)
    {
        ((HostControlClientBase)SelectedProtocol).SetMasterJob(txtJobName.Text);
    }

    private void btnWaitCompletion_Click(object sender, EventArgs e)
    {
        var done = ((HostControlClientBase)SelectedProtocol).WaitForJobCompletion((int)udTimeout.Value);
        txtCallStack.Text = $"Job completion : {done}";
    }

    private void btnConvertToRelative_Click(object sender, EventArgs e)
    {
        ((HostControlClientBase)SelectedProtocol).ConvertToRelativeJob(txtJobName.Text, (HostControlCoordinateSystem)cbCoordSystem.SelectedItem);
    }

    private void btnConvertToStandard_Click(object sender, EventArgs e)
    {
        ((HostControlClientBase)SelectedProtocol).ConvertToStandardJob(txtJobName.Text, (int)udConvertMethod.Value, (int)udRefPosVar.Value);
    }
}
