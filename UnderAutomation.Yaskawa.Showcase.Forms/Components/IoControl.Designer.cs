
partial class IoControl
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
        grid = new PropertyGrid();
        cbType = new ComboBox();
        btnRead = new Button();
        btnWrite = new Button();
        label1 = new Label();
        label2 = new Label();
        nudGroup = new NumericUpDown();
        label4 = new Label();
        nudCount = new NumericUpDown();
        gridName = new PropertyGrid();
        label3 = new Label();
        protocolSelector = new ProtocolSelector();
        ((System.ComponentModel.ISupportInitialize)nudGroup).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudCount).BeginInit();
        SuspendLayout();
        // 
        // grid
        // 
        grid.HelpVisible = false;
        grid.Location = new Point(286, 231);
        grid.Name = "grid";
        grid.PropertySort = PropertySort.NoSort;
        grid.Size = new Size(169, 249);
        grid.TabIndex = 5;
        grid.ToolbarVisible = false;
        // 
        // cbType
        // 
        cbType.DropDownStyle = ComboBoxStyle.DropDownList;
        cbType.FormattingEnabled = true;
        cbType.Location = new Point(240, 48);
        cbType.Name = "cbType";
        cbType.Size = new Size(121, 23);
        cbType.TabIndex = 6;
        cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
        // 
        // btnRead
        // 
        btnRead.Location = new Point(211, 176);
        btnRead.Name = "btnRead";
        btnRead.Size = new Size(169, 33);
        btnRead.TabIndex = 7;
        btnRead.Text = "Read";
        btnRead.UseVisualStyleBackColor = true;
        btnRead.Click += btnRead_Click;
        // 
        // btnWrite
        // 
        btnWrite.Location = new Point(286, 486);
        btnWrite.Name = "btnWrite";
        btnWrite.Size = new Size(169, 33);
        btnWrite.TabIndex = 7;
        btnWrite.Text = "Write";
        btnWrite.UseVisualStyleBackColor = true;
        btnWrite.Click += btnWrite_Click;
        // 
        // label1
        // 
        label1.Location = new Point(156, 47);
        label1.Name = "label1";
        label1.Size = new Size(78, 23);
        label1.TabIndex = 8;
        label1.Text = "Type:";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        label2.Location = new Point(155, 75);
        label2.Name = "label2";
        label2.Size = new Size(78, 23);
        label2.TabIndex = 8;
        label2.Text = "Group:";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudGroup
        // 
        nudGroup.Location = new Point(239, 77);
        nudGroup.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
        nudGroup.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudGroup.Name = "nudGroup";
        nudGroup.Size = new Size(120, 23);
        nudGroup.TabIndex = 9;
        nudGroup.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label4
        // 
        label4.Location = new Point(154, 130);
        label4.Name = "label4";
        label4.Size = new Size(78, 23);
        label4.TabIndex = 8;
        label4.Text = "Count:";
        label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // nudCount
        // 
        nudCount.Increment = new decimal(new int[] { 2, 0, 0, 0 });
        nudCount.Location = new Point(239, 132);
        nudCount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
        nudCount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
        nudCount.Name = "nudCount";
        nudCount.Size = new Size(120, 23);
        nudCount.TabIndex = 9;
        nudCount.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // gridName
        // 
        gridName.HelpVisible = false;
        gridName.Location = new Point(111, 231);
        gridName.Name = "gridName";
        gridName.PropertySort = PropertySort.NoSort;
        gridName.Size = new Size(169, 249);
        gridName.TabIndex = 5;
        gridName.ToolbarVisible = false;
        // 
        // label3
        // 
        label3.Location = new Point(240, 522);
        label3.Name = "label3";
        label3.Size = new Size(244, 23);
        label3.TabIndex = 10;
        label3.Text = "Only network input can be written";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(617, 30);
        protocolSelector.TabIndex = 28;
        // 
        // IoControl
        // 
        Controls.Add(protocolSelector);
        Controls.Add(label3);
        Controls.Add(nudCount);
        Controls.Add(label4);
        Controls.Add(nudGroup);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnWrite);
        Controls.Add(btnRead);
        Controls.Add(cbType);
        Controls.Add(gridName);
        Controls.Add(grid);
        Name = "IoControl";
        Size = new Size(617, 611);
        ((System.ComponentModel.ISupportInitialize)nudGroup).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudCount).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PropertyGrid grid;
    private ComboBox cbType;
    private Button btnRead;
    private Button btnWrite;
    private Label label1;
    private Label label2;
    private NumericUpDown nudGroup;
    private Label label4;
    private NumericUpDown nudCount;
    private PropertyGrid gridName;
    private Label label3;
    private ProtocolSelector protocolSelector;
}
