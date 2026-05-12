partial class DciControl
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    private void InitializeComponent()
    {
        protocolSelector = new ProtocolSelector();
        btnToggleListen = new Button();
        lblStatus = new Label();
        lstEvents = new ListView();
        chTime = new ColumnHeader();
        chType = new ColumnHeader();
        chInfo = new ColumnHeader();
        btnClearLog = new Button();
        txtJobsFolder = new TextBox();
        btnBrowseFolder = new Button();
        txtLoadVResponse = new TextBox();
        folderBrowserDialog = new FolderBrowserDialog();
        lblJobsFolder = new Label();
        lblLoadV = new Label();
        grpTop = new GroupBox();
        grpEvents = new GroupBox();
        grpTop.SuspendLayout();
        grpEvents.SuspendLayout();
        SuspendLayout();
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(800, 52);
        protocolSelector.TabIndex = 2;
        // 
        // btnToggleListen
        // 
        btnToggleListen.Location = new Point(310, 21);
        btnToggleListen.Name = "btnToggleListen";
        btnToggleListen.Size = new Size(130, 25);
        btnToggleListen.TabIndex = 2;
        btnToggleListen.Text = "Start Listening";
        btnToggleListen.UseVisualStyleBackColor = true;
        btnToggleListen.Click += btnToggleListen_Click;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(450, 25);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(71, 15);
        lblStatus.TabIndex = 3;
        lblStatus.Text = "No protocol";
        // 
        // lstEvents
        // 
        lstEvents.Columns.AddRange(new ColumnHeader[] { chTime, chType, chInfo });
        lstEvents.Dock = DockStyle.Fill;
        lstEvents.FullRowSelect = true;
        lstEvents.GridLines = true;
        lstEvents.Location = new Point(3, 19);
        lstEvents.Name = "lstEvents";
        lstEvents.Size = new Size(794, 270);
        lstEvents.TabIndex = 0;
        lstEvents.UseCompatibleStateImageBehavior = false;
        lstEvents.View = View.Details;
        // 
        // chTime
        // 
        chTime.Text = "Time";
        chTime.Width = 110;
        // 
        // chType
        // 
        chType.Text = "Type";
        chType.Width = 80;
        // 
        // chInfo
        // 
        chInfo.Text = "Info";
        chInfo.Width = 540;
        // 
        // btnClearLog
        // 
        btnClearLog.Dock = DockStyle.Bottom;
        btnClearLog.Location = new Point(3, 289);
        btnClearLog.Name = "btnClearLog";
        btnClearLog.Size = new Size(794, 26);
        btnClearLog.TabIndex = 1;
        btnClearLog.Text = "Clear log";
        btnClearLog.UseVisualStyleBackColor = true;
        btnClearLog.Click += btnClearLog_Click;
        // 
        // txtJobsFolder
        // 
        txtJobsFolder.Location = new Point(170, 57);
        txtJobsFolder.Name = "txtJobsFolder";
        txtJobsFolder.Size = new Size(380, 23);
        txtJobsFolder.TabIndex = 5;
        // 
        // btnBrowseFolder
        // 
        btnBrowseFolder.Location = new Point(556, 56);
        btnBrowseFolder.Name = "btnBrowseFolder";
        btnBrowseFolder.Size = new Size(80, 25);
        btnBrowseFolder.TabIndex = 6;
        btnBrowseFolder.Text = "Browse...";
        btnBrowseFolder.UseVisualStyleBackColor = true;
        btnBrowseFolder.Click += btnBrowseFolder_Click;
        // 
        // txtLoadVResponse
        // 
        txtLoadVResponse.Location = new Point(170, 89);
        txtLoadVResponse.Name = "txtLoadVResponse";
        txtLoadVResponse.Size = new Size(466, 23);
        txtLoadVResponse.TabIndex = 8;
        // 
        // lblJobsFolder
        // 
        lblJobsFolder.AutoSize = true;
        lblJobsFolder.Location = new Point(12, 60);
        lblJobsFolder.Name = "lblJobsFolder";
        lblJobsFolder.Size = new Size(148, 15);
        lblJobsFolder.TabIndex = 4;
        lblJobsFolder.Text = "Jobs folder (LOADJ/SAVEJ):";
        // 
        // lblLoadV
        // 
        lblLoadV.AutoSize = true;
        lblLoadV.Location = new Point(12, 92);
        lblLoadV.Name = "lblLoadV";
        lblLoadV.Size = new Size(130, 15);
        lblLoadV.TabIndex = 7;
        lblLoadV.Text = "LOADV response (CSV):";
        // 
        // grpTop
        // 
        grpTop.Controls.Add(btnToggleListen);
        grpTop.Controls.Add(lblStatus);
        grpTop.Controls.Add(lblJobsFolder);
        grpTop.Controls.Add(txtJobsFolder);
        grpTop.Controls.Add(btnBrowseFolder);
        grpTop.Controls.Add(lblLoadV);
        grpTop.Controls.Add(txtLoadVResponse);
        grpTop.Dock = DockStyle.Top;
        grpTop.Location = new Point(0, 52);
        grpTop.Name = "grpTop";
        grpTop.Size = new Size(800, 130);
        grpTop.TabIndex = 1;
        grpTop.TabStop = false;
        grpTop.Text = "DCI Configuration";
        // 
        // grpEvents
        // 
        grpEvents.Controls.Add(lstEvents);
        grpEvents.Controls.Add(btnClearLog);
        grpEvents.Dock = DockStyle.Fill;
        grpEvents.Location = new Point(0, 182);
        grpEvents.Name = "grpEvents";
        grpEvents.Size = new Size(800, 318);
        grpEvents.TabIndex = 0;
        grpEvents.TabStop = false;
        grpEvents.Text = "DCI Events";
        // 
        // DciControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(grpEvents);
        Controls.Add(grpTop);
        Controls.Add(protocolSelector);
        Name = "DciControl";
        Size = new Size(800, 500);
        grpTop.ResumeLayout(false);
        grpTop.PerformLayout();
        grpEvents.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ProtocolSelector protocolSelector;
    private Button btnToggleListen;
    private Label lblStatus;
    private ListView lstEvents;
    private ColumnHeader chTime;
    private ColumnHeader chType;
    private ColumnHeader chInfo;
    private Button btnClearLog;
    private TextBox txtJobsFolder;
    private Button btnBrowseFolder;
    private TextBox txtLoadVResponse;
    private FolderBrowserDialog folderBrowserDialog;
    private Label lblJobsFolder;
    private Label lblLoadV;
    private GroupBox grpTop;
    private GroupBox grpEvents;
}
