using System.ComponentModel;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class KinematicsControl : UserControl, IUserControl
{
    static KinematicsControl()
    {
        TypeDescriptor.AddAttributes(typeof(RobotKinematicsCartesianData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotKinematicsJointData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotKinematicsPositionData), new ReadOnlyAttribute(true));
        TypeDescriptor.AddAttributes(typeof(RobotPosture), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
    }

    private readonly YaskawaRobot _robot;

    public KinematicsControl(YaskawaRobot robot)
    {
        _robot = robot;
        InitializeComponent();
        gridInput.SelectedObject = new KinematicsInputData();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;
    public string Title => "Kinematics";
    public void OnClose() { }
    public void OnOpen() { }
    public void PeriodicUpdate() { }
    #endregion

    private int ControlGroup => (int)nudControlGroup.Value;

    private KinematicsInputData GetInput() =>
        gridInput.SelectedObject as KinematicsInputData ?? new KinematicsInputData();

    private void ShowOutput(object result)
    {
        gridOutput.SelectedObject = result;
        gridOutput.ExpandAllGridItems();
    }

    private void Run(Func<object> action)
    {
        try
        {
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Text = "Sending…";
            var result = action();
            ShowOutput(result);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = result?.ToString();
        }
        catch (Exception ex)
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = ex.Message;
        }
    }

    private void btnJointToCart_Click(object sender, EventArgs e)
    {/*
        Run(() =>
        {
            return _robot.HighSpeedEServer.ConvertJointToCartesian(ControlGroup, GetInput().ToPositionData());
        });*/
    }
    private void btnCartToJoint_Click(object sender, EventArgs e)
    {/*
        Run(() => _robot.HighSpeedEServer.ConvertCartesianToJoint(ControlGroup, GetInput().ToPositionData()));
  */
    }
    private void btnCoordFrame_Click(object sender, EventArgs e)
    {/*
        Run(() => _robot.HighSpeedEServer.ConvertCoordinateFrame(ControlGroup, GetInput().ToPositionData()));
*/  }
    private void btnRoundTrip_Click(object sender, EventArgs e)
    {/*
        Run(() => _robot.HighSpeedEServer.ConvertCartesianRoundTrip(ControlGroup, GetInput().ToPositionData()));
 */
    }
    private void btnTwoStep_Click(object sender, EventArgs e)
    {/*
        Run(() => _robot.HighSpeedEServer.ConvertCoordinateFrameTwoStep(ControlGroup, GetInput().ToPositionData()));
 */
    }

    private void btnUseOutput_Click(object sender, EventArgs e)
    {
        if (gridOutput.SelectedObject is RobotKinematicsPositionData pos)
        {
            gridInput.SelectedObject = KinematicsInputData.From(pos);
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Text = "Output copied to input.";
        }
    }
}

/// <summary>
/// Editable input data for kinematic conversion methods, designed for use in a PropertyGrid.
/// Raw axis units: joint positions in 0.0001° (×10 000 per °); Cartesian XYZ in µm (×1 000 per mm);
/// Cartesian orientation in 0.0001° (×10 000 per °).
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class KinematicsInputData
{
    [Category("1 – Config")]
    [Description("Coordinate type of this position (PulseValue = joint, RobotCoordinateValue = Cartesian robot frame, etc.).")]
    public RobotPositionDataType DataType { get; set; } = RobotPositionDataType.RobotCoordinateValue;

    [Category("1 – Config")]
    [Description("Tool number (TCP index).")]
    public int ToolNumber { get; set; }

    [Category("1 – Config")]
    [Description("User coordinate number (relevant when DataType = UserCoordinateValue).")]
    public int UserCoordinateNumber { get; set; }

    [Category("1 – Config")]
    [Description("Posture form integer (RCONF bit field). 0 = default.")]
    public int PostureForm { get; set; }

    [Category("2 – Axes (raw)")]
    [Description("Axis 0 raw value. Joint: value × 0.0001 °. Cartesian X: value × 0.001 mm.")]
    public int Axis0 { get; set; }

    [Category("2 – Axes (raw)")]
    [Description("Axis 1 raw value. Joint: value × 0.0001 °. Cartesian Y: value × 0.001 mm.")]
    public int Axis1 { get; set; }

    [Category("2 – Axes (raw)")]
    [Description("Axis 2 raw value. Joint: value × 0.0001 °. Cartesian Z: value × 0.001 mm.")]
    public int Axis2 { get; set; }

    [Category("2 – Axes (raw)")]
    [Description("Axis 3 raw value. Joint: value × 0.0001 °. Cartesian Rx: value × 0.0001 °.")]
    public int Axis3 { get; set; }

    [Category("2 – Axes (raw)")]
    [Description("Axis 4 raw value. Joint: value × 0.0001 °. Cartesian Ry: value × 0.0001 °.")]
    public int Axis4 { get; set; }

    [Category("2 – Axes (raw)")]
    [Description("Axis 5 raw value. Joint: value × 0.0001 °. Cartesian Rz: value × 0.0001 °.")]
    public int Axis5 { get; set; }

    [Category("2 – Axes (raw)")]
    [Description("Axis 6 raw value (7th axis / external).")]
    public int Axis6 { get; set; }

    [Category("2 – Axes (raw)")]
    [Description("Axis 7 raw value (8th axis / external).")]
    public int Axis7 { get; set; }

    public RobotKinematicsPositionData ToPositionData() => new RobotKinematicsPositionData
    {
        DataType = DataType,
        ToolNumber = ToolNumber,
        UserCoordinateNumber = UserCoordinateNumber,
        Form = new RobotPosture(PostureForm, 0),
        Axes = new[] { Axis0, Axis1, Axis2, Axis3, Axis4, Axis5, Axis6, Axis7 }
    };

    public static KinematicsInputData From(RobotKinematicsPositionData d)
    {
        var a = d.Axes ?? new int[8];
        return new KinematicsInputData
        {
            DataType = d.DataType,
            ToolNumber = d.ToolNumber,
            UserCoordinateNumber = d.UserCoordinateNumber,
            PostureForm = d.Form?.Form ?? 0,
            Axis0 = a.Length > 0 ? a[0] : 0,
            Axis1 = a.Length > 1 ? a[1] : 0,
            Axis2 = a.Length > 2 ? a[2] : 0,
            Axis3 = a.Length > 3 ? a[3] : 0,
            Axis4 = a.Length > 4 ? a[4] : 0,
            Axis5 = a.Length > 5 ? a[5] : 0,
            Axis6 = a.Length > 6 ? a[6] : 0,
            Axis7 = a.Length > 7 ? a[7] : 0,
        };
    }

    public override string ToString() =>
        $"[{DataType}] {Axis0}, {Axis1}, {Axis2}, {Axis3}, {Axis4}, {Axis5}, {Axis6}, {Axis7}";
}
