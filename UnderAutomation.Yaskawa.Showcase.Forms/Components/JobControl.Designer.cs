
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
        protocolSelector = new ProtocolSelector();
        ((System.ComponentModel.ISupportInitialize)udJobLine).BeginInit();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)udTaskId).BeginInit();
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
    private ProtocolSelector protocolSelector;
}
