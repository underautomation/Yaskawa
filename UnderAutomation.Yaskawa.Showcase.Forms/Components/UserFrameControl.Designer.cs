
partial class UserFrameControl
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
        lblFrameNumber = new Label();
        nudFrameNumber = new NumericUpDown();
        btnGetUserFrame = new Button();
        btnSetUserFrame = new Button();
        gridFrame = new PropertyGrid();
        groupBoxOps = new GroupBox();
        lblRobotGroup = new Label();
        nudRobotGroup = new NumericUpDown();
        lblStationGroup = new Label();
        nudStationGroup = new NumericUpDown();
        btnSetControlGroup = new Button();
        lblTask = new Label();
        nudTask = new NumericUpDown();
        btnSetTask = new Button();
        lblFrameType = new Label();
        nudFrameType = new NumericUpDown();
        btnSetFrameType = new Button();
        btnErrorCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)nudFrameNumber).BeginInit();
        groupBoxOps.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudRobotGroup).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudStationGroup).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTask).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudFrameType).BeginInit();
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
        // lblFrameNumber
        // 
        lblFrameNumber.AutoSize = true;
        lblFrameNumber.Location = new Point(12, 50);
        lblFrameNumber.Name = "lblFrameNumber";
        lblFrameNumber.Size = new Size(100, 15);
        lblFrameNumber.TabIndex = 0;
        lblFrameNumber.Text = "User frame # :";
        // 
        // nudFrameNumber
        // 
        nudFrameNumber.Location = new Point(118, 48);
        nudFrameNumber.Maximum = new decimal(new int[] { 63, 0, 0, 0 });
        nudFrameNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudFrameNumber.Name = "nudFrameNumber";
        nudFrameNumber.Size = new Size(80, 23);
        nudFrameNumber.TabIndex = 1;
        nudFrameNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // btnGetUserFrame
        // 
        btnGetUserFrame.Location = new Point(12, 80);
        btnGetUserFrame.Name = "btnGetUserFrame";
        btnGetUserFrame.Size = new Size(186, 28);
        btnGetUserFrame.TabIndex = 2;
        btnGetUserFrame.Text = "Get user frame";
        btnGetUserFrame.UseVisualStyleBackColor = true;
        btnGetUserFrame.Click += btnGetUserFrame_Click;
        // 
        // btnSetUserFrame
        // 
        btnSetUserFrame.Location = new Point(12, 114);
        btnSetUserFrame.Name = "btnSetUserFrame";
        btnSetUserFrame.Size = new Size(186, 28);
        btnSetUserFrame.TabIndex = 3;
        btnSetUserFrame.Text = "Set user frame (from grid)";
        btnSetUserFrame.UseVisualStyleBackColor = true;
        btnSetUserFrame.Click += btnSetUserFrame_Click;
        // 
        // gridFrame
        // 
        gridFrame.Location = new Point(214, 48);
        gridFrame.Name = "gridFrame";
        gridFrame.Size = new Size(564, 380);
        gridFrame.TabIndex = 4;
        // 
        // groupBoxOps
        // 
        groupBoxOps.Controls.Add(lblRobotGroup);
        groupBoxOps.Controls.Add(nudRobotGroup);
        groupBoxOps.Controls.Add(lblStationGroup);
        groupBoxOps.Controls.Add(nudStationGroup);
        groupBoxOps.Controls.Add(btnSetControlGroup);
        groupBoxOps.Controls.Add(lblTask);
        groupBoxOps.Controls.Add(nudTask);
        groupBoxOps.Controls.Add(btnSetTask);
        groupBoxOps.Controls.Add(lblFrameType);
        groupBoxOps.Controls.Add(nudFrameType);
        groupBoxOps.Controls.Add(btnSetFrameType);
        groupBoxOps.Controls.Add(btnErrorCancel);
        groupBoxOps.Location = new Point(12, 160);
        groupBoxOps.Name = "groupBoxOps";
        groupBoxOps.Size = new Size(186, 268);
        groupBoxOps.TabIndex = 5;
        groupBoxOps.TabStop = false;
        groupBoxOps.Text = "Other commands";
        // 
        // lblRobotGroup
        // 
        lblRobotGroup.AutoSize = true;
        lblRobotGroup.Location = new Point(10, 22);
        lblRobotGroup.Name = "lblRobotGroup";
        lblRobotGroup.Size = new Size(80, 15);
        lblRobotGroup.TabIndex = 0;
        lblRobotGroup.Text = "Robot group :";
        // 
        // nudRobotGroup
        // 
        nudRobotGroup.Location = new Point(110, 20);
        nudRobotGroup.Name = "nudRobotGroup";
        nudRobotGroup.Size = new Size(60, 23);
        nudRobotGroup.TabIndex = 1;
        // 
        // lblStationGroup
        // 
        lblStationGroup.AutoSize = true;
        lblStationGroup.Location = new Point(10, 50);
        lblStationGroup.Name = "lblStationGroup";
        lblStationGroup.Size = new Size(85, 15);
        lblStationGroup.TabIndex = 2;
        lblStationGroup.Text = "Station group :";
        // 
        // nudStationGroup
        // 
        nudStationGroup.Location = new Point(110, 48);
        nudStationGroup.Name = "nudStationGroup";
        nudStationGroup.Size = new Size(60, 23);
        nudStationGroup.TabIndex = 3;
        // 
        // btnSetControlGroup
        // 
        btnSetControlGroup.Location = new Point(10, 76);
        btnSetControlGroup.Name = "btnSetControlGroup";
        btnSetControlGroup.Size = new Size(160, 26);
        btnSetControlGroup.TabIndex = 4;
        btnSetControlGroup.Text = "Set control group";
        btnSetControlGroup.UseVisualStyleBackColor = true;
        btnSetControlGroup.Click += btnSetControlGroup_Click;
        // 
        // lblTask
        // 
        lblTask.AutoSize = true;
        lblTask.Location = new Point(10, 115);
        lblTask.Name = "lblTask";
        lblTask.Size = new Size(40, 15);
        lblTask.TabIndex = 5;
        lblTask.Text = "Task :";
        // 
        // nudTask
        // 
        nudTask.Location = new Point(110, 113);
        nudTask.Name = "nudTask";
        nudTask.Size = new Size(60, 23);
        nudTask.TabIndex = 6;
        // 
        // btnSetTask
        // 
        btnSetTask.Location = new Point(10, 138);
        btnSetTask.Name = "btnSetTask";
        btnSetTask.Size = new Size(160, 26);
        btnSetTask.TabIndex = 7;
        btnSetTask.Text = "Set task";
        btnSetTask.UseVisualStyleBackColor = true;
        btnSetTask.Click += btnSetTask_Click;
        // 
        // lblFrameType
        // 
        lblFrameType.AutoSize = true;
        lblFrameType.Location = new Point(10, 175);
        lblFrameType.Name = "lblFrameType";
        lblFrameType.Size = new Size(75, 15);
        lblFrameType.TabIndex = 8;
        lblFrameType.Text = "Frame type :";
        // 
        // nudFrameType
        // 
        nudFrameType.Location = new Point(110, 173);
        nudFrameType.Name = "nudFrameType";
        nudFrameType.Size = new Size(60, 23);
        nudFrameType.TabIndex = 9;
        // 
        // btnSetFrameType
        // 
        btnSetFrameType.Location = new Point(10, 198);
        btnSetFrameType.Name = "btnSetFrameType";
        btnSetFrameType.Size = new Size(160, 26);
        btnSetFrameType.TabIndex = 10;
        btnSetFrameType.Text = "Set frame type";
        btnSetFrameType.UseVisualStyleBackColor = true;
        btnSetFrameType.Click += btnSetFrameType_Click;
        // 
        // btnErrorCancel
        // 
        btnErrorCancel.Location = new Point(10, 232);
        btnErrorCancel.Name = "btnErrorCancel";
        btnErrorCancel.Size = new Size(160, 26);
        btnErrorCancel.TabIndex = 11;
        btnErrorCancel.Text = "Cancel error (RESET)";
        btnErrorCancel.UseVisualStyleBackColor = true;
        btnErrorCancel.Click += btnErrorCancel_Click;
        // 
        // UserFrameControl
        // 
        Controls.Add(gridFrame);
        Controls.Add(groupBoxOps);
        Controls.Add(btnSetUserFrame);
        Controls.Add(btnGetUserFrame);
        Controls.Add(nudFrameNumber);
        Controls.Add(lblFrameNumber);
        Controls.Add(protocolSelector);
        Name = "UserFrameControl";
        Size = new Size(797, 647);
        ((System.ComponentModel.ISupportInitialize)nudFrameNumber).EndInit();
        groupBoxOps.ResumeLayout(false);
        groupBoxOps.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudRobotGroup).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudStationGroup).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTask).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudFrameType).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ProtocolSelector protocolSelector;
    private Label lblFrameNumber;
    private NumericUpDown nudFrameNumber;
    private Button btnGetUserFrame;
    private Button btnSetUserFrame;
    private PropertyGrid gridFrame;
    private GroupBox groupBoxOps;
    private Label lblRobotGroup;
    private NumericUpDown nudRobotGroup;
    private Label lblStationGroup;
    private NumericUpDown nudStationGroup;
    private Button btnSetControlGroup;
    private Label lblTask;
    private NumericUpDown nudTask;
    private Button btnSetTask;
    private Label lblFrameType;
    private NumericUpDown nudFrameType;
    private Button btnSetFrameType;
    private Button btnErrorCancel;
}
