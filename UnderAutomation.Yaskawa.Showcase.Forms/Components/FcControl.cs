using System;
using System.IO;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HostControl;
using UnderAutomation.Yaskawa.HostControl.Internal;

public partial class FcControl : UserControl, IUserControl, ISelectableControl<HostControlBscClientBase>
{
    private HostControlBscClientBase _selected;
    private FileControlSession _session;

    public YaskawaRobot Robot { get; set; }

    public HostControlBscClientBase SelectedProtocol
    {
        get => _selected;
        set
        {
            CloseSession();
            _selected = value;
            UpdateStatus();
        }
    }

    public FcControl(YaskawaRobot Yaskawa)
    {
        Robot = Yaskawa;
        InitializeComponent();

        if (cbPattern.Items.Count == 0)
        {
            cbPattern.Items.AddRange(new object[] { "*.*", "*.JBI", "*.JBR", "*.DAT", "*.CND", "*.PRM" });
            cbPattern.SelectedIndex = 0;
        }

        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public string Title => "File Control (FC)";
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;
    public void OnOpen() { UpdateStatus(); }
    public void OnClose() { CloseSession(); }
    public void PeriodicUpdate() { UpdateStatus(); }
    #endregion

    private void btnOpenSession_Click(object sender, EventArgs e) => OpenSession();
    private void btnCloseSession_Click(object sender, EventArgs e) => CloseSession();
    private void btnList_Click(object sender, EventArgs e) => RunWithSession(() => DoList());
    private void btnGetDir_Click(object sender, EventArgs e) => RunWithSession(() => MessageBox.Show($"Current directory: {_session.GetCurrentDirectory()}"));
    private void btnChangeDir_Click(object sender, EventArgs e) => RunWithSession(() => { _session.ChangeDirectory(txtPath.Text); DoList(); });
    private void btnChangeDrive_Click(object sender, EventArgs e) => RunWithSession(() => { _session.ChangeDrive(txtPath.Text); DoList(); });
    private void btnMakeDir_Click(object sender, EventArgs e) => RunWithSession(() => { _session.MakeDirectory(txtPath.Text); DoList(); });
    private void btnGetDiskSize_Click(object sender, EventArgs e) => RunWithSession(() => MessageBox.Show($"Disk size: {_session.GetDiskSize()} bytes"));
    private void btnRead_Click(object sender, EventArgs e) => RunWithSession(DoRead);
    private void btnWrite_Click(object sender, EventArgs e) => RunWithSession(DoWrite);
    private void btnDelete_Click(object sender, EventArgs e) => RunWithSession(DoDelete);
    private void btnRename_Click(object sender, EventArgs e) => RunWithSession(DoRename);

    private void btnGetFileSize_Click(object sender, EventArgs e)
    {
        RunWithSession(() =>
        {
            var name = GetSelectedFile();
            if (name == null) return;
            MessageBox.Show($"{name}: {_session.GetFileSize(name)} bytes");
        });
    }

    private void OpenSession()
    {
        if (_selected == null || !_selected.Connected) return;
        if (_session != null) return;
        _session = _selected.FileControlStartSession();
        UpdateStatus();
    }

    private void CloseSession()
    {
        try { _session?.Dispose(); } catch { }
        _session = null;
        UpdateStatus();
    }

    private void UpdateStatus()
    {
        bool active = _session != null;
        bool connected = _selected != null && _selected.Connected;

        lblStatus.Text = _selected == null ? "No protocol" :
            !connected ? "Not connected" :
            active ? "Session active" : "No session";

        btnOpenSession.Enabled = connected && !active;
        btnCloseSession.Enabled = active;

        btnList.Enabled = btnGetDir.Enabled = btnChangeDir.Enabled = btnChangeDrive.Enabled =
            btnMakeDir.Enabled = btnGetDiskSize.Enabled = btnGetFileSize.Enabled =
            btnRead.Enabled = btnWrite.Enabled = btnDelete.Enabled = btnRename.Enabled = active;
    }

    private void RunWithSession(Action action)
    {
        if (_session == null) { MessageBox.Show("Open a File Control session first."); return; }
        try { Cursor = Cursors.WaitCursor; action(); }
        finally { Cursor = Cursors.Default; }
    }

    private string GetSelectedFile()
    {
        var sel = lstFiles.SelectedItems;
        return sel.Count > 0 ? sel[0].Text : null;
    }

    private void DoList()
    {
        string raw = _session.ListFiles(cbPattern.Text);
        lstFiles.Items.Clear();
        if (string.IsNullOrEmpty(raw)) return;
        var separators = new[] { "\r\n", "\n", "\r" };
        foreach (var line in raw.Split(separators, StringSplitOptions.RemoveEmptyEntries))
        {
            var name = line.Trim();
            if (name.Length > 0) lstFiles.Items.Add(name);
        }
    }

    private void DoRead()
    {
        var name = GetSelectedFile();
        if (name == null) { MessageBox.Show("Select a file in the list first."); return; }

        byte[] data = _session.ReadFile(name, p =>
        {
            BeginInvoke(new Action(() => lblProgress.Text = $"Reading {p.FileName}: {p.TransferredBytes}/{p.TotalBytes}"));
        });

        dlgSave.FileName = name;
        if (dlgSave.ShowDialog() == DialogResult.OK) File.WriteAllBytes(dlgSave.FileName, data);
        lblProgress.Text = $"Read {name}: {data.Length} bytes";
    }

    private void DoWrite()
    {
        if (dlgOpen.ShowDialog() != DialogResult.OK) return;
        byte[] data = File.ReadAllBytes(dlgOpen.FileName);
        string name = Path.GetFileName(dlgOpen.FileName);
        _session.WriteFile(name, data, p =>
        {
            BeginInvoke(new Action(() => lblProgress.Text = $"Writing {p.FileName}: {p.TransferredBytes}/{p.TotalBytes}"));
        });
        lblProgress.Text = $"Wrote {name}: {data.Length} bytes";
        DoList();
    }

    private void DoDelete()
    {
        var name = GetSelectedFile();
        if (name == null) { MessageBox.Show("Select a file in the list first."); return; }
        if (MessageBox.Show($"Delete {name} ?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        _session.DeleteFile(name);
        DoList();
    }

    private void DoRename()
    {
        var name = GetSelectedFile();
        if (name == null) { MessageBox.Show("Select a file in the list first."); return; }
        string newName = Microsoft.VisualBasic.Interaction.InputBox($"New name for {name}:", "Rename", name);
        if (string.IsNullOrEmpty(newName) || newName == name) return;
        _session.RenameFile(name, newName);
        DoList();
    }
}
