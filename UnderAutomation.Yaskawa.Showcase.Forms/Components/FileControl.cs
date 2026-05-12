using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class FileControl : UserControl, IUserControl, ISelectableControl<IFileReader>
{
    YaskawaRobot _robot;

    public IFileReader SelectedProtocol { get; set; }
    public YaskawaRobot Robot { get => _robot; set => _robot = value; }

    public FileControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;

    public string Title => "Files";

    public void OnClose() { }

    public void OnOpen()
    {
        UpdateList();
    }

    private void UpdateList(string selected = null)
    {
        try
        {

            Cursor = Cursors.WaitCursor;

            lstFolder.Items.Clear();

            if (!FeatureEnabled) return;

            var files = SelectedProtocol.GetFileList(cbPattern.Text);

            ListViewItem selectedItem = null;

            foreach (var file in files)
            {
                var itm = lstFolder.Items.Add(file);
                itm.ImageKey = "file";

                if (string.Equals(selected, file))
                {
                    itm.Selected = true;
                    selectedItem = itm;
                }
            }

            selectedItem?.EnsureVisible();
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    public void PeriodicUpdate()
    {
        var isWriter = SelectedProtocol is IFileWriter;
        btnUpload.Enabled = isWriter;
        btnDelete.Enabled = isWriter;
        var isHses = SelectedProtocol == Robot.HighSpeedEServer;
        btnBackup.Enabled = isHses;
        btnDownloadCmos.Enabled = isHses && btnDownloadCmos.Enabled;
    }
    #endregion

    private void btnUpload_Click(object sender, EventArgs e)
    {
        if (dlgOpen.ShowDialog() != DialogResult.OK) return;

        var content = File.ReadAllText(dlgOpen.FileName);

        var fileName = Path.GetFileName(dlgOpen.FileName);

        var writer = SelectedProtocol as IFileWriter;
        if (writer is null) return;

        try
        {
            Cursor = Cursors.WaitCursor;

            writer.LoadFile(fileName, content);

            UpdateList(fileName);
        }
        finally
        {
            lblProgress.Visible = false;
            Cursor = Cursors.Default;
        }
    }

    private void btnDownload_Click(object sender, EventArgs e)
    {
        OpenFile(true);
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var file = GetSelectedFile();
        if (file is null) return;

        if (MessageBox.Show($"Do you really want to delete {file} ?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        var writer = SelectedProtocol as IFileWriter;
        writer?.DeleteFile(file);

        UpdateList();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
        OpenFile(false);
    }

    private string GetSelectedFile()
    {
        return lstFolder.SelectedItems.OfType<ListViewItem>().FirstOrDefault()?.Text;
    }

    private void OpenFile(bool showSaveDialog)
    {
        var file = GetSelectedFile();
        if (file is null) return;

        try
        {
            Cursor = Cursors.WaitCursor;


            var content = SelectedProtocol.GetFile(file);

            var frm = new FileControlPopup(file, content, _robot, showSaveDialog);
            frm.ShowDialog();
        }
        finally
        {
            lblProgress.Visible = false;
            Cursor = Cursors.Default;
        }
    }

    private void lstFolder_ItemActivate(object sender, EventArgs e)
    {
        OpenFile(false);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        UpdateList();
    }

    private void btnOpenPath_Click(object sender, EventArgs e)
    {
        UpdateList();
    }

    private void btnBackup_Click(object sender, EventArgs e)
    {
        Robot.HighSpeedEServer.BatchDataBackup();
        btnDownloadCmos.Enabled = true;
    }

    private void btnDownloadCmos_Click(object sender, EventArgs e)
    {
        try
        {
            Cursor = Cursors.WaitCursor;

            var content = Robot.HighSpeedEServer.GetFile("/SPDRV/CMOSBK.BIN", (progress) =>
            {
                lblProgress.Visible = true;
                lblProgress.Text = $"Downloading CMOS.BIN ...\r\nReceived bytes : {progress.DownloadedBytes}";
                Application.DoEvents();
            });

            if (dlgSaveCMOS.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dlgSaveCMOS.FileName, content.ContentRaw);
                Explorer.RevealFile(dlgSaveCMOS.FileName);
            }
        }
        catch (InvalidDataAnswerException ex) when (ex.AddedStatus == 0x0000e444)
        {
            throw new Exception("Backup of CMOS.BIN is in progress, please wait...", ex);
        }
        finally
        {
            lblProgress.Visible = false;
            Cursor = Cursors.Default;
        }
    }
}
