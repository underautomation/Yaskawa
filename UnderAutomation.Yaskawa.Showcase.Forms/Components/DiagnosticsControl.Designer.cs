
partial class DiagnosticsControl
{
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        protocolSelector = new ProtocolSelector();
        btnGetEncoderTemperature = new Button();
        btnGetSystemTime = new Button();
        btnGetTorque = new Button();
        btnGetMaxTorque = new Button();
        btnGetControlGroup = new Button();
        gridResult = new PropertyGrid();
        groupBoxAbsEnc = new GroupBox();
        lblAxis = new Label();
        nudAxis = new NumericUpDown();
        btnGetAbsEnc = new Button();
        lblAbsEncValue = new Label();
        nudAbsEncValue = new NumericUpDown();
        btnSetAbsEnc = new Button();
        lblAbsEncResult = new Label();
        groupBoxAbsEnc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudAxis).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudAbsEncValue).BeginInit();
        SuspendLayout();
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(797, 30);
        protocolSelector.TabIndex = 28;
        // 
        // btnGetEncoderTemperature
        // 
        btnGetEncoderTemperature.Location = new Point(12, 45);
        btnGetEncoderTemperature.Name = "btnGetEncoderTemperature";
        btnGetEncoderTemperature.Size = new Size(220, 28);
        btnGetEncoderTemperature.TabIndex = 0;
        btnGetEncoderTemperature.Text = "Get encoder temperature";
        btnGetEncoderTemperature.UseVisualStyleBackColor = true;
        btnGetEncoderTemperature.Click += btnGetEncoderTemperature_Click;
        // 
        // btnGetSystemTime
        // 
        btnGetSystemTime.Location = new Point(12, 79);
        btnGetSystemTime.Name = "btnGetSystemTime";
        btnGetSystemTime.Size = new Size(220, 28);
        btnGetSystemTime.TabIndex = 1;
        btnGetSystemTime.Text = "Get system time (servo / power on)";
        btnGetSystemTime.UseVisualStyleBackColor = true;
        btnGetSystemTime.Click += btnGetSystemTime_Click;
        // 
        // btnGetTorque
        // 
        btnGetTorque.Location = new Point(12, 113);
        btnGetTorque.Name = "btnGetTorque";
        btnGetTorque.Size = new Size(220, 28);
        btnGetTorque.TabIndex = 2;
        btnGetTorque.Text = "Get current torque";
        btnGetTorque.UseVisualStyleBackColor = true;
        btnGetTorque.Click += btnGetTorque_Click;
        // 
        // btnGetMaxTorque
        // 
        btnGetMaxTorque.Location = new Point(12, 147);
        btnGetMaxTorque.Name = "btnGetMaxTorque";
        btnGetMaxTorque.Size = new Size(220, 28);
        btnGetMaxTorque.TabIndex = 3;
        btnGetMaxTorque.Text = "Get max torque";
        btnGetMaxTorque.UseVisualStyleBackColor = true;
        btnGetMaxTorque.Click += btnGetMaxTorque_Click;
        // 
        // btnGetControlGroup
        // 
        btnGetControlGroup.Location = new Point(12, 181);
        btnGetControlGroup.Name = "btnGetControlGroup";
        btnGetControlGroup.Size = new Size(220, 28);
        btnGetControlGroup.TabIndex = 4;
        btnGetControlGroup.Text = "Get control group";
        btnGetControlGroup.UseVisualStyleBackColor = true;
        btnGetControlGroup.Click += btnGetControlGroup_Click;
        // 
        // gridResult
        // 
        gridResult.Location = new Point(248, 45);
        gridResult.Name = "gridResult";
        gridResult.Size = new Size(530, 380);
        gridResult.TabIndex = 5;
        // 
        // groupBoxAbsEnc
        // 
        groupBoxAbsEnc.Controls.Add(lblAxis);
        groupBoxAbsEnc.Controls.Add(nudAxis);
        groupBoxAbsEnc.Controls.Add(btnGetAbsEnc);
        groupBoxAbsEnc.Controls.Add(lblAbsEncValue);
        groupBoxAbsEnc.Controls.Add(nudAbsEncValue);
        groupBoxAbsEnc.Controls.Add(btnSetAbsEnc);
        groupBoxAbsEnc.Controls.Add(lblAbsEncResult);
        groupBoxAbsEnc.Location = new Point(12, 245);
        groupBoxAbsEnc.Name = "groupBoxAbsEnc";
        groupBoxAbsEnc.Size = new Size(220, 180);
        groupBoxAbsEnc.TabIndex = 6;
        groupBoxAbsEnc.TabStop = false;
        groupBoxAbsEnc.Text = "Absolute encoder";
        // 
        // lblAxis
        // 
        lblAxis.AutoSize = true;
        lblAxis.Location = new Point(12, 25);
        lblAxis.Name = "lblAxis";
        lblAxis.Size = new Size(35, 15);
        lblAxis.TabIndex = 0;
        lblAxis.Text = "Axis :";
        // 
        // nudAxis
        // 
        nudAxis.Location = new Point(60, 23);
        nudAxis.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
        nudAxis.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudAxis.Name = "nudAxis";
        nudAxis.Size = new Size(60, 23);
        nudAxis.TabIndex = 1;
        nudAxis.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnGetAbsEnc
        // 
        btnGetAbsEnc.Location = new Point(126, 22);
        btnGetAbsEnc.Name = "btnGetAbsEnc";
        btnGetAbsEnc.Size = new Size(80, 25);
        btnGetAbsEnc.TabIndex = 2;
        btnGetAbsEnc.Text = "Get";
        btnGetAbsEnc.UseVisualStyleBackColor = true;
        btnGetAbsEnc.Click += btnGetAbsEnc_Click;
        // 
        // lblAbsEncValue
        // 
        lblAbsEncValue.AutoSize = true;
        lblAbsEncValue.Location = new Point(12, 60);
        lblAbsEncValue.Name = "lblAbsEncValue";
        lblAbsEncValue.Size = new Size(45, 15);
        lblAbsEncValue.TabIndex = 3;
        lblAbsEncValue.Text = "Value :";
        // 
        // nudAbsEncValue
        // 
        nudAbsEncValue.Location = new Point(60, 58);
        nudAbsEncValue.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
        nudAbsEncValue.Minimum = new decimal(new int[] { int.MaxValue, 0, 0, int.MinValue });
        nudAbsEncValue.Name = "nudAbsEncValue";
        nudAbsEncValue.Size = new Size(140, 23);
        nudAbsEncValue.TabIndex = 4;
        // 
        // btnSetAbsEnc
        // 
        btnSetAbsEnc.Location = new Point(60, 90);
        btnSetAbsEnc.Name = "btnSetAbsEnc";
        btnSetAbsEnc.Size = new Size(140, 28);
        btnSetAbsEnc.TabIndex = 5;
        btnSetAbsEnc.Text = "Set encoder value";
        btnSetAbsEnc.UseVisualStyleBackColor = true;
        btnSetAbsEnc.Click += btnSetAbsEnc_Click;
        // 
        // lblAbsEncResult
        // 
        lblAbsEncResult.AutoSize = true;
        lblAbsEncResult.Location = new Point(12, 135);
        lblAbsEncResult.Name = "lblAbsEncResult";
        lblAbsEncResult.Size = new Size(0, 15);
        lblAbsEncResult.TabIndex = 6;
        // 
        // DiagnosticsControl
        // 
        Controls.Add(gridResult);
        Controls.Add(groupBoxAbsEnc);
        Controls.Add(btnGetControlGroup);
        Controls.Add(btnGetMaxTorque);
        Controls.Add(btnGetTorque);
        Controls.Add(btnGetSystemTime);
        Controls.Add(btnGetEncoderTemperature);
        Controls.Add(protocolSelector);
        Name = "DiagnosticsControl";
        Size = new Size(797, 647);
        groupBoxAbsEnc.ResumeLayout(false);
        groupBoxAbsEnc.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudAxis).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudAbsEncValue).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private ProtocolSelector protocolSelector;
    private Button btnGetEncoderTemperature;
    private Button btnGetSystemTime;
    private Button btnGetTorque;
    private Button btnGetMaxTorque;
    private Button btnGetControlGroup;
    private PropertyGrid gridResult;
    private GroupBox groupBoxAbsEnc;
    private Label lblAxis;
    private NumericUpDown nudAxis;
    private Button btnGetAbsEnc;
    private Label lblAbsEncValue;
    private NumericUpDown nudAbsEncValue;
    private Button btnSetAbsEnc;
    private Label lblAbsEncResult;
}
