
    partial class FileControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileControl));
        ListViewItem listViewItem3 = new ListViewItem("<", 1);
        ListViewItem listViewItem4 = new ListViewItem("abcdefghijklmno", 0);
        lstFolderImageList = new ImageList(components);
        dlgOpen = new OpenFileDialog();
        lstFolder = new ListView();
        ToolStrip1 = new ToolStrip();
        toolStripLabel1 = new ToolStripLabel();
        cbPattern = new ToolStripComboBox();
        btnOpenPath = new ToolStripButton();
        tsFolder = new ToolStrip();
        btnRefresh = new ToolStripButton();
        btnOpen = new ToolStripButton();
        btnDownload = new ToolStripButton();
        btnDelete = new ToolStripButton();
        btnUpload = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        btnBackup = new ToolStripButton();
        btnDownloadCmos = new ToolStripButton();
        lblProgress = new Label();
        dlgSaveCMOS = new SaveFileDialog();
        protocolSelector = new ProtocolSelector();
        ToolStrip1.SuspendLayout();
        tsFolder.SuspendLayout();
        SuspendLayout();
        // 
        // lstFolderImageList
        // 
        lstFolderImageList.ColorDepth = ColorDepth.Depth8Bit;
        lstFolderImageList.ImageStream = (ImageListStreamer)resources.GetObject("lstFolderImageList.ImageStream");
        lstFolderImageList.TransparentColor = Color.Transparent;
        lstFolderImageList.Images.SetKeyName(0, "folder");
        lstFolderImageList.Images.SetKeyName(1, "file");
        lstFolderImageList.Images.SetKeyName(2, "symbolicLink");
        // 
        // dlgOpen
        // 
        dlgOpen.Filter = "All files|*.*";
        dlgOpen.Title = "Select file to upload";
        // 
        // lstFolder
        // 
        lstFolder.Activation = ItemActivation.TwoClick;
        lstFolder.Dock = DockStyle.Fill;
        lstFolder.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
        lstFolder.LabelEdit = true;
        lstFolder.LargeImageList = lstFolderImageList;
        lstFolder.Location = new Point(0, 80);
        lstFolder.Margin = new Padding(4, 3, 4, 3);
        lstFolder.Name = "lstFolder";
        lstFolder.Size = new Size(1143, 684);
        lstFolder.TabIndex = 4;
        lstFolder.UseCompatibleStateImageBehavior = false;
        lstFolder.View = View.Tile;
        lstFolder.ItemActivate += lstFolder_ItemActivate;
        // 
        // ToolStrip1
        // 
        ToolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, cbPattern, btnOpenPath });
        ToolStrip1.Location = new Point(0, 55);
        ToolStrip1.Name = "ToolStrip1";
        ToolStrip1.Size = new Size(1143, 25);
        ToolStrip1.TabIndex = 5;
        ToolStrip1.Text = "ToolStrip1";
        // 
        // toolStripLabel1
        // 
        toolStripLabel1.Name = "toolStripLabel1";
        toolStripLabel1.Size = new Size(51, 22);
        toolStripLabel1.Text = "Pattern :";
        // 
        // cbPattern
        // 
        cbPattern.Items.AddRange(new object[] { "*.JBI", "*.PRM", "*.DAT", "*.CND", "*.SYS", "*.LST", "*.CSV", "*.LOG", "*.TXT", "*.JOB" });
        cbPattern.Name = "cbPattern";
        cbPattern.Size = new Size(140, 25);
        cbPattern.Text = "*.JBI";
        cbPattern.SelectedIndexChanged += btnOpenPath_Click;
        // 
        // btnOpenPath
        // 
        btnOpenPath.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnOpenPath.Image = UnderAutomation.Yaskawa.Showcase.Forms.Properties.Resources.arrow_right_line;
        btnOpenPath.ImageTransparentColor = Color.Magenta;
        btnOpenPath.Name = "btnOpenPath";
        btnOpenPath.Size = new Size(23, 22);
        btnOpenPath.Text = "Open";
        btnOpenPath.Click += btnOpenPath_Click;
        // 
        // tsFolder
        // 
        tsFolder.Items.AddRange(new ToolStripItem[] { btnRefresh, btnOpen, btnDownload, btnDelete, btnUpload, toolStripSeparator1, btnBackup, btnDownloadCmos });
        tsFolder.Location = new Point(0, 30);
        tsFolder.Name = "tsFolder";
        tsFolder.Size = new Size(1143, 25);
        tsFolder.TabIndex = 3;
        tsFolder.Text = "ToolStrip1";
        // 
        // btnRefresh
        // 
        btnRefresh.Image = UnderAutomation.Yaskawa.Showcase.Forms.Properties.Resources.refresh_line;
        btnRefresh.ImageTransparentColor = Color.Magenta;
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(66, 22);
        btnRefresh.Text = "Refresh";
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnOpen
        // 
        btnOpen.Image = UnderAutomation.Yaskawa.Showcase.Forms.Properties.Resources.file_edit_line;
        btnOpen.ImageTransparentColor = Color.Magenta;
        btnOpen.Name = "btnOpen";
        btnOpen.Size = new Size(47, 22);
        btnOpen.Text = "Edit";
        btnOpen.Click += btnOpen_Click;
        // 
        // btnDownload
        // 
        btnDownload.Image = UnderAutomation.Yaskawa.Showcase.Forms.Properties.Resources.save_3_fill;
        btnDownload.ImageTransparentColor = Color.Magenta;
        btnDownload.Name = "btnDownload";
        btnDownload.Size = new Size(102, 22);
        btnDownload.Text = "Download File";
        btnDownload.Click += btnDownload_Click;
        // 
        // btnDelete
        // 
        btnDelete.Image = UnderAutomation.Yaskawa.Showcase.Forms.Properties.Resources.delete_bin_5_line;
        btnDelete.ImageTransparentColor = Color.Magenta;
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(60, 22);
        btnDelete.Text = "Delete";
        btnDelete.Click += btnDelete_Click;
        // 
        // btnUpload
        // 
        btnUpload.Image = UnderAutomation.Yaskawa.Showcase.Forms.Properties.Resources.upload_2_line;
        btnUpload.ImageTransparentColor = Color.Magenta;
        btnUpload.Name = "btnUpload";
        btnUpload.Size = new Size(84, 22);
        btnUpload.Text = "Upload file";
        btnUpload.Click += btnUpload_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 25);
        // 
        // btnBackup
        // 
        btnBackup.Image = UnderAutomation.Yaskawa.Showcase.Forms.Properties.Resources.tools_line;
        btnBackup.ImageTransparentColor = Color.Magenta;
        btnBackup.Name = "btnBackup";
        btnBackup.Size = new Size(125, 22);
        btnBackup.Text = "Backup CMOS.BIN";
        btnBackup.Click += btnBackup_Click;
        // 
        // btnDownloadCmos
        // 
        btnDownloadCmos.Enabled = false;
        btnDownloadCmos.Image = (Image)resources.GetObject("btnDownloadCmos.Image");
        btnDownloadCmos.ImageTransparentColor = Color.Magenta;
        btnDownloadCmos.Name = "btnDownloadCmos";
        btnDownloadCmos.Size = new Size(140, 22);
        btnDownloadCmos.Text = "Download CMOS.BIN";
        btnDownloadCmos.Click += btnDownloadCmos_Click;
        // 
        // lblProgress
        // 
        lblProgress.Anchor = AnchorStyles.Top;
        lblProgress.BackColor = SystemColors.ControlLight;
        lblProgress.BorderStyle = BorderStyle.FixedSingle;
        lblProgress.Font = new Font("Microsoft Sans Serif", 12F);
        lblProgress.Location = new Point(348, 130);
        lblProgress.Margin = new Padding(4, 0, 4, 0);
        lblProgress.Name = "lblProgress";
        lblProgress.Size = new Size(323, 167);
        lblProgress.TabIndex = 6;
        lblProgress.Text = "...";
        lblProgress.TextAlign = ContentAlignment.MiddleCenter;
        lblProgress.Visible = false;
        // 
        // dlgSaveCMOS
        // 
        dlgSaveCMOS.FileName = "CMOSBK.bin";
        dlgSaveCMOS.Filter = "All files|*.*";
        dlgSaveCMOS.Title = "Save CMOS.BIN";
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(1143, 30);
        protocolSelector.TabIndex = 27;
        // 
        // FileControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(lblProgress);
        Controls.Add(lstFolder);
        Controls.Add(ToolStrip1);
        Controls.Add(tsFolder);
        Controls.Add(protocolSelector);
        Margin = new Padding(4, 3, 4, 3);
        Name = "FileControl";
        Size = new Size(1143, 764);
        ToolStrip1.ResumeLayout(false);
        ToolStrip1.PerformLayout();
        tsFolder.ResumeLayout(false);
        tsFolder.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    internal System.Windows.Forms.OpenFileDialog dlgOpen;
    internal System.Windows.Forms.ImageList lstFolderImageList;
    internal System.Windows.Forms.ListView lstFolder;
    internal System.Windows.Forms.ToolStrip ToolStrip1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripComboBox cbPattern;
    internal System.Windows.Forms.ToolStripButton btnOpenPath;
    internal System.Windows.Forms.ToolStrip tsFolder;
    internal System.Windows.Forms.ToolStripButton btnRefresh;
    internal System.Windows.Forms.ToolStripButton btnOpen;
    internal System.Windows.Forms.ToolStripButton btnDelete;
    internal System.Windows.Forms.ToolStripButton btnBackup;
    internal System.Windows.Forms.ToolStripButton btnDownload;
    private System.Windows.Forms.Label lblProgress;
    internal ToolStripButton btnUpload;
    private ToolStripSeparator toolStripSeparator1;
    internal ToolStripButton btnDownloadCmos;
    private SaveFileDialog dlgSaveCMOS;
    private ProtocolSelector protocolSelector;
}
