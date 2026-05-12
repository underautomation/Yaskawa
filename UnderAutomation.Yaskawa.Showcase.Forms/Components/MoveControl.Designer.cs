
partial class MoveControl
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
        gridJoints = new PropertyGrid();
        btnMoveJoints = new Button();
        nudSpeedJoint = new NumericUpDown();
        label1 = new Label();
        label2 = new Label();
        btnMoveCartesian = new Button();
        label4 = new Label();
        nudX = new NumericUpDown();
        nudY = new NumericUpDown();
        label5 = new Label();
        nudZ = new NumericUpDown();
        label6 = new Label();
        nudRx = new NumericUpDown();
        label7 = new Label();
        nudRy = new NumericUpDown();
        label8 = new Label();
        nudRz = new NumericUpDown();
        label9 = new Label();
        label10 = new Label();
        nudSpeedCartesian = new NumericUpDown();
        cbUnit = new ComboBox();
        label11 = new Label();
        cbCartesianCommandType = new ComboBox();
        label12 = new Label();
        label13 = new Label();
        cbFrame = new ComboBox();
        gridPosture = new PropertyGrid();
        label14 = new Label();
        nudTool = new NumericUpDown();
        label15 = new Label();
        nudUserCoordinate = new NumericUpDown();
        btnServoOn = new Button();
        btnServoOff = new Button();
        btnCopyJoint = new Button();
        btnCopyCartesian = new Button();
        btnStop = new Button();
        panel1 = new Panel();
        panel2 = new Panel();
        panelHostControl = new Panel();
        lblHostControl = new Label();
        cbHcCoord = new ComboBox();
        lblHcCoord = new Label();
        cbHcSpeedType = new ComboBox();
        lblHcSpeedType = new Label();
        btnHcMoveJoint = new Button();
        btnHcMoveLinear = new Button();
        btnHcMoveIncremental = new Button();
        btnHcMovePulseJoint = new Button();
        btnHcMovePulseLinear = new Button();
        protocolSelector = new ProtocolSelector();
        ((System.ComponentModel.ISupportInitialize)nudSpeedJoint).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudY).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudZ).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudRx).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudRy).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudRz).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudSpeedCartesian).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTool).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudUserCoordinate).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panelHostControl.SuspendLayout();
        SuspendLayout();
        // 
        // gridJoints
        // 
        gridJoints.HelpVisible = false;
        gridJoints.Location = new Point(95, 37);
        gridJoints.Name = "gridJoints";
        gridJoints.PropertySort = PropertySort.Alphabetical;
        gridJoints.Size = new Size(160, 194);
        gridJoints.TabIndex = 26;
        gridJoints.ToolbarVisible = false;
        // 
        // btnMoveJoints
        // 
        btnMoveJoints.Location = new Point(95, 319);
        btnMoveJoints.Name = "btnMoveJoints";
        btnMoveJoints.Size = new Size(160, 23);
        btnMoveJoints.TabIndex = 27;
        btnMoveJoints.Text = "Move joints";
        btnMoveJoints.UseVisualStyleBackColor = true;
        btnMoveJoints.Click += btnMoveJoints_Click;
        // 
        // nudSpeedJoint
        // 
        nudSpeedJoint.DecimalPlaces = 2;
        nudSpeedJoint.Location = new Point(95, 278);
        nudSpeedJoint.Name = "nudSpeedJoint";
        nudSpeedJoint.Size = new Size(160, 23);
        nudSpeedJoint.TabIndex = 28;
        nudSpeedJoint.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // label1
        // 
        label1.Location = new Point(80, 255);
        label1.Name = "label1";
        label1.Size = new Size(175, 23);
        label1.TabIndex = 29;
        label1.Text = "Speed (%):";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Location = new Point(71, 11);
        label2.Name = "label2";
        label2.Size = new Size(184, 23);
        label2.TabIndex = 29;
        label2.Text = "Joints position (pulses):";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnMoveCartesian
        // 
        btnMoveCartesian.Location = new Point(81, 371);
        btnMoveCartesian.Name = "btnMoveCartesian";
        btnMoveCartesian.Size = new Size(335, 23);
        btnMoveCartesian.TabIndex = 27;
        btnMoveCartesian.Text = "Move Cartesian";
        btnMoveCartesian.UseVisualStyleBackColor = true;
        btnMoveCartesian.Click += btnMoveCartesian_Click;
        // 
        // label4
        // 
        label4.Location = new Point(66, 34);
        label4.Name = "label4";
        label4.Size = new Size(75, 23);
        label4.TabIndex = 29;
        label4.Text = "X (mm):";
        label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudX
        // 
        nudX.DecimalPlaces = 2;
        nudX.Location = new Point(147, 34);
        nudX.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudX.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudX.Name = "nudX";
        nudX.Size = new Size(94, 23);
        nudX.TabIndex = 28;
        // 
        // nudY
        // 
        nudY.DecimalPlaces = 2;
        nudY.Location = new Point(147, 63);
        nudY.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudY.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudY.Name = "nudY";
        nudY.Size = new Size(94, 23);
        nudY.TabIndex = 28;
        // 
        // label5
        // 
        label5.Location = new Point(66, 63);
        label5.Name = "label5";
        label5.Size = new Size(75, 23);
        label5.TabIndex = 29;
        label5.Text = "Y (mm):";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudZ
        // 
        nudZ.DecimalPlaces = 2;
        nudZ.Location = new Point(147, 92);
        nudZ.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudZ.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudZ.Name = "nudZ";
        nudZ.Size = new Size(94, 23);
        nudZ.TabIndex = 28;
        // 
        // label6
        // 
        label6.Location = new Point(66, 92);
        label6.Name = "label6";
        label6.Size = new Size(75, 23);
        label6.TabIndex = 29;
        label6.Text = "Z (mm):";
        label6.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudRx
        // 
        nudRx.DecimalPlaces = 2;
        nudRx.Location = new Point(147, 121);
        nudRx.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudRx.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudRx.Name = "nudRx";
        nudRx.Size = new Size(94, 23);
        nudRx.TabIndex = 28;
        // 
        // label7
        // 
        label7.Location = new Point(66, 121);
        label7.Name = "label7";
        label7.Size = new Size(75, 23);
        label7.TabIndex = 29;
        label7.Text = "Rx (°):";
        label7.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudRy
        // 
        nudRy.DecimalPlaces = 2;
        nudRy.Location = new Point(147, 150);
        nudRy.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudRy.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudRy.Name = "nudRy";
        nudRy.Size = new Size(94, 23);
        nudRy.TabIndex = 28;
        // 
        // label8
        // 
        label8.Location = new Point(66, 150);
        label8.Name = "label8";
        label8.Size = new Size(75, 23);
        label8.TabIndex = 29;
        label8.Text = "Ry (°):";
        label8.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudRz
        // 
        nudRz.DecimalPlaces = 2;
        nudRz.Location = new Point(147, 179);
        nudRz.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
        nudRz.Minimum = new decimal(new int[] { 1874919423, 2328306, 0, int.MinValue });
        nudRz.Name = "nudRz";
        nudRz.Size = new Size(94, 23);
        nudRz.TabIndex = 28;
        // 
        // label9
        // 
        label9.Location = new Point(66, 179);
        label9.Name = "label9";
        label9.Size = new Size(75, 23);
        label9.TabIndex = 29;
        label9.Text = "Rz (°):";
        label9.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label10
        // 
        label10.Location = new Point(66, 205);
        label10.Name = "label10";
        label10.Size = new Size(75, 23);
        label10.TabIndex = 29;
        label10.Text = "Speed:";
        label10.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // nudSpeedCartesian
        // 
        nudSpeedCartesian.DecimalPlaces = 2;
        nudSpeedCartesian.Location = new Point(81, 226);
        nudSpeedCartesian.Name = "nudSpeedCartesian";
        nudSpeedCartesian.Size = new Size(160, 23);
        nudSpeedCartesian.TabIndex = 28;
        nudSpeedCartesian.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // cbUnit
        // 
        cbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
        cbUnit.FormattingEnabled = true;
        cbUnit.Items.AddRange(new object[] { "%", "mm/s", "°/s" });
        cbUnit.Location = new Point(244, 226);
        cbUnit.Name = "cbUnit";
        cbUnit.Size = new Size(63, 23);
        cbUnit.TabIndex = 30;
        // 
        // label11
        // 
        label11.Location = new Point(66, 252);
        label11.Name = "label11";
        label11.Size = new Size(175, 23);
        label11.TabIndex = 29;
        label11.Text = "Command type:";
        label11.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cbCartesianCommandType
        // 
        cbCartesianCommandType.DropDownStyle = ComboBoxStyle.DropDownList;
        cbCartesianCommandType.FormattingEnabled = true;
        cbCartesianCommandType.Location = new Point(81, 278);
        cbCartesianCommandType.Name = "cbCartesianCommandType";
        cbCartesianCommandType.Size = new Size(160, 23);
        cbCartesianCommandType.TabIndex = 30;
        // 
        // label12
        // 
        label12.Location = new Point(66, 8);
        label12.Name = "label12";
        label12.Size = new Size(184, 23);
        label12.TabIndex = 29;
        label12.Text = "Cartesian position:";
        label12.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label13
        // 
        label13.Location = new Point(66, 304);
        label13.Name = "label13";
        label13.Size = new Size(175, 23);
        label13.TabIndex = 29;
        label13.Text = "Frame:";
        label13.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cbFrame
        // 
        cbFrame.DropDownStyle = ComboBoxStyle.DropDownList;
        cbFrame.FormattingEnabled = true;
        cbFrame.Location = new Point(81, 330);
        cbFrame.Name = "cbFrame";
        cbFrame.Size = new Size(160, 23);
        cbFrame.TabIndex = 30;
        cbFrame.SelectedIndexChanged += cbFrame_SelectedIndexChanged;
        // 
        // gridPosture
        // 
        gridPosture.HelpVisible = false;
        gridPosture.Location = new Point(256, 34);
        gridPosture.Name = "gridPosture";
        gridPosture.PropertySort = PropertySort.Alphabetical;
        gridPosture.Size = new Size(160, 168);
        gridPosture.TabIndex = 26;
        gridPosture.ToolbarVisible = false;
        // 
        // label14
        // 
        label14.Location = new Point(304, 278);
        label14.Name = "label14";
        label14.Size = new Size(51, 23);
        label14.TabIndex = 29;
        label14.Text = "Tool:";
        label14.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudTool
        // 
        nudTool.Location = new Point(361, 278);
        nudTool.Name = "nudTool";
        nudTool.Size = new Size(55, 23);
        nudTool.TabIndex = 28;
        // 
        // label15
        // 
        label15.Location = new Point(257, 329);
        label15.Name = "label15";
        label15.Size = new Size(98, 23);
        label15.TabIndex = 29;
        label15.Text = "User coordinate:";
        label15.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudUserCoordinate
        // 
        nudUserCoordinate.Location = new Point(361, 329);
        nudUserCoordinate.Name = "nudUserCoordinate";
        nudUserCoordinate.Size = new Size(55, 23);
        nudUserCoordinate.TabIndex = 28;
        nudUserCoordinate.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnServoOn
        // 
        btnServoOn.Location = new Point(195, 36);
        btnServoOn.Margin = new Padding(4, 3, 4, 3);
        btnServoOn.Name = "btnServoOn";
        btnServoOn.Size = new Size(152, 40);
        btnServoOn.TabIndex = 31;
        btnServoOn.Text = "Servo ON";
        btnServoOn.UseVisualStyleBackColor = true;
        btnServoOn.Click += btnServoOn_Click;
        // 
        // btnServoOff
        // 
        btnServoOff.Location = new Point(354, 36);
        btnServoOff.Margin = new Padding(4, 3, 4, 3);
        btnServoOff.Name = "btnServoOff";
        btnServoOff.Size = new Size(152, 40);
        btnServoOff.TabIndex = 32;
        btnServoOff.Text = "Servo OFF";
        btnServoOff.UseVisualStyleBackColor = true;
        btnServoOff.Click += btnServoOff_Click;
        // 
        // btnCopyJoint
        // 
        btnCopyJoint.Location = new Point(8, 111);
        btnCopyJoint.Name = "btnCopyJoint";
        btnCopyJoint.Size = new Size(81, 65);
        btnCopyJoint.TabIndex = 33;
        btnCopyJoint.Text = "Copy current position >>";
        btnCopyJoint.UseVisualStyleBackColor = true;
        btnCopyJoint.Click += btnCopyJoint_Click;
        // 
        // btnCopyCartesian
        // 
        btnCopyCartesian.Location = new Point(6, 82);
        btnCopyCartesian.Name = "btnCopyCartesian";
        btnCopyCartesian.Size = new Size(81, 65);
        btnCopyCartesian.TabIndex = 33;
        btnCopyCartesian.Text = "Copy current position >>";
        btnCopyCartesian.UseVisualStyleBackColor = true;
        btnCopyCartesian.Click += btnCopyCartesian_Click;
        // 
        // btnStop
        // 
        btnStop.Location = new Point(230, 523);
        btnStop.Name = "btnStop";
        btnStop.Size = new Size(171, 23);
        btnStop.TabIndex = 34;
        btnStop.Text = "Stop motion";
        btnStop.UseVisualStyleBackColor = true;
        btnStop.Click += btnStop_Click;
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.Fixed3D;
        panel1.Controls.Add(btnCopyJoint);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(nudSpeedJoint);
        panel1.Controls.Add(btnMoveJoints);
        panel1.Controls.Add(gridJoints);
        panel1.Location = new Point(6, 94);
        panel1.Name = "panel1";
        panel1.Size = new Size(276, 411);
        panel1.TabIndex = 35;
        // 
        // panel2
        // 
        panel2.BorderStyle = BorderStyle.Fixed3D;
        panel2.Controls.Add(btnCopyCartesian);
        panel2.Controls.Add(nudUserCoordinate);
        panel2.Controls.Add(nudTool);
        panel2.Controls.Add(nudSpeedCartesian);
        panel2.Controls.Add(cbUnit);
        panel2.Controls.Add(cbFrame);
        panel2.Controls.Add(cbCartesianCommandType);
        panel2.Controls.Add(label12);
        panel2.Controls.Add(label13);
        panel2.Controls.Add(label15);
        panel2.Controls.Add(label11);
        panel2.Controls.Add(label14);
        panel2.Controls.Add(label10);
        panel2.Controls.Add(label9);
        panel2.Controls.Add(label8);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(nudRz);
        panel2.Controls.Add(nudRy);
        panel2.Controls.Add(nudRx);
        panel2.Controls.Add(nudZ);
        panel2.Controls.Add(nudY);
        panel2.Controls.Add(nudX);
        panel2.Controls.Add(btnMoveCartesian);
        panel2.Controls.Add(gridPosture);
        panel2.Location = new Point(304, 94);
        panel2.Name = "panel2";
        panel2.Size = new Size(440, 411);
        panel2.TabIndex = 36;
        // 
        // panelHostControl
        // 
        panelHostControl.BorderStyle = BorderStyle.Fixed3D;
        panelHostControl.Controls.Add(lblHostControl);
        panelHostControl.Controls.Add(lblHcCoord);
        panelHostControl.Controls.Add(cbHcCoord);
        panelHostControl.Controls.Add(lblHcSpeedType);
        panelHostControl.Controls.Add(cbHcSpeedType);
        panelHostControl.Controls.Add(btnHcMoveJoint);
        panelHostControl.Controls.Add(btnHcMoveLinear);
        panelHostControl.Controls.Add(btnHcMoveIncremental);
        panelHostControl.Controls.Add(btnHcMovePulseJoint);
        panelHostControl.Controls.Add(btnHcMovePulseLinear);
        panelHostControl.Location = new Point(750, 94);
        panelHostControl.Name = "panelHostControl";
        panelHostControl.Size = new Size(280, 411);
        panelHostControl.TabIndex = 38;
        // 
        // lblHostControl
        // 
        lblHostControl.Location = new Point(8, 8);
        lblHostControl.Name = "lblHostControl";
        lblHostControl.Size = new Size(260, 20);
        lblHostControl.TabIndex = 0;
        lblHostControl.Text = "Host Control moves";
        lblHostControl.TextAlign = ContentAlignment.MiddleCenter;
        lblHostControl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
        // 
        // lblHcCoord
        // 
        lblHcCoord.AutoSize = true;
        lblHcCoord.Location = new Point(8, 38);
        lblHcCoord.Name = "lblHcCoord";
        lblHcCoord.Size = new Size(115, 15);
        lblHcCoord.TabIndex = 1;
        lblHcCoord.Text = "Coordinate system :";
        // 
        // cbHcCoord
        // 
        cbHcCoord.DropDownStyle = ComboBoxStyle.DropDownList;
        cbHcCoord.FormattingEnabled = true;
        cbHcCoord.Location = new Point(8, 56);
        cbHcCoord.Name = "cbHcCoord";
        cbHcCoord.Size = new Size(260, 23);
        cbHcCoord.TabIndex = 2;
        // 
        // lblHcSpeedType
        // 
        lblHcSpeedType.AutoSize = true;
        lblHcSpeedType.Location = new Point(8, 88);
        lblHcSpeedType.Name = "lblHcSpeedType";
        lblHcSpeedType.Size = new Size(75, 15);
        lblHcSpeedType.TabIndex = 3;
        lblHcSpeedType.Text = "Speed type :";
        // 
        // cbHcSpeedType
        // 
        cbHcSpeedType.DropDownStyle = ComboBoxStyle.DropDownList;
        cbHcSpeedType.FormattingEnabled = true;
        cbHcSpeedType.Location = new Point(8, 106);
        cbHcSpeedType.Name = "cbHcSpeedType";
        cbHcSpeedType.Size = new Size(260, 23);
        cbHcSpeedType.TabIndex = 4;
        // 
        // btnHcMoveJoint
        // 
        btnHcMoveJoint.Location = new Point(8, 145);
        btnHcMoveJoint.Name = "btnHcMoveJoint";
        btnHcMoveJoint.Size = new Size(260, 30);
        btnHcMoveJoint.TabIndex = 5;
        btnHcMoveJoint.Text = "MoveJoint (XYZRxRyRz, % speed)";
        btnHcMoveJoint.UseVisualStyleBackColor = true;
        btnHcMoveJoint.Click += btnHcMoveJoint_Click;
        // 
        // btnHcMoveLinear
        // 
        btnHcMoveLinear.Location = new Point(8, 181);
        btnHcMoveLinear.Name = "btnHcMoveLinear";
        btnHcMoveLinear.Size = new Size(260, 30);
        btnHcMoveLinear.TabIndex = 6;
        btnHcMoveLinear.Text = "MoveLinear (XYZRxRyRz)";
        btnHcMoveLinear.UseVisualStyleBackColor = true;
        btnHcMoveLinear.Click += btnHcMoveLinear_Click;
        // 
        // btnHcMoveIncremental
        // 
        btnHcMoveIncremental.Location = new Point(8, 217);
        btnHcMoveIncremental.Name = "btnHcMoveIncremental";
        btnHcMoveIncremental.Size = new Size(260, 30);
        btnHcMoveIncremental.TabIndex = 7;
        btnHcMoveIncremental.Text = "MoveIncremental (delta XYZRxRyRz)";
        btnHcMoveIncremental.UseVisualStyleBackColor = true;
        btnHcMoveIncremental.Click += btnHcMoveIncremental_Click;
        // 
        // btnHcMovePulseJoint
        // 
        btnHcMovePulseJoint.Location = new Point(8, 263);
        btnHcMovePulseJoint.Name = "btnHcMovePulseJoint";
        btnHcMovePulseJoint.Size = new Size(260, 30);
        btnHcMovePulseJoint.TabIndex = 8;
        btnHcMovePulseJoint.Text = "MovePulseJoint (joint pulses, % speed)";
        btnHcMovePulseJoint.UseVisualStyleBackColor = true;
        btnHcMovePulseJoint.Click += btnHcMovePulseJoint_Click;
        // 
        // btnHcMovePulseLinear
        // 
        btnHcMovePulseLinear.Location = new Point(8, 299);
        btnHcMovePulseLinear.Name = "btnHcMovePulseLinear";
        btnHcMovePulseLinear.Size = new Size(260, 30);
        btnHcMovePulseLinear.TabIndex = 9;
        btnHcMovePulseLinear.Text = "MovePulseLinear (joint pulses)";
        btnHcMovePulseLinear.UseVisualStyleBackColor = true;
        btnHcMovePulseLinear.Click += btnHcMovePulseLinear_Click;
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(1050, 30);
        protocolSelector.TabIndex = 37;
        // 
        // MoveControl
        // 
        Controls.Add(protocolSelector);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(panelHostControl);
        Controls.Add(btnStop);
        Controls.Add(btnServoOn);
        Controls.Add(btnServoOff);
        Name = "MoveControl";
        Size = new Size(1050, 575);
        ((System.ComponentModel.ISupportInitialize)nudSpeedJoint).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudX).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudY).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudZ).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudRx).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudRy).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudRz).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudSpeedCartesian).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTool).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudUserCoordinate).EndInit();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panelHostControl.ResumeLayout(false);
        panelHostControl.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private PropertyGrid gridJoints;
    private Button btnMoveJoints;
    private NumericUpDown nudSpeedJoint;
    private Label label1;
    private Label label2;
    private Button btnMoveCartesian;
    private Label label4;
    private NumericUpDown nudX;
    private NumericUpDown nudY;
    private Label label5;
    private NumericUpDown nudZ;
    private Label label6;
    private NumericUpDown nudRx;
    private Label label7;
    private NumericUpDown nudRy;
    private Label label8;
    private NumericUpDown nudRz;
    private Label label9;
    private Label label10;
    private NumericUpDown nudSpeedCartesian;
    private ComboBox cbUnit;
    private Label label11;
    private ComboBox cbCartesianCommandType;
    private Label label12;
    private Label label13;
    private ComboBox cbFrame;
    private PropertyGrid gridPosture;
    private Label label14;
    private NumericUpDown nudTool;
    private Label label15;
    private NumericUpDown nudUserCoordinate;
    private Button btnServoOn;
    private Button btnServoOff;
    private Button btnCopyJoint;
    private Button btnCopyCartesian;
    private Button btnStop;
    private Panel panel1;
    private Panel panel2;
    private Panel panelHostControl;
    private Label lblHostControl;
    private ComboBox cbHcCoord;
    private Label lblHcCoord;
    private ComboBox cbHcSpeedType;
    private Label lblHcSpeedType;
    private Button btnHcMoveJoint;
    private Button btnHcMoveLinear;
    private Button btnHcMoveIncremental;
    private Button btnHcMovePulseJoint;
    private Button btnHcMovePulseLinear;
    private ProtocolSelector protocolSelector;
}
