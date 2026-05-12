using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class PositionControl : UserControl, ISelectableControl<IPositionReader>
{
    static PositionControl()
    {
        TypeDescriptor.AddAttributes(typeof(RobotPositionCartesianData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotPosture), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
    }

    public IPositionReader SelectedProtocol {  get; set; }
    public YaskawaRobot Robot { get; set; }

    public PositionControl(YaskawaRobot Yaskawa)
    {
        Robot = Yaskawa;
        InitializeComponent();

        protocolSelector.Initialize(this);        
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol.Connected;

    public string Title => "Current position";


    public void OnClose()
    {
        if (worker.IsBusy) worker.CancelAsync();
    }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;

        if (!worker.CancellationPending) worker.RunWorkerAsync();
    }

    public void PeriodicUpdate()
    {
        var isHses = SelectedProtocol == Robot.HighSpeedEServer;
        btnGetAxisConfig.Enabled = isHses;
        btnGetTorqueHses.Enabled = isHses;
        btnGetTorque.Enabled = SelectedProtocol is ITorqueReader;
    }
    #endregion

    private void btnGetAxisConfig_Click(object sender, EventArgs e)
    {
        gridConfig.SelectedObject = Robot.HighSpeedEServer.GetConfigurationInformation();
        gridConfig.ExpandAllGridItems();
    }

    private void btnGetTorqueHses_Click(object sender, EventArgs e)
    {
        gridTorque.SelectedObject = Robot.HighSpeedEServer.GetTorque();
        gridTorque.ExpandAllGridItems();
    }

    private void btnGetTorque_Click(object sender, EventArgs e)
    {
        gridTorque.SelectedObject = ((ITorqueReader)SelectedProtocol).GetTorque();
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
        while (!worker.CancellationPending)
        {
            try
            {
                object error;

                if (SelectedProtocol == Robot.HighSpeedEServer)
                {
                    error = Robot.HighSpeedEServer.GetPositionError();
                }
                else
                {
                    error = "(only supported with Hight Speed Ethernet Server)";
                }

                var cartesian = SelectedProtocol.GetRobotCartesianPosition();

                var joints = SelectedProtocol.GetRobotJointPosition();

                this.Invoke(new Action(() =>
                {
                    gridCartesian.SelectedObject = cartesian;
                    gridJoints.SelectedObject = joints;
                    gridError.SelectedObject = error;

                    gridCartesian.ExpandAllGridItems();
                    gridJoints.ExpandAllGridItems();
                    gridError.ExpandAllGridItems();
                }));

            }
            catch { }

            System.Threading.Thread.Sleep(100);
        }
    }
}
