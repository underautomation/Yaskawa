
partial class PositionControl
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
        worker = new System.ComponentModel.BackgroundWorker();
        gridJoints = new PropertyGrid();
        label2 = new Label();
        label1 = new Label();
        gridCartesian = new PropertyGrid();
        label3 = new Label();
        gridError = new PropertyGrid();
        gridConfig = new PropertyGrid();
        gridTorque = new PropertyGrid();
        lblConfig = new Label();
        lblTorque = new Label();
        btnGetAxisConfig = new Button();
        btnGetTorqueHses = new Button();
        btnGetTorque = new Button();
        protocolSelector = new ProtocolSelector();
        SuspendLayout();
        // 
        // worker
        // 
        worker.WorkerSupportsCancellation = true;
        worker.DoWork += worker_DoWork;
        // 
        // gridJoints
        // 
        gridJoints.HelpVisible = false;
        gridJoints.Location = new Point(18, 77);
        gridJoints.Name = "gridJoints";
        gridJoints.PropertySort = PropertySort.Alphabetical;
        gridJoints.Size = new Size(228, 521);
        gridJoints.TabIndex = 25;
        gridJoints.ToolbarVisible = false;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(18, 59);
        label2.Name = "label2";
        label2.Size = new Size(89, 15);
        label2.TabIndex = 24;
        label2.Text = "Joints position :";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(264, 59);
        label1.Name = "label1";
        label1.Size = new Size(108, 15);
        label1.TabIndex = 24;
        label1.Text = "Cartesian position :";
        // 
        // gridCartesian
        // 
        gridCartesian.HelpVisible = false;
        gridCartesian.Location = new Point(264, 77);
        gridCartesian.Name = "gridCartesian";
        gridCartesian.PropertySort = PropertySort.Alphabetical;
        gridCartesian.Size = new Size(228, 521);
        gridCartesian.TabIndex = 25;
        gridCartesian.ToolbarVisible = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(507, 59);
        label3.Name = "label3";
        label3.Size = new Size(84, 15);
        label3.TabIndex = 24;
        label3.Text = "Position error :";
        // 
        // gridError
        // 
        gridError.HelpVisible = false;
        gridError.Location = new Point(507, 77);
        gridError.Name = "gridError";
        gridError.PropertySort = PropertySort.Alphabetical;
        gridError.Size = new Size(228, 521);
        gridError.TabIndex = 25;
        gridError.ToolbarVisible = false;
        // 
        // lblConfig
        // 
        lblConfig.AutoSize = true;
        lblConfig.Location = new Point(750, 59);
        lblConfig.Name = "lblConfig";
        lblConfig.Size = new Size(120, 15);
        lblConfig.TabIndex = 27;
        lblConfig.Text = "Axis configuration :";
        // 
        // gridConfig
        // 
        gridConfig.HelpVisible = false;
        gridConfig.Location = new Point(750, 77);
        gridConfig.Name = "gridConfig";
        gridConfig.PropertySort = PropertySort.Alphabetical;
        gridConfig.Size = new Size(228, 240);
        gridConfig.TabIndex = 28;
        gridConfig.ToolbarVisible = false;
        // 
        // btnGetAxisConfig
        // 
        btnGetAxisConfig.Location = new Point(750, 323);
        btnGetAxisConfig.Name = "btnGetAxisConfig";
        btnGetAxisConfig.Size = new Size(228, 25);
        btnGetAxisConfig.TabIndex = 29;
        btnGetAxisConfig.Text = "Get axis configuration (HSES)";
        btnGetAxisConfig.UseVisualStyleBackColor = true;
        btnGetAxisConfig.Click += btnGetAxisConfig_Click;
        // 
        // lblTorque
        // 
        lblTorque.AutoSize = true;
        lblTorque.Location = new Point(750, 360);
        lblTorque.Name = "lblTorque";
        lblTorque.Size = new Size(50, 15);
        lblTorque.TabIndex = 30;
        lblTorque.Text = "Torque :";
        // 
        // gridTorque
        // 
        gridTorque.HelpVisible = false;
        gridTorque.Location = new Point(750, 378);
        gridTorque.Name = "gridTorque";
        gridTorque.PropertySort = PropertySort.Alphabetical;
        gridTorque.Size = new Size(228, 160);
        gridTorque.TabIndex = 31;
        gridTorque.ToolbarVisible = false;
        // 
        // btnGetTorqueHses
        // 
        btnGetTorqueHses.Location = new Point(750, 544);
        btnGetTorqueHses.Name = "btnGetTorqueHses";
        btnGetTorqueHses.Size = new Size(228, 25);
        btnGetTorqueHses.TabIndex = 32;
        btnGetTorqueHses.Text = "Get torque (HSES)";
        btnGetTorqueHses.UseVisualStyleBackColor = true;
        btnGetTorqueHses.Click += btnGetTorqueHses_Click;
        // 
        // btnGetTorque
        // 
        btnGetTorque.Location = new Point(750, 575);
        btnGetTorque.Name = "btnGetTorque";
        btnGetTorque.Size = new Size(228, 25);
        btnGetTorque.TabIndex = 33;
        btnGetTorque.Text = "Get torque (selected protocol)";
        btnGetTorque.UseVisualStyleBackColor = true;
        btnGetTorque.Click += btnGetTorque_Click;
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(1000, 30);
        protocolSelector.TabIndex = 26;
        // 
        // PositionControl
        // 
        Controls.Add(protocolSelector);
        Controls.Add(btnGetTorque);
        Controls.Add(btnGetTorqueHses);
        Controls.Add(gridTorque);
        Controls.Add(lblTorque);
        Controls.Add(btnGetAxisConfig);
        Controls.Add(gridConfig);
        Controls.Add(lblConfig);
        Controls.Add(gridError);
        Controls.Add(label3);
        Controls.Add(gridCartesian);
        Controls.Add(label1);
        Controls.Add(gridJoints);
        Controls.Add(label2);
        Name = "PositionControl";
        Size = new Size(1000, 620);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.ComponentModel.BackgroundWorker worker;
    private System.Windows.Forms.PropertyGrid gridJoints;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PropertyGrid gridCartesian;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PropertyGrid gridError;
    private System.Windows.Forms.PropertyGrid gridConfig;
    private System.Windows.Forms.PropertyGrid gridTorque;
    private System.Windows.Forms.Label lblConfig;
    private System.Windows.Forms.Label lblTorque;
    private System.Windows.Forms.Button btnGetAxisConfig;
    private System.Windows.Forms.Button btnGetTorqueHses;
    private System.Windows.Forms.Button btnGetTorque;
    private ProtocolSelector protocolSelector;
}
