partial class KinematicsControl
{
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
        nudControlGroup = new NumericUpDown();
        lblControlGroup = new Label();
        lblStatus = new Label();
        gridInput = new PropertyGrid();
        gridOutput = new PropertyGrid();
        lblInput = new Label();
        lblOutput = new Label();
        btnJointToCart = new Button();
        btnCartToJoint = new Button();
        btnCoordFrame = new Button();
        btnRoundTrip = new Button();
        btnTwoStep = new Button();
        lblDivider = new Label();
        btnUseOutput = new Button();
        ((System.ComponentModel.ISupportInitialize)nudControlGroup).BeginInit();
        SuspendLayout();
        // 
        // nudControlGroup
        // 
        nudControlGroup.Location = new Point(142, 7);
        nudControlGroup.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
        nudControlGroup.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudControlGroup.Name = "nudControlGroup";
        nudControlGroup.Size = new Size(55, 23);
        nudControlGroup.TabIndex = 0;
        nudControlGroup.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblControlGroup
        // 
        lblControlGroup.AutoSize = true;
        lblControlGroup.Location = new Point(13, 9);
        lblControlGroup.Name = "lblControlGroup";
        lblControlGroup.Size = new Size(123, 15);
        lblControlGroup.TabIndex = 1;
        lblControlGroup.Text = "Control Group (1-30) :";
        // 
        // lblStatus
        // 
        lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblStatus.AutoEllipsis = true;
        lblStatus.Location = new Point(13, 622);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(810, 15);
        lblStatus.TabIndex = 2;
        lblStatus.Text = "Ready";
        // 
        // gridInput
        // 
        gridInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridInput.Location = new Point(13, 50);
        gridInput.Name = "gridInput";
        gridInput.PropertySort = PropertySort.Categorized;
        gridInput.Size = new Size(295, 565);
        gridInput.TabIndex = 4;
        gridInput.ToolbarVisible = false;
        // 
        // gridOutput
        // 
        gridOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        gridOutput.Location = new Point(497, 50);
        gridOutput.Name = "gridOutput";
        gridOutput.PropertySort = PropertySort.Categorized;
        gridOutput.Size = new Size(326, 565);
        gridOutput.TabIndex = 6;
        gridOutput.ToolbarVisible = false;
        // 
        // lblInput
        // 
        lblInput.AutoSize = true;
        lblInput.Location = new Point(13, 33);
        lblInput.Name = "lblInput";
        lblInput.Size = new Size(87, 15);
        lblInput.TabIndex = 3;
        lblInput.Text = "Input position :";
        // 
        // lblOutput
        // 
        lblOutput.AutoSize = true;
        lblOutput.Location = new Point(497, 33);
        lblOutput.Name = "lblOutput";
        lblOutput.Size = new Size(51, 15);
        lblOutput.TabIndex = 5;
        lblOutput.Text = "Output :";
        // 
        // btnJointToCart
        // 
        btnJointToCart.Location = new Point(322, 80);
        btnJointToCart.Name = "btnJointToCart";
        btnJointToCart.Size = new Size(160, 36);
        btnJointToCart.TabIndex = 10;
        btnJointToCart.Text = "Joint → Cartesian (FK)";
        btnJointToCart.UseVisualStyleBackColor = true;
        btnJointToCart.Click += btnJointToCart_Click;
        // 
        // btnCartToJoint
        // 
        btnCartToJoint.Location = new Point(322, 122);
        btnCartToJoint.Name = "btnCartToJoint";
        btnCartToJoint.Size = new Size(160, 36);
        btnCartToJoint.TabIndex = 11;
        btnCartToJoint.Text = "Cartesian → Joint (IK)";
        btnCartToJoint.UseVisualStyleBackColor = true;
        btnCartToJoint.Click += btnCartToJoint_Click;
        // 
        // btnCoordFrame
        // 
        btnCoordFrame.Location = new Point(322, 164);
        btnCoordFrame.Name = "btnCoordFrame";
        btnCoordFrame.Size = new Size(160, 36);
        btnCoordFrame.TabIndex = 12;
        btnCoordFrame.Text = "Coordinate Frame";
        btnCoordFrame.UseVisualStyleBackColor = true;
        btnCoordFrame.Click += btnCoordFrame_Click;
        // 
        // btnRoundTrip
        // 
        btnRoundTrip.Location = new Point(322, 206);
        btnRoundTrip.Name = "btnRoundTrip";
        btnRoundTrip.Size = new Size(160, 36);
        btnRoundTrip.TabIndex = 13;
        btnRoundTrip.Text = "Round Trip (IK → FK)";
        btnRoundTrip.UseVisualStyleBackColor = true;
        btnRoundTrip.Click += btnRoundTrip_Click;
        // 
        // btnTwoStep
        // 
        btnTwoStep.Location = new Point(322, 248);
        btnTwoStep.Name = "btnTwoStep";
        btnTwoStep.Size = new Size(160, 36);
        btnTwoStep.TabIndex = 14;
        btnTwoStep.Text = "Two-Step Frame";
        btnTwoStep.UseVisualStyleBackColor = true;
        btnTwoStep.Click += btnTwoStep_Click;
        // 
        // lblDivider
        // 
        lblDivider.BorderStyle = BorderStyle.Fixed3D;
        lblDivider.Location = new Point(322, 296);
        lblDivider.Name = "lblDivider";
        lblDivider.Size = new Size(160, 2);
        lblDivider.TabIndex = 15;
        // 
        // btnUseOutput
        // 
        btnUseOutput.Location = new Point(322, 306);
        btnUseOutput.Name = "btnUseOutput";
        btnUseOutput.Size = new Size(160, 36);
        btnUseOutput.TabIndex = 16;
        btnUseOutput.Text = "◄ Use Output as Input";
        btnUseOutput.UseVisualStyleBackColor = true;
        btnUseOutput.Click += btnUseOutput_Click;
        // 
        // KinematicsControl
        // 
        Controls.Add(nudControlGroup);
        Controls.Add(lblControlGroup);
        Controls.Add(lblStatus);
        Controls.Add(lblInput);
        Controls.Add(gridInput);
        Controls.Add(btnJointToCart);
        Controls.Add(btnCartToJoint);
        Controls.Add(btnCoordFrame);
        Controls.Add(btnRoundTrip);
        Controls.Add(btnTwoStep);
        Controls.Add(lblDivider);
        Controls.Add(btnUseOutput);
        Controls.Add(lblOutput);
        Controls.Add(gridOutput);
        Name = "KinematicsControl";
        Size = new Size(840, 645);
        ((System.ComponentModel.ISupportInitialize)nudControlGroup).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.NumericUpDown nudControlGroup;
    private System.Windows.Forms.Label lblControlGroup;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.PropertyGrid gridInput;
    private System.Windows.Forms.PropertyGrid gridOutput;
    private System.Windows.Forms.Label lblInput;
    private System.Windows.Forms.Label lblOutput;
    private System.Windows.Forms.Button btnJointToCart;
    private System.Windows.Forms.Button btnCartToJoint;
    private System.Windows.Forms.Button btnCoordFrame;
    private System.Windows.Forms.Button btnRoundTrip;
    private System.Windows.Forms.Button btnTwoStep;
    private System.Windows.Forms.Label lblDivider;
    private System.Windows.Forms.Button btnUseOutput;
}
