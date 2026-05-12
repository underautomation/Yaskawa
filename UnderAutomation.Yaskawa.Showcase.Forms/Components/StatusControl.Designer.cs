
partial class StatusControl
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
        gridExecuting = new PropertyGrid();
        label3 = new Label();
        gridStatus = new PropertyGrid();
        label2 = new Label();
        gridTime = new PropertyGrid();
        gridInfo = new PropertyGrid();
        label4 = new Label();
        label1 = new Label();
        protocolSelector = new ProtocolSelector();
        SuspendLayout();
        // 
        // worker
        // 
        worker.WorkerSupportsCancellation = true;
        worker.DoWork += worker_DoWork;
        // 
        // gridExecuting
        // 
        gridExecuting.HelpVisible = false;
        gridExecuting.Location = new Point(24, 352);
        gridExecuting.Name = "gridExecuting";
        gridExecuting.PropertySort = PropertySort.Alphabetical;
        gridExecuting.Size = new Size(276, 96);
        gridExecuting.TabIndex = 22;
        gridExecuting.ToolbarVisible = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(21, 336);
        label3.Name = "label3";
        label3.Size = new Size(84, 15);
        label3.TabIndex = 20;
        label3.Text = "Executing job :";
        // 
        // gridStatus
        // 
        gridStatus.HelpVisible = false;
        gridStatus.Location = new Point(24, 62);
        gridStatus.Name = "gridStatus";
        gridStatus.PropertySort = PropertySort.Alphabetical;
        gridStatus.Size = new Size(276, 245);
        gridStatus.TabIndex = 23;
        gridStatus.ToolbarVisible = false;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(21, 46);
        label2.Name = "label2";
        label2.Size = new Size(85, 15);
        label2.TabIndex = 21;
        label2.Text = "System status :";
        // 
        // gridTime
        // 
        gridTime.HelpVisible = false;
        gridTime.Location = new Point(329, 62);
        gridTime.Name = "gridTime";
        gridTime.PropertySort = PropertySort.Alphabetical;
        gridTime.Size = new Size(455, 487);
        gridTime.TabIndex = 26;
        gridTime.ToolbarVisible = false;
        // 
        // gridInfo
        // 
        gridInfo.HelpVisible = false;
        gridInfo.Location = new Point(26, 480);
        gridInfo.Name = "gridInfo";
        gridInfo.PropertySort = PropertySort.Alphabetical;
        gridInfo.Size = new Size(274, 69);
        gridInfo.TabIndex = 27;
        gridInfo.ToolbarVisible = false;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(326, 46);
        label4.Name = "label4";
        label4.Size = new Size(111, 15);
        label4.TabIndex = 24;
        label4.Text = "Management time :";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(23, 464);
        label1.Name = "label1";
        label1.Size = new Size(117, 15);
        label1.TabIndex = 25;
        label1.Text = "System information :";
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(797, 30);
        protocolSelector.TabIndex = 28;
        // 
        // StatusControl
        // 
        Controls.Add(protocolSelector);
        Controls.Add(gridTime);
        Controls.Add(gridInfo);
        Controls.Add(label4);
        Controls.Add(label1);
        Controls.Add(gridExecuting);
        Controls.Add(label3);
        Controls.Add(gridStatus);
        Controls.Add(label2);
        Name = "StatusControl";
        Size = new Size(797, 647);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.ComponentModel.BackgroundWorker worker;
    private System.Windows.Forms.PropertyGrid gridExecuting;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PropertyGrid gridStatus;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PropertyGrid gridTime;
    private System.Windows.Forms.PropertyGrid gridInfo;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private ProtocolSelector protocolSelector;
}
