
partial class VariableControl
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
        nudIndex = new NumericUpDown();
        label1 = new Label();
        nudCount = new NumericUpDown();
        label2 = new Label();
        btnReadByte = new Button();
        btnWriteByte = new Button();
        btnReadRegister = new Button();
        btnWriteRegister = new Button();
        btnReadInteger = new Button();
        btnWriteInteger = new Button();
        btnReadDouble = new Button();
        btnWriteDouble = new Button();
        btnReadReal = new Button();
        btnWriteReal = new Button();
        btnRead32Char = new Button();
        btnWrite32Char = new Button();
        btnReadPositionVariable = new Button();
        btnWritePositionVariable = new Button();
        btnReadBasePosition = new Button();
        btnWriteBasePosition = new Button();
        btnReadExternalPosition = new Button();
        btnWriteExternalPosition = new Button();
        protocolSelector = new ProtocolSelector();
        ((System.ComponentModel.ISupportInitialize)nudIndex).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudCount).BeginInit();
        SuspendLayout();
        // 
        // grid
        // 
        grid.HelpVisible = false;
        grid.Location = new Point(205, 109);
        grid.Name = "grid";
        grid.PropertySort = PropertySort.NoSort;
        grid.Size = new Size(785, 470);
        grid.TabIndex = 0;
        grid.ToolbarVisible = false;
        // 
        // nudIndex
        // 
        nudIndex.Location = new Point(64, 34);
        nudIndex.Name = "nudIndex";
        nudIndex.Size = new Size(120, 23);
        nudIndex.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 36);
        label1.Name = "label1";
        label1.Size = new Size(41, 15);
        label1.TabIndex = 2;
        label1.Text = "Index :";
        // 
        // nudCount
        // 
        nudCount.Location = new Point(64, 63);
        nudCount.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
        nudCount.Name = "nudCount";
        nudCount.Size = new Size(120, 23);
        nudCount.TabIndex = 1;
        nudCount.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(17, 65);
        label2.Name = "label2";
        label2.Size = new Size(46, 15);
        label2.TabIndex = 2;
        label2.Text = "Count :";
        // 
        // btnReadByte
        // 
        btnReadByte.Location = new Point(205, 34);
        btnReadByte.Name = "btnReadByte";
        btnReadByte.Size = new Size(75, 23);
        btnReadByte.TabIndex = 3;
        btnReadByte.Text = "Read Byte";
        btnReadByte.UseVisualStyleBackColor = true;
        btnReadByte.Click += btnReadByte_Click;
        // 
        // btnWriteByte
        // 
        btnWriteByte.Location = new Point(205, 63);
        btnWriteByte.Name = "btnWriteByte";
        btnWriteByte.Size = new Size(75, 23);
        btnWriteByte.TabIndex = 3;
        btnWriteByte.Text = "Write Byte";
        btnWriteByte.UseVisualStyleBackColor = true;
        btnWriteByte.Click += btnWriteByte_Click;
        // 
        // btnReadRegister
        // 
        btnReadRegister.Location = new Point(283, 34);
        btnReadRegister.Name = "btnReadRegister";
        btnReadRegister.Size = new Size(75, 23);
        btnReadRegister.TabIndex = 4;
        btnReadRegister.Text = "Read Reg";
        btnReadRegister.UseVisualStyleBackColor = true;
        btnReadRegister.Click += btnReadRegister_Click;
        // 
        // btnWriteRegister
        // 
        btnWriteRegister.Location = new Point(283, 63);
        btnWriteRegister.Name = "btnWriteRegister";
        btnWriteRegister.Size = new Size(75, 23);
        btnWriteRegister.TabIndex = 5;
        btnWriteRegister.Text = "Write Reg";
        btnWriteRegister.UseVisualStyleBackColor = true;
        btnWriteRegister.Click += btnWriteRegister_Click;
        // 
        // btnReadInteger
        // 
        btnReadInteger.Location = new Point(361, 34);
        btnReadInteger.Name = "btnReadInteger";
        btnReadInteger.Size = new Size(75, 23);
        btnReadInteger.TabIndex = 6;
        btnReadInteger.Text = "Read Int";
        btnReadInteger.UseVisualStyleBackColor = true;
        btnReadInteger.Click += btnReadInteger_Click;
        // 
        // btnWriteInteger
        // 
        btnWriteInteger.Location = new Point(361, 63);
        btnWriteInteger.Name = "btnWriteInteger";
        btnWriteInteger.Size = new Size(75, 23);
        btnWriteInteger.TabIndex = 7;
        btnWriteInteger.Text = "Write Int";
        btnWriteInteger.UseVisualStyleBackColor = true;
        btnWriteInteger.Click += btnWriteInteger_Click;
        // 
        // btnReadDouble
        // 
        btnReadDouble.Location = new Point(439, 34);
        btnReadDouble.Name = "btnReadDouble";
        btnReadDouble.Size = new Size(95, 23);
        btnReadDouble.TabIndex = 8;
        btnReadDouble.Text = "Read Dbl Int";
        btnReadDouble.UseVisualStyleBackColor = true;
        btnReadDouble.Click += btnReadDouble_Click;
        // 
        // btnWriteDouble
        // 
        btnWriteDouble.Location = new Point(439, 63);
        btnWriteDouble.Name = "btnWriteDouble";
        btnWriteDouble.Size = new Size(95, 23);
        btnWriteDouble.TabIndex = 9;
        btnWriteDouble.Text = "Write Dbl Int";
        btnWriteDouble.UseVisualStyleBackColor = true;
        btnWriteDouble.Click += btnWriteDouble_Click;
        // 
        // btnReadReal
        // 
        btnReadReal.Location = new Point(535, 34);
        btnReadReal.Name = "btnReadReal";
        btnReadReal.Size = new Size(75, 23);
        btnReadReal.TabIndex = 10;
        btnReadReal.Text = "Read Real";
        btnReadReal.UseVisualStyleBackColor = true;
        btnReadReal.Click += btnReadReal_Click;
        // 
        // btnWriteReal
        // 
        btnWriteReal.Location = new Point(535, 63);
        btnWriteReal.Name = "btnWriteReal";
        btnWriteReal.Size = new Size(75, 23);
        btnWriteReal.TabIndex = 11;
        btnWriteReal.Text = "Write Real";
        btnWriteReal.UseVisualStyleBackColor = true;
        btnWriteReal.Click += btnWriteReal_Click;
        // 
        // btnRead32Char
        // 
        btnRead32Char.Location = new Point(613, 34);
        btnRead32Char.Name = "btnRead32Char";
        btnRead32Char.Size = new Size(83, 23);
        btnRead32Char.TabIndex = 14;
        btnRead32Char.Text = "Read String";
        btnRead32Char.UseVisualStyleBackColor = true;
        btnRead32Char.Click += btnRead32Char_Click;
        // 
        // btnWrite32Char
        // 
        btnWrite32Char.Location = new Point(613, 63);
        btnWrite32Char.Name = "btnWrite32Char";
        btnWrite32Char.Size = new Size(83, 23);
        btnWrite32Char.TabIndex = 15;
        btnWrite32Char.Text = "Write String";
        btnWrite32Char.UseVisualStyleBackColor = true;
        btnWrite32Char.Click += btnWrite32Char_Click;
        // 
        // btnReadPositionVariable
        // 
        btnReadPositionVariable.Location = new Point(699, 34);
        btnReadPositionVariable.Name = "btnReadPositionVariable";
        btnReadPositionVariable.Size = new Size(75, 23);
        btnReadPositionVariable.TabIndex = 16;
        btnReadPositionVariable.Text = "Read Pos";
        btnReadPositionVariable.UseVisualStyleBackColor = true;
        btnReadPositionVariable.Click += btnReadPositionVariable_Click;
        // 
        // btnWritePositionVariable
        // 
        btnWritePositionVariable.Location = new Point(699, 63);
        btnWritePositionVariable.Name = "btnWritePositionVariable";
        btnWritePositionVariable.Size = new Size(75, 23);
        btnWritePositionVariable.TabIndex = 17;
        btnWritePositionVariable.Text = "Write Pos";
        btnWritePositionVariable.UseVisualStyleBackColor = true;
        btnWritePositionVariable.Click += btnWritePositionVariable_Click;
        // 
        // btnReadBasePosition
        // 
        btnReadBasePosition.Location = new Point(777, 34);
        btnReadBasePosition.Name = "btnReadBasePosition";
        btnReadBasePosition.Size = new Size(95, 23);
        btnReadBasePosition.TabIndex = 18;
        btnReadBasePosition.Text = "Read Base Pos";
        btnReadBasePosition.UseVisualStyleBackColor = true;
        btnReadBasePosition.Click += btnReadBasePosition_Click;
        // 
        // btnWriteBasePosition
        // 
        btnWriteBasePosition.Location = new Point(777, 63);
        btnWriteBasePosition.Name = "btnWriteBasePosition";
        btnWriteBasePosition.Size = new Size(95, 23);
        btnWriteBasePosition.TabIndex = 19;
        btnWriteBasePosition.Text = "Write Base Pos";
        btnWriteBasePosition.UseVisualStyleBackColor = true;
        btnWriteBasePosition.Click += btnWriteBasePosition_Click;
        // 
        // btnReadExternalPosition
        // 
        btnReadExternalPosition.Location = new Point(875, 34);
        btnReadExternalPosition.Name = "btnReadExternalPosition";
        btnReadExternalPosition.Size = new Size(95, 23);
        btnReadExternalPosition.TabIndex = 20;
        btnReadExternalPosition.Text = "Read Ext Axis";
        btnReadExternalPosition.UseVisualStyleBackColor = true;
        btnReadExternalPosition.Click += btnReadExternalPosition_Click;
        // 
        // btnWriteExternalPosition
        // 
        btnWriteExternalPosition.Location = new Point(875, 63);
        btnWriteExternalPosition.Name = "btnWriteExternalPosition";
        btnWriteExternalPosition.Size = new Size(95, 23);
        btnWriteExternalPosition.TabIndex = 21;
        btnWriteExternalPosition.Text = "Write Ext Axis";
        btnWriteExternalPosition.UseVisualStyleBackColor = true;
        btnWriteExternalPosition.Click += btnWriteExternalPosition_Click;
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(1000, 30);
        protocolSelector.TabIndex = 28;
        // 
        // VariableControl
        // 
        Controls.Add(protocolSelector);
        Controls.Add(btnWriteExternalPosition);
        Controls.Add(btnReadExternalPosition);
        Controls.Add(btnWriteBasePosition);
        Controls.Add(btnReadBasePosition);
        Controls.Add(btnWritePositionVariable);
        Controls.Add(btnReadPositionVariable);
        Controls.Add(btnWrite32Char);
        Controls.Add(btnRead32Char);
        Controls.Add(btnWriteReal);
        Controls.Add(btnReadReal);
        Controls.Add(btnWriteDouble);
        Controls.Add(btnReadDouble);
        Controls.Add(btnWriteInteger);
        Controls.Add(btnReadInteger);
        Controls.Add(btnWriteRegister);
        Controls.Add(btnReadRegister);
        Controls.Add(btnWriteByte);
        Controls.Add(btnReadByte);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(nudCount);
        Controls.Add(nudIndex);
        Controls.Add(grid);
        Name = "VariableControl";
        Size = new Size(1000, 588);
        ((System.ComponentModel.ISupportInitialize)nudIndex).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudCount).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PropertyGrid grid;
    private NumericUpDown nudIndex;
    private Label label1;
    private NumericUpDown nudCount;
    private Label label2;
    private Button btnReadByte;
    private Button btnWriteByte;
    private Button btnReadRegister;
    private Button btnWriteRegister;
    private Button btnReadInteger;
    private Button btnWriteInteger;
    private Button btnReadDouble;
    private Button btnWriteDouble;
    private Button btnReadReal;
    private Button btnWriteReal;
    private Button btnRead32Char;
    private Button btnWrite32Char;
    private Button btnReadPositionVariable;
    private Button btnWritePositionVariable;
    private Button btnReadBasePosition;
    private Button btnWriteBasePosition;
    private Button btnReadExternalPosition;
    private Button btnWriteExternalPosition;
    private ProtocolSelector protocolSelector;
}
