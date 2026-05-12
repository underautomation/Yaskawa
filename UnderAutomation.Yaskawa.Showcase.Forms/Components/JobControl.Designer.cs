
partial class JobControl
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
        gridExecuting = new PropertyGrid();
        label3 = new Label();
        gridStatus = new PropertyGrid();
        udJobLine = new NumericUpDown();
        btnSelect = new Button();
        btnRefresh = new Button();
        cbJobs = new ComboBox();
        txtJobLine = new Label();
        txtJobList = new Label();
        label2 = new Label();
        btnServoOff = new Button();
        btnServoOn = new Button();
        btnStart = new Button();
        panel1 = new Panel();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        groupBox1 = new GroupBox();
        txtCallStack = new TextBox();
        btnGetCallStack = new Button();
        label1 = new Label();
        udTaskId = new NumericUpDown();
        groupBoxHostControl = new GroupBox();
        txtJobName = new TextBox();
        lblJobName = new Label();
        btnGetJobDirectory = new Button();
        btnDeleteJob = new Button();
        btnSetMasterJob = new Button();
        btnWaitCompletion = new Button();
        udTimeout = new NumericUpDown();
        lblTimeout = new Label();
        btnConvertToRelative = new Button();
        btnConvertToStandard = new Button();
        cbCoordSystem = new ComboBox();
        lblCoordSystem = new Label();
        udConvertMethod = new NumericUpDown();
        lblConvertMethod = new Label();
        udRefPosVar = new NumericUpDown();
        lblRefPosVar = new Label();
        protocolSelector = new ProtocolSelector();
        ((System.ComponentModel.ISupportInitialize)udJobLine).BeginInit();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udTaskId).BeginInit();
        groupBoxHostControl.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udTimeout).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udConvertMethod).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udRefPosVar).BeginInit();
        SuspendLayout();
        // 
        // gridExecuting
        // 
        gridExecuting.HelpVisible = false;
        gridExecuting.Location = new Point(28, 394);
        gridExecuting.Margin = new Padding(4, 3, 4, 3);
        gridExecuting.Name = "gridExecuting";
        gridExecuting.Size = new Size(322, 107);
        gridExecuting.TabIndex = 18;
        gridExecuting.ToolbarVisible = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(24, 376);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(84, 15);
        label3.TabIndex = 16;
        label3.Text = "Executing job :";
        // 
        // gridStatus
        // 
        gridStatus.HelpVisible = false;
        gridStatus.Location = new Point(28, 69);
        gridStatus.Margin = new Padding(4, 3, 4, 3);
        gridStatus.Name = "gridStatus";
        gridStatus.PropertySort = PropertySort.Alphabetical;
        gridStatus.Size = new Size(322, 285);
        gridStatus.TabIndex = 19;
        gridStatus.ToolbarVisible = false;
        // 
        // udJobLine
        // 
        udJobLine.Location = new Point(110, 171);
        udJobLine.Margin = new Padding(4, 3, 4, 3);
        udJobLine.Name = "udJobLine";
        udJobLine.Size = new Size(64, 23);
        udJobLine.TabIndex = 11;
        // 
        // btnSelect
        // 
        btnSelect.Location = new Point(22, 223);
        btnSelect.Margin = new Padding(4, 3, 4, 3);
        btnSelect.Name = "btnSelect";
        btnSelect.Size = new Size(310, 40);
        btnSelect.TabIndex = 10;
        btnSelect.Text = "Select job";
        btnSelect.UseVisualStyleBackColor = true;
        btnSelect.Click += btnSelect_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(254, 123);
        btnRefresh.Margin = new Padding(4, 3, 4, 3);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(78, 27);
        btnRefresh.TabIndex = 10;
        btnRefresh.Text = "Refresh list";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // cbJobs
        // 
        cbJobs.FormattingEnabled = true;
        cbJobs.Location = new Point(22, 126);
        cbJobs.Margin = new Padding(4, 3, 4, 3);
        cbJobs.Name = "cbJobs";
        cbJobs.Size = new Size(223, 23);
        cbJobs.TabIndex = 0;
        // 
        // txtJobLine
        // 
        txtJobLine.AutoSize = true;
        txtJobLine.Location = new Point(19, 173);
        txtJobLine.Margin = new Padding(4, 0, 4, 0);
        txtJobLine.Name = "txtJobLine";
        txtJobLine.Size = new Size(79, 15);
        txtJobLine.TabIndex = 9;
        txtJobLine.Text = "Job start line :";
        // 
        // txtJobList
        // 
        txtJobList.AutoSize = true;
        txtJobList.Location = new Point(19, 107);
        txtJobList.Margin = new Padding(4, 0, 4, 0);
        txtJobList.Name = "txtJobList";
        txtJobList.Size = new Size(73, 15);
        txtJobList.TabIndex = 9;
        txtJobList.Text = "Select a job :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(24, 50);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(85, 15);
        label2.TabIndex = 17;
        label2.Text = "System status :";
        // 
        // btnServoOff
        // 
        btnServoOff.Location = new Point(181, 27);
        btnServoOff.Margin = new Padding(4, 3, 4, 3);
        btnServoOff.Name = "btnServoOff";
        btnServoOff.Size = new Size(152, 40);
        btnServoOff.TabIndex = 11;
        btnServoOff.Text = "Servo OFF";
        btnServoOff.UseVisualStyleBackColor = true;
        btnServoOff.Click += btnServoOff_Click;
        // 
        // btnServoOn
        // 
        btnServoOn.Location = new Point(22, 27);
        btnServoOn.Margin = new Padding(4, 3, 4, 3);
        btnServoOn.Name = "btnServoOn";
        btnServoOn.Size = new Size(152, 40);
        btnServoOn.TabIndex = 11;
        btnServoOn.Text = "Servo ON";
        btnServoOn.UseVisualStyleBackColor = true;
        btnServoOn.Click += btnServoOn_Click;
        // 
        // btnStart
        // 
        btnStart.Location = new Point(22, 300);
        btnStart.Margin = new Padding(4, 3, 4, 3);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(309, 40);
        btnStart.TabIndex = 11;
        btnStart.Text = "Start selected job";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(btnServoOn);
        panel1.Controls.Add(btnStart);
        panel1.Controls.Add(txtJobList);
        panel1.Controls.Add(udJobLine);
        panel1.Controls.Add(txtJobLine);
        panel1.Controls.Add(btnServoOff);
        panel1.Controls.Add(cbJobs);
        panel1.Controls.Add(btnSelect);
        panel1.Controls.Add(btnRefresh);
        panel1.Location = new Point(392, 69);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(351, 432);
        panel1.TabIndex = 20;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtCallStack);
        groupBox1.Controls.Add(btnGetCallStack);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(udTaskId);
        groupBox1.Location = new Point(28, 529);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(337, 238);
        groupBox1.TabIndex = 21;
        groupBox1.TabStop = false;
        groupBox1.Text = "Call stack";
        // 
        // txtCallStack
        // 
        txtCallStack.Location = new Point(32, 83);
        txtCallStack.Multiline = true;
        txtCallStack.Name = "txtCallStack";
        txtCallStack.ReadOnly = true;
        txtCallStack.ScrollBars = ScrollBars.Both;
        txtCallStack.Size = new Size(290, 149);
        txtCallStack.TabIndex = 3;
        // 
        // btnGetCallStack
        // 
        btnGetCallStack.Location = new Point(158, 43);
        btnGetCallStack.Name = "btnGetCallStack";
        btnGetCallStack.Size = new Size(164, 23);
        btnGetCallStack.TabIndex = 2;
        btnGetCallStack.Text = "Get call stack";
        btnGetCallStack.UseVisualStyleBackColor = true;
        btnGetCallStack.Click += btnGetCallStack_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 25);
        label1.Name = "label1";
        label1.Size = new Size(49, 15);
        label1.TabIndex = 1;
        label1.Text = "Task id :";
        // 
        // udTaskId
        // 
        udTaskId.Location = new Point(32, 43);
        udTaskId.Name = "udTaskId";
        udTaskId.Size = new Size(120, 23);
        udTaskId.TabIndex = 0;
        // 
        // groupBoxHostControl
        // 
        groupBoxHostControl.Controls.Add(lblJobName);
        groupBoxHostControl.Controls.Add(txtJobName);
        groupBoxHostControl.Controls.Add(btnGetJobDirectory);
        groupBoxHostControl.Controls.Add(btnDeleteJob);
        groupBoxHostControl.Controls.Add(btnSetMasterJob);
        groupBoxHostControl.Controls.Add(btnWaitCompletion);
        groupBoxHostControl.Controls.Add(udTimeout);
        groupBoxHostControl.Controls.Add(lblTimeout);
        groupBoxHostControl.Controls.Add(lblCoordSystem);
        groupBoxHostControl.Controls.Add(cbCoordSystem);
        groupBoxHostControl.Controls.Add(btnConvertToRelative);
        groupBoxHostControl.Controls.Add(lblConvertMethod);
        groupBoxHostControl.Controls.Add(udConvertMethod);
        groupBoxHostControl.Controls.Add(lblRefPosVar);
        groupBoxHostControl.Controls.Add(udRefPosVar);
        groupBoxHostControl.Controls.Add(btnConvertToStandard);
        groupBoxHostControl.Location = new Point(392, 529);
        groupBoxHostControl.Name = "groupBoxHostControl";
        groupBoxHostControl.Size = new Size(420, 320);
        groupBoxHostControl.TabIndex = 22;
        groupBoxHostControl.TabStop = false;
        groupBoxHostControl.Text = "Host Control job operations";
        // 
        // lblJobName
        // 
        lblJobName.AutoSize = true;
        lblJobName.Location = new Point(12, 25);
        lblJobName.Name = "lblJobName";
        lblJobName.Size = new Size(67, 15);
        lblJobName.TabIndex = 0;
        lblJobName.Text = "Job name :";
        // 
        // txtJobName
        // 
        txtJobName.Location = new Point(12, 43);
        txtJobName.Name = "txtJobName";
        txtJobName.Size = new Size(200, 23);
        txtJobName.TabIndex = 1;
        // 
        // btnGetJobDirectory
        // 
        btnGetJobDirectory.Location = new Point(218, 22);
        btnGetJobDirectory.Name = "btnGetJobDirectory";
        btnGetJobDirectory.Size = new Size(190, 23);
        btnGetJobDirectory.TabIndex = 2;
        btnGetJobDirectory.Text = "Get job directory (filter pattern)";
        btnGetJobDirectory.UseVisualStyleBackColor = true;
        btnGetJobDirectory.Click += btnGetJobDirectory_Click;
        // 
        // btnDeleteJob
        // 
        btnDeleteJob.Location = new Point(218, 47);
        btnDeleteJob.Name = "btnDeleteJob";
        btnDeleteJob.Size = new Size(95, 23);
        btnDeleteJob.TabIndex = 3;
        btnDeleteJob.Text = "Delete job";
        btnDeleteJob.UseVisualStyleBackColor = true;
        btnDeleteJob.Click += btnDeleteJob_Click;
        // 
        // btnSetMasterJob
        // 
        btnSetMasterJob.Location = new Point(313, 47);
        btnSetMasterJob.Name = "btnSetMasterJob";
        btnSetMasterJob.Size = new Size(95, 23);
        btnSetMasterJob.TabIndex = 4;
        btnSetMasterJob.Text = "Set master";
        btnSetMasterJob.UseVisualStyleBackColor = true;
        btnSetMasterJob.Click += btnSetMasterJob_Click;
        // 
        // lblTimeout
        // 
        lblTimeout.AutoSize = true;
        lblTimeout.Location = new Point(12, 88);
        lblTimeout.Name = "lblTimeout";
        lblTimeout.Size = new Size(67, 15);
        lblTimeout.TabIndex = 5;
        lblTimeout.Text = "Timeout (s) :";
        // 
        // udTimeout
        // 
        udTimeout.Location = new Point(85, 86);
        udTimeout.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
        udTimeout.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
        udTimeout.Name = "udTimeout";
        udTimeout.Size = new Size(80, 23);
        udTimeout.TabIndex = 6;
        udTimeout.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
        // 
        // btnWaitCompletion
        // 
        btnWaitCompletion.Location = new Point(218, 84);
        btnWaitCompletion.Name = "btnWaitCompletion";
        btnWaitCompletion.Size = new Size(190, 23);
        btnWaitCompletion.TabIndex = 7;
        btnWaitCompletion.Text = "Wait for job completion";
        btnWaitCompletion.UseVisualStyleBackColor = true;
        btnWaitCompletion.Click += btnWaitCompletion_Click;
        // 
        // lblCoordSystem
        // 
        lblCoordSystem.AutoSize = true;
        lblCoordSystem.Location = new Point(12, 130);
        lblCoordSystem.Name = "lblCoordSystem";
        lblCoordSystem.Size = new Size(115, 15);
        lblCoordSystem.TabIndex = 8;
        lblCoordSystem.Text = "Coordinate system :";
        // 
        // cbCoordSystem
        // 
        cbCoordSystem.DropDownStyle = ComboBoxStyle.DropDownList;
        cbCoordSystem.FormattingEnabled = true;
        cbCoordSystem.Location = new Point(12, 148);
        cbCoordSystem.Name = "cbCoordSystem";
        cbCoordSystem.Size = new Size(200, 23);
        cbCoordSystem.TabIndex = 9;
        // 
        // btnConvertToRelative
        // 
        btnConvertToRelative.Location = new Point(218, 148);
        btnConvertToRelative.Name = "btnConvertToRelative";
        btnConvertToRelative.Size = new Size(190, 23);
        btnConvertToRelative.TabIndex = 10;
        btnConvertToRelative.Text = "Convert to relative job";
        btnConvertToRelative.UseVisualStyleBackColor = true;
        btnConvertToRelative.Click += btnConvertToRelative_Click;
        // 
        // lblConvertMethod
        // 
        lblConvertMethod.AutoSize = true;
        lblConvertMethod.Location = new Point(12, 195);
        lblConvertMethod.Name = "lblConvertMethod";
        lblConvertMethod.Size = new Size(110, 15);
        lblConvertMethod.TabIndex = 11;
        lblConvertMethod.Text = "Converting method :";
        // 
        // udConvertMethod
        // 
        udConvertMethod.Location = new Point(128, 193);
        udConvertMethod.Name = "udConvertMethod";
        udConvertMethod.Size = new Size(80, 23);
        udConvertMethod.TabIndex = 12;
        // 
        // lblRefPosVar
        // 
        lblRefPosVar.AutoSize = true;
        lblRefPosVar.Location = new Point(12, 224);
        lblRefPosVar.Name = "lblRefPosVar";
        lblRefPosVar.Size = new Size(105, 15);
        lblRefPosVar.TabIndex = 13;
        lblRefPosVar.Text = "Reference pos. var :";
        // 
        // udRefPosVar
        // 
        udRefPosVar.Location = new Point(128, 222);
        udRefPosVar.Name = "udRefPosVar";
        udRefPosVar.Size = new Size(80, 23);
        udRefPosVar.TabIndex = 14;
        // 
        // btnConvertToStandard
        // 
        btnConvertToStandard.Location = new Point(218, 220);
        btnConvertToStandard.Name = "btnConvertToStandard";
        btnConvertToStandard.Size = new Size(190, 23);
        btnConvertToStandard.TabIndex = 15;
        btnConvertToStandard.Text = "Convert to standard job";
        btnConvertToStandard.UseVisualStyleBackColor = true;
        btnConvertToStandard.Click += btnConvertToStandard_Click;
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(1062, 30);
        protocolSelector.TabIndex = 22;
        // 
        // JobControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(protocolSelector);
        Controls.Add(groupBoxHostControl);
        Controls.Add(groupBox1);
        Controls.Add(panel1);
        Controls.Add(gridExecuting);
        Controls.Add(label3);
        Controls.Add(gridStatus);
        Controls.Add(label2);
        Margin = new Padding(4, 3, 4, 3);
        Name = "JobControl";
        Size = new Size(1062, 857);
        ((System.ComponentModel.ISupportInitialize)udJobLine).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udTaskId).EndInit();
        groupBoxHostControl.ResumeLayout(false);
        groupBoxHostControl.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)udTimeout).EndInit();
        ((System.ComponentModel.ISupportInitialize)udConvertMethod).EndInit();
        ((System.ComponentModel.ISupportInitialize)udRefPosVar).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.PropertyGrid gridExecuting;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PropertyGrid gridStatus;
    private System.Windows.Forms.NumericUpDown udJobLine;
    private System.Windows.Forms.Button btnSelect;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.ComboBox cbJobs;
    private System.Windows.Forms.Label txtJobLine;
    private System.Windows.Forms.Label txtJobList;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnServoOff;
    private System.Windows.Forms.Button btnServoOn;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Panel panel1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private GroupBox groupBox1;
    private TextBox txtCallStack;
    private Button btnGetCallStack;
    private Label label1;
    private NumericUpDown udTaskId;
    private GroupBox groupBoxHostControl;
    private TextBox txtJobName;
    private Label lblJobName;
    private Button btnGetJobDirectory;
    private Button btnDeleteJob;
    private Button btnSetMasterJob;
    private Button btnWaitCompletion;
    private NumericUpDown udTimeout;
    private Label lblTimeout;
    private Button btnConvertToRelative;
    private Button btnConvertToStandard;
    private ComboBox cbCoordSystem;
    private Label lblCoordSystem;
    private NumericUpDown udConvertMethod;
    private Label lblConvertMethod;
    private NumericUpDown udRefPosVar;
    private Label lblRefPosVar;
    private ProtocolSelector protocolSelector;
}
