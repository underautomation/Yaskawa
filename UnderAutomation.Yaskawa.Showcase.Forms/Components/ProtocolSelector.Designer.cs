
partial class ProtocolSelector
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
        components = new System.ComponentModel.Container();
        cbProtocol = new ComboBox();
        label1 = new Label();
        tmrConnected = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // cbProtocol
        // 
        cbProtocol.DropDownStyle = ComboBoxStyle.DropDownList;
        cbProtocol.FormattingEnabled = true;
        cbProtocol.Location = new Point(94, 2);
        cbProtocol.Name = "cbProtocol";
        cbProtocol.Size = new Size(247, 23);
        cbProtocol.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(88, 24);
        label1.TabIndex = 1;
        label1.Text = "Protocol:";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tmrConnected
        // 
        tmrConnected.Enabled = true;
        tmrConnected.Interval = 1000;
        tmrConnected.Tick += tmrConnected_Tick;
        // 
        // ProtocolSelector
        // 
        Controls.Add(label1);
        Controls.Add(cbProtocol);
        Name = "ProtocolSelector";
        Size = new Size(344, 28);
        ResumeLayout(false);
    }

    #endregion
    private ComboBox cbProtocol;
    private Label label1;
    private System.Windows.Forms.Timer tmrConnected;
}
