using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class MoveControl : UserControl, IUserControl, ISelectableControl<IMotionControl>
{
    YaskawaRobot _robot;

    public IMotionControl SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    private readonly int[] _joints = new int[8];

    public MoveControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();

        foreach (var type in System.Enum.GetValues(typeof(PositionCommandType)))
        {
            cbCartesianCommandType.Items.Add(type);
        }
        cbCartesianCommandType.SelectedIndex = 0;

        foreach (var type in System.Enum.GetValues(typeof(PositionCommandOperationCoordinate)))
            cbFrame.Items.Add(type);
        cbFrame.SelectedIndex = 0;

        cbUnit.SelectedIndex = 0;

        gridJoints.SelectedObject = _joints;
        gridPosture.SelectedObject = new RobotPosture();

        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;

    public string Title => "Move robot";

    public void OnClose() { }

    public void OnOpen()
    {
        if (!FeatureEnabled) return;


    }

    public void PeriodicUpdate()
    {
        var supportsRobotControl = SelectedProtocol is IRobotControl;
        btnServoOn.Enabled = supportsRobotControl;
        btnServoOff.Enabled = supportsRobotControl;
        btnStop.Enabled = supportsRobotControl;

        var supportsPosition = SelectedProtocol is IPositionReader;
        btnCopyJoint.Enabled = supportsPosition;
        btnCopyCartesian.Enabled = supportsPosition;
    }
    #endregion

    private void btnMoveJoints_Click(object sender, EventArgs e)
    {
        SelectedProtocol.MoveJoints(_joints, (double)nudSpeedJoint.Value);
    }

    private void btnMoveCartesian_Click(object sender, EventArgs e)
    {
        SelectedProtocol.MoveCartesian(
            (double)nudX.Value, (double)nudY.Value, (double)nudZ.Value,
            (double)nudRx.Value, (double)nudRy.Value, (double)nudRz.Value,
            (double)nudSpeedCartesian.Value,
            tool: (int)nudTool.Value);
    }

    private void cbFrame_SelectedIndexChanged(object sender, EventArgs e)
    {
        nudUserCoordinate.Enabled = (PositionCommandOperationCoordinate)cbFrame.SelectedItem == PositionCommandOperationCoordinate.User;
    }

    private void btnServoOn_Click(object sender, EventArgs e)
    {
        ((IRobotControl)SelectedProtocol).SetServo(true);
    }

    private void btnServoOff_Click(object sender, EventArgs e)
    {
        ((IRobotControl)SelectedProtocol).SetServo(false);
    }

    private void btnCopyJoint_Click(object sender, EventArgs e)
    {
        int[] axes = ((IPositionReader)SelectedProtocol).GetRobotJointPosition().Axes;

        for (int i = 0; i < axes.Length; i++)
            _joints[i] = axes[i];

        gridJoints.SelectedObject = _joints;
    }

    private void btnCopyCartesian_Click(object sender, EventArgs e)
    {
        ICartesianPosition position = ((IPositionReader)SelectedProtocol).GetRobotCartesianPosition();

        nudX.Value = (decimal)position.X;
        nudY.Value = (decimal)position.Y;
        nudZ.Value = (decimal)position.Z;
        nudRx.Value = (decimal)position.Rx;
        nudRy.Value = (decimal)position.Ry;
        nudRz.Value = (decimal)position.Rz;
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        var ctrl = (IRobotControl)SelectedProtocol;
        ctrl.SetHold(true);
        ctrl.SetHold(false);
    }
}
