using System;
using System.IO;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HostControl;
using UnderAutomation.Yaskawa.HostControl.Internal;

public partial class DciControl : UserControl, IUserControl, ISelectableControl<HostControlBscClientBase>
{
    private HostControlBscClientBase _selected;

    public YaskawaRobot Robot { get; set; }

    public HostControlBscClientBase SelectedProtocol
    {
        get => _selected;
        set
        {
            bool wasListening = _selected?.DciListening ?? false;
            if (wasListening) StopListening();
            DetachEvents();
            _selected = value;
            AttachEvents();
            UpdateStatus();
        }
    }

    public DciControl(YaskawaRobot Yaskawa)
    {
        Robot = Yaskawa;
        InitializeComponent();
        protocolSelector.Initialize(this);
    }

    #region IUserControl
    public string Title => "DCI Listener";
    public bool FeatureEnabled => SelectedProtocol?.Connected ?? false;
    public void OnOpen() { UpdateStatus(); }
    public void OnClose() { StopListening(); }
    public void PeriodicUpdate() { UpdateStatus(); }
    #endregion

    private void AttachEvents()
    {
        if (_selected == null) return;
        _selected.DciSaveJReceived += OnSaveJ;
        _selected.DciLoadJReceived += OnLoadJ;
        _selected.DciSaveVReceived += OnSaveV;
        _selected.DciLoadVReceived += OnLoadV;
        _selected.DciError += OnError;
    }

    private void DetachEvents()
    {
        if (_selected == null) return;
        _selected.DciSaveJReceived -= OnSaveJ;
        _selected.DciLoadJReceived -= OnLoadJ;
        _selected.DciSaveVReceived -= OnSaveV;
        _selected.DciLoadVReceived -= OnLoadV;
        _selected.DciError -= OnError;
    }

    private void btnToggleListen_Click(object sender, EventArgs e)
    {
        if (_selected == null) return;
        if (_selected.DciListening) StopListening();
        else StartListening();
        UpdateStatus();
    }

    private void btnClearLog_Click(object sender, EventArgs e)
    {
        lstEvents.Items.Clear();
    }

    private void StartListening()
    {
        if (_selected == null || !_selected.Connected) return;
        _selected.DciStartListening();
    }

    private void StopListening()
    {
        try { _selected?.DciStopListening(); } catch { }
    }

    private void UpdateStatus()
    {
        bool listening = _selected != null && _selected.DciListening;
        btnToggleListen.Text = listening ? "Stop Listening" : "Start Listening";
        btnToggleListen.Enabled = _selected != null && _selected.Connected;
        lblStatus.Text = _selected == null ? "No protocol" :
            !_selected.Connected ? "Not connected" :
            listening ? "Listening..." : "Stopped";
    }

    private void btnBrowseFolder_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtJobsFolder.Text) && Directory.Exists(txtJobsFolder.Text))
            folderBrowserDialog.SelectedPath = txtJobsFolder.Text;
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            txtJobsFolder.Text = folderBrowserDialog.SelectedPath;
    }

    #region DCI Event Handlers (called from background thread)

    private void OnSaveJ(object sender, DciSaveJReceivedEventArgs e)
    {
        try
        {
            string folder = txtJobsFolder.Text;
            if (!string.IsNullOrEmpty(folder) && Directory.Exists(folder))
            {
                string ext = e.Format == DciJobFormat.Jbi ? ".JBI" : ".JBR";
                File.WriteAllBytes(Path.Combine(folder, e.JobName + ext), e.JobData);
            }
        }
        catch { }

        AppendLog("SAVEJ", $"{e.JobName} ({e.Format}) - {e.JobData?.Length ?? 0} bytes");
    }

    private void OnLoadJ(object sender, DciLoadJReceivedEventArgs e)
    {
        try
        {
            string folder = txtJobsFolder.Text;
            if (!string.IsNullOrEmpty(folder) && Directory.Exists(folder))
            {
                string ext = e.Format == DciJobFormat.Jbi ? ".JBI" : ".JBR";
                string path = Path.Combine(folder, e.JobName + ext);
                if (File.Exists(path))
                {
                    e.JobData = File.ReadAllBytes(path);
                    AppendLog("LOADJ", $"{e.JobName} ({e.Format}) - served {e.JobData.Length} bytes");
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            AppendLog("LOADJ", $"{e.JobName} ({e.Format}) - error: {ex.Message}");
            e.ResponseCode = "0001";
            return;
        }

        AppendLog("LOADJ", $"{e.JobName} ({e.Format}) - file not found");
        e.ResponseCode = "0004";
    }

    private void OnSaveV(object sender, DciSaveVReceivedEventArgs e)
    {
        AppendLog("SAVEV", $"{e.VariableType}: {e.RawData}");
    }

    private void OnLoadV(object sender, DciLoadVReceivedEventArgs e)
    {
        e.ResponseData = txtLoadVResponse.Text;
        AppendLog("LOADV", $"{e.VariableType} ({e.RawData}) - served \"{e.ResponseData}\"");
    }

    private void OnError(object sender, DciErrorEventArgs e)
    {
        AppendLog("ERROR", e.Exception?.Message ?? "unknown");
    }

    private void AppendLog(string type, string info)
    {
        if (IsDisposed || !IsHandleCreated) return;
        try
        {
            BeginInvoke(new Action(() =>
            {
                var item = new ListViewItem(DateTime.Now.ToString("HH:mm:ss.fff"));
                item.SubItems.Add(type);
                item.SubItems.Add(info);
                lstEvents.Items.Add(item);
                item.EnsureVisible();
            }));
        }
        catch { }
    }

    #endregion
}
