
partial class PendantControl
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
        txtMessage = new TextBox();
        btnPopup = new Button();
        btnLock = new Button();
        btnUnlock = new Button();
        protocolSelector = new ProtocolSelector();
        SuspendLayout();
        // 
        // txtMessage
        // 
        txtMessage.Location = new Point(16, 54);
        txtMessage.Multiline = true;
        txtMessage.Name = "txtMessage";
        txtMessage.Size = new Size(350, 150);
        txtMessage.TabIndex = 12;
        txtMessage.Text = "This is a message to display on pendant !";
        // 
        // btnPopup
        // 
        btnPopup.Location = new Point(16, 219);
        btnPopup.Name = "btnPopup";
        btnPopup.Size = new Size(350, 35);
        btnPopup.TabIndex = 11;
        btnPopup.Text = "Display message";
        btnPopup.UseVisualStyleBackColor = true;
        btnPopup.Click += btnPopup_Click;
        // 
        // btnLock
        // 
        btnLock.Location = new Point(400, 82);
        btnLock.Name = "btnLock";
        btnLock.Size = new Size(130, 35);
        btnLock.TabIndex = 11;
        btnLock.Text = "Lock pendant";
        btnLock.UseVisualStyleBackColor = true;
        btnLock.Click += btnLock_Click;
        // 
        // btnUnlock
        // 
        btnUnlock.Location = new Point(400, 133);
        btnUnlock.Name = "btnUnlock";
        btnUnlock.Size = new Size(130, 35);
        btnUnlock.TabIndex = 11;
        btnUnlock.Text = "Unlock pendant";
        btnUnlock.UseVisualStyleBackColor = true;
        btnUnlock.Click += btnUnlock_Click;
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(593, 30);
        protocolSelector.TabIndex = 12;
        // 
        // PendantControl
        // 
        Controls.Add(protocolSelector);
        Controls.Add(txtMessage);
        Controls.Add(btnPopup);
        Controls.Add(btnUnlock);
        Controls.Add(btnLock);
        Name = "PendantControl";
        Size = new Size(593, 418);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.Button btnPopup;
    private System.Windows.Forms.Button btnLock;
    private System.Windows.Forms.Button btnUnlock;
    private ProtocolSelector protocolSelector;
}
