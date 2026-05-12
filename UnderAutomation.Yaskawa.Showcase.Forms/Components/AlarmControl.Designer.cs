
partial class AlarmControl
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
        lstActiveAlarms = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        columnHeader5 = new ColumnHeader();
        panel1 = new Panel();
        label1 = new Label();
        panel2 = new Panel();
        btnRefresh = new Button();
        btnReset = new Button();
        protocolSelector = new ProtocolSelector();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // lstActiveAlarms
        // 
        lstActiveAlarms.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
        lstActiveAlarms.Dock = DockStyle.Top;
        lstActiveAlarms.Location = new Point(0, 87);
        lstActiveAlarms.Margin = new Padding(4, 3, 4, 3);
        lstActiveAlarms.Name = "lstActiveAlarms";
        lstActiveAlarms.Size = new Size(819, 202);
        lstActiveAlarms.TabIndex = 0;
        lstActiveAlarms.UseCompatibleStateImageBehavior = false;
        lstActiveAlarms.View = View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Occuring time";
        columnHeader1.Width = 120;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Code";
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Data";
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "Type";
        // 
        // columnHeader5
        // 
        columnHeader5.Text = "Text";
        columnHeader5.Width = 500;
        // 
        // panel1
        // 
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 35);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(819, 52);
        panel1.TabIndex = 1;
        // 
        // label1
        // 
        label1.Dock = DockStyle.Fill;
        label1.Location = new Point(0, 0);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(819, 52);
        label1.TabIndex = 0;
        label1.Text = "Active alarms";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.Controls.Add(btnRefresh);
        panel2.Controls.Add(btnReset);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 289);
        panel2.Margin = new Padding(4, 3, 4, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(819, 60);
        panel2.TabIndex = 2;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(210, 7);
        btnRefresh.Margin = new Padding(4, 3, 4, 3);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(178, 27);
        btnRefresh.TabIndex = 6;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(4, 7);
        btnReset.Margin = new Padding(4, 3, 4, 3);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(178, 27);
        btnReset.TabIndex = 0;
        btnReset.Text = "Reset alarms";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Margin = new Padding(4, 3, 4, 3);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(819, 35);
        protocolSelector.TabIndex = 3;
        // 
        // AlarmControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(panel2);
        Controls.Add(lstActiveAlarms);
        Controls.Add(panel1);
        Controls.Add(protocolSelector);
        Margin = new Padding(4, 3, 4, 3);
        Name = "AlarmControl";
        Size = new Size(819, 674);
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.ListView lstActiveAlarms;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnRefresh; private ProtocolSelector protocolSelector;
}
