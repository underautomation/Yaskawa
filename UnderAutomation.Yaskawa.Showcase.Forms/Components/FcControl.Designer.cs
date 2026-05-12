partial class FcControl
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
        btnOpenSession = new Button();
        btnCloseSession = new Button();
        lblStatus = new Label();
        txtPath = new TextBox();
        cbPattern = new ComboBox();
        lstFiles = new ListView();
        chName = new ColumnHeader();
        btnList = new Button();
        btnGetDir = new Button();
        btnChangeDir = new Button();
        btnChangeDrive = new Button();
        btnRead = new Button();
        btnWrite = new Button();
        btnDelete = new Button();
        btnRename = new Button();
        btnMakeDir = new Button();
        btnGetFileSize = new Button();
        btnGetDiskSize = new Button();
        lblProgress = new Label();
        dlgOpen = new OpenFileDialog();
        dlgSave = new SaveFileDialog();
        lblPath = new Label();
        lblPattern = new Label();
        grpSession = new GroupBox();
        grpActions = new GroupBox();
        grpFiles = new GroupBox();
        grpSession.SuspendLayout();
        grpActions.SuspendLayout();
        grpFiles.SuspendLayout();
        SuspendLayout();
        // 
        // protocolSelector
        // 
        protocolSelector.Dock = DockStyle.Top;
        protocolSelector.Location = new Point(0, 0);
        protocolSelector.Name = "protocolSelector";
        protocolSelector.Size = new Size(900, 45);
        protocolSelector.TabIndex = 10;
        // 
        // btnOpenSession
        // 
        btnOpenSession.Location = new Point(310, 21);
        btnOpenSession.Name = "btnOpenSession";
        btnOpenSession.Size = new Size(110, 25);
        btnOpenSession.TabIndex = 0;
        btnOpenSession.Text = "Open session";
        btnOpenSession.UseVisualStyleBackColor = true;
        btnOpenSession.Click += btnOpenSession_Click;
        // 
        // btnCloseSession
        // 
        btnCloseSession.Location = new Point(425, 21);
        btnCloseSession.Name = "btnCloseSession";
        btnCloseSession.Size = new Size(110, 25);
        btnCloseSession.TabIndex = 1;
        btnCloseSession.Text = "Close session";
        btnCloseSession.UseVisualStyleBackColor = true;
        btnCloseSession.Click += btnCloseSession_Click;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(545, 25);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(71, 15);
        lblStatus.TabIndex = 2;
        lblStatus.Text = "No protocol";
        // 
        // txtPath
        // 
        txtPath.Location = new Point(95, 22);
        txtPath.Name = "txtPath";
        txtPath.Size = new Size(300, 23);
        txtPath.TabIndex = 1;
        // 
        // cbPattern
        // 
        cbPattern.Location = new Point(95, 55);
        cbPattern.Name = "cbPattern";
        cbPattern.Size = new Size(180, 23);
        cbPattern.TabIndex = 8;
        // 
        // lstFiles
        // 
        lstFiles.Columns.AddRange(new ColumnHeader[] { chName });
        lstFiles.Dock = DockStyle.Fill;
        lstFiles.FullRowSelect = true;
        lstFiles.GridLines = true;
        lstFiles.Location = new Point(3, 19);
        lstFiles.Name = "lstFiles";
        lstFiles.Size = new Size(894, 358);
        lstFiles.TabIndex = 0;
        lstFiles.UseCompatibleStateImageBehavior = false;
        lstFiles.View = View.Details;
        // 
        // chName
        // 
        chName.Text = "Name";
        chName.Width = 850;
        // 
        // btnList
        // 
        btnList.Location = new Point(281, 54);
        btnList.Name = "btnList";
        btnList.Size = new Size(114, 25);
        btnList.TabIndex = 9;
        btnList.Text = "List files";
        btnList.UseVisualStyleBackColor = true;
        btnList.Click += btnList_Click;
        // 
        // btnGetDir
        // 
        btnGetDir.Location = new Point(704, 21);
        btnGetDir.Name = "btnGetDir";
        btnGetDir.Size = new Size(85, 25);
        btnGetDir.TabIndex = 5;
        btnGetDir.Text = "PWD";
        btnGetDir.UseVisualStyleBackColor = true;
        btnGetDir.Click += btnGetDir_Click;
        // 
        // btnChangeDir
        // 
        btnChangeDir.Location = new Point(401, 21);
        btnChangeDir.Name = "btnChangeDir";
        btnChangeDir.Size = new Size(95, 25);
        btnChangeDir.TabIndex = 2;
        btnChangeDir.Text = "CD";
        btnChangeDir.UseVisualStyleBackColor = true;
        btnChangeDir.Click += btnChangeDir_Click;
        // 
        // btnChangeDrive
        // 
        btnChangeDrive.Location = new Point(603, 21);
        btnChangeDrive.Name = "btnChangeDrive";
        btnChangeDrive.Size = new Size(95, 25);
        btnChangeDrive.TabIndex = 4;
        btnChangeDrive.Text = "Drive";
        btnChangeDrive.UseVisualStyleBackColor = true;
        btnChangeDrive.Click += btnChangeDrive_Click;
        // 
        // btnRead
        // 
        btnRead.Location = new Point(401, 54);
        btnRead.Name = "btnRead";
        btnRead.Size = new Size(95, 25);
        btnRead.TabIndex = 10;
        btnRead.Text = "Read";
        btnRead.UseVisualStyleBackColor = true;
        btnRead.Click += btnRead_Click;
        // 
        // btnWrite
        // 
        btnWrite.Location = new Point(502, 54);
        btnWrite.Name = "btnWrite";
        btnWrite.Size = new Size(95, 25);
        btnWrite.TabIndex = 11;
        btnWrite.Text = "Write...";
        btnWrite.UseVisualStyleBackColor = true;
        btnWrite.Click += btnWrite_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(603, 54);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(95, 25);
        btnDelete.TabIndex = 12;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnRename
        // 
        btnRename.Location = new Point(704, 54);
        btnRename.Name = "btnRename";
        btnRename.Size = new Size(85, 25);
        btnRename.TabIndex = 13;
        btnRename.Text = "Rename";
        btnRename.UseVisualStyleBackColor = true;
        btnRename.Click += btnRename_Click;
        // 
        // btnMakeDir
        // 
        btnMakeDir.Location = new Point(502, 21);
        btnMakeDir.Name = "btnMakeDir";
        btnMakeDir.Size = new Size(95, 25);
        btnMakeDir.TabIndex = 3;
        btnMakeDir.Text = "MD";
        btnMakeDir.UseVisualStyleBackColor = true;
        btnMakeDir.Click += btnMakeDir_Click;
        // 
        // btnGetFileSize
        // 
        btnGetFileSize.Location = new Point(795, 54);
        btnGetFileSize.Name = "btnGetFileSize";
        btnGetFileSize.Size = new Size(95, 25);
        btnGetFileSize.TabIndex = 14;
        btnGetFileSize.Text = "File size";
        btnGetFileSize.UseVisualStyleBackColor = true;
        btnGetFileSize.Click += btnGetFileSize_Click;
        // 
        // btnGetDiskSize
        // 
        btnGetDiskSize.Location = new Point(795, 21);
        btnGetDiskSize.Name = "btnGetDiskSize";
        btnGetDiskSize.Size = new Size(95, 25);
        btnGetDiskSize.TabIndex = 6;
        btnGetDiskSize.Text = "Disk size";
        btnGetDiskSize.UseVisualStyleBackColor = true;
        btnGetDiskSize.Click += btnGetDiskSize_Click;
        // 
        // lblProgress
        // 
        lblProgress.AutoSize = true;
        lblProgress.Location = new Point(12, 88);
        lblProgress.Name = "lblProgress";
        lblProgress.Size = new Size(0, 15);
        lblProgress.TabIndex = 15;
        // 
        // lblPath
        // 
        lblPath.AutoSize = true;
        lblPath.Location = new Point(12, 25);
        lblPath.Name = "lblPath";
        lblPath.Size = new Size(72, 15);
        lblPath.TabIndex = 0;
        lblPath.Text = "Path / Drive:";
        // 
        // lblPattern
        // 
        lblPattern.AutoSize = true;
        lblPattern.Location = new Point(12, 58);
        lblPattern.Name = "lblPattern";
        lblPattern.Size = new Size(48, 15);
        lblPattern.TabIndex = 7;
        lblPattern.Text = "Pattern:";
        // 
        // grpSession
        // 
        grpSession.Controls.Add(btnOpenSession);
        grpSession.Controls.Add(btnCloseSession);
        grpSession.Controls.Add(lblStatus);
        grpSession.Dock = DockStyle.Top;
        grpSession.Location = new Point(0, 45);
        grpSession.Name = "grpSession";
        grpSession.Size = new Size(900, 60);
        grpSession.TabIndex = 2;
        grpSession.TabStop = false;
        grpSession.Text = "FC Session";
        // 
        // grpActions
        // 
        grpActions.Controls.Add(lblPath);
        grpActions.Controls.Add(txtPath);
        grpActions.Controls.Add(btnChangeDir);
        grpActions.Controls.Add(btnMakeDir);
        grpActions.Controls.Add(btnChangeDrive);
        grpActions.Controls.Add(btnGetDir);
        grpActions.Controls.Add(btnGetDiskSize);
        grpActions.Controls.Add(lblPattern);
        grpActions.Controls.Add(cbPattern);
        grpActions.Controls.Add(btnList);
        grpActions.Controls.Add(btnRead);
        grpActions.Controls.Add(btnWrite);
        grpActions.Controls.Add(btnDelete);
        grpActions.Controls.Add(btnRename);
        grpActions.Controls.Add(btnGetFileSize);
        grpActions.Controls.Add(lblProgress);
        grpActions.Dock = DockStyle.Top;
        grpActions.Location = new Point(0, 105);
        grpActions.Name = "grpActions";
        grpActions.Size = new Size(900, 115);
        grpActions.TabIndex = 1;
        grpActions.TabStop = false;
        grpActions.Text = "FC Actions";
        // 
        // grpFiles
        // 
        grpFiles.Controls.Add(lstFiles);
        grpFiles.Dock = DockStyle.Fill;
        grpFiles.Location = new Point(0, 220);
        grpFiles.Name = "grpFiles";
        grpFiles.Size = new Size(900, 380);
        grpFiles.TabIndex = 0;
        grpFiles.TabStop = false;
        grpFiles.Text = "Files";
        // 
        // FcControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(grpFiles);
        Controls.Add(grpActions);
        Controls.Add(grpSession);
        Controls.Add(protocolSelector);
        Name = "FcControl";
        Size = new Size(900, 600);
        grpSession.ResumeLayout(false);
        grpSession.PerformLayout();
        grpActions.ResumeLayout(false);
        grpActions.PerformLayout();
        grpFiles.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ProtocolSelector protocolSelector;
    private Button btnOpenSession;
    private Button btnCloseSession;
    private Label lblStatus;
    private TextBox txtPath;
    private ComboBox cbPattern;
    private ListView lstFiles;
    private ColumnHeader chName;
    private Button btnList;
    private Button btnGetDir;
    private Button btnChangeDir;
    private Button btnChangeDrive;
    private Button btnRead;
    private Button btnWrite;
    private Button btnDelete;
    private Button btnRename;
    private Button btnMakeDir;
    private Button btnGetFileSize;
    private Button btnGetDiskSize;
    private Label lblProgress;
    private OpenFileDialog dlgOpen;
    private SaveFileDialog dlgSave;
    private Label lblPath;
    private Label lblPattern;
    private GroupBox grpSession;
    private GroupBox grpActions;
    private GroupBox grpFiles;
}
