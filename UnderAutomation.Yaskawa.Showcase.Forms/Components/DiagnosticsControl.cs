using System;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HostControl.Internal;

public partial class DiagnosticsControl : UserControl, ISelectableControl<IRobotClient>
{
    YaskawaRobot _robot;

    public IRobotClient SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    public DiagnosticsControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;

    public string Title => "Diagnostics";

    public void OnClose() { }

    public void OnOpen() { }

    public void PeriodicUpdate()
    {
        var hostControl = SelectedProtocol as HostControlClientBase;
        bool enabled = hostControl != null;
        btnGetEncoderTemperature.Enabled = enabled;
        btnGetSystemTime.Enabled = enabled;
        btnGetTorque.Enabled = enabled;
        btnGetMaxTorque.Enabled = enabled;
        btnGetControlGroup.Enabled = enabled;
        btnGetAbsEnc.Enabled = enabled;
        btnSetAbsEnc.Enabled = enabled;
        nudAxis.Enabled = enabled;
        nudAbsEncValue.Enabled = enabled;
    }
    #endregion

    private HostControlClientBase HostControl => (HostControlClientBase)SelectedProtocol;

    private void btnGetEncoderTemperature_Click(object sender, EventArgs e)
    {
        gridResult.SelectedObject = HostControl.GetEncoderTemperature();
    }

    private void btnGetSystemTime_Click(object sender, EventArgs e)
    {
        gridResult.SelectedObject = HostControl.GetSystemTime();
    }

    private void btnGetTorque_Click(object sender, EventArgs e)
    {
        gridResult.SelectedObject = HostControl.GetTorque();
    }

    private void btnGetMaxTorque_Click(object sender, EventArgs e)
    {
        gridResult.SelectedObject = HostControl.GetMaxTorque();
    }

    private void btnGetControlGroup_Click(object sender, EventArgs e)
    {
        gridResult.SelectedObject = HostControl.GetControlGroup();
    }

    private void btnGetAbsEnc_Click(object sender, EventArgs e)
    {
        long value = HostControl.GetAbsoluteEncoderPosition((int)nudAxis.Value);
        lblAbsEncResult.Text = $"Axis {(int)nudAxis.Value} = {value} pulses";
        nudAbsEncValue.Value = value;
    }

    private void btnSetAbsEnc_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show($"Set absolute encoder of axis {(int)nudAxis.Value} to {(long)nudAbsEncValue.Value} ?",
            "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

        HostControl.SetAbsoluteEncoderPosition((int)nudAxis.Value, (long)nudAbsEncValue.Value);
    }
}
