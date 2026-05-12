using System.Diagnostics;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;

public partial class MainForm : Form
{
    // Yaskawa instance that handles connection to the robot
    private readonly YaskawaRobot _robot = new YaskawaRobot();

    internal static MainForm Instance;

    #region Initialisation
    public MainForm()
    {
        Instance = this;

        // Catch all unhandled exceptions
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        Application.ThreadException += Application_ThreadException;

        // Load configuration file
        Config.Load();

        InitializeComponent();

        // Add nodes in left menu and instantiate associated control 
        AddNode(new ConnectControl(_robot));
        AddNode(new JobControl(_robot));
        AddNode(new AlarmControl(_robot));
        AddNode(new FileControl(_robot));
        AddNode(new FcControl(_robot));
        AddNode(new PendantControl(_robot));
        AddNode(new StatusControl(_robot));
        AddNode(new VariableControl(_robot));
        AddNode(new IoControl(_robot));
        AddNode(new ParametersControl(_robot));
        AddNode(new PositionControl(_robot));
        AddNode(new MoveControl(_robot));
        AddNode(new KinematicsControl(_robot));
        AddNode(new DiagnosticsControl(_robot));
        AddNode(new UserFrameControl(_robot));
        AddNode(new DciControl(_robot));
        AddNode(new ContactControl());
        AddNode(new LicenseControl());

        // Select first node at startup
        SelectNode(leftTreeView.Nodes[0]);
    }

    private void AddNode(IUserControl control)
    {
        var node = leftTreeView.Nodes.Add(control.Title);
        node.Tag = control;
    }
    #endregion

    #region Unhandled exception
    private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
        CatchApplicationException(e.Exception);
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        CatchApplicationException(e.ExceptionObject as Exception);
    }

    private void CatchApplicationException(Exception e)
    {
        if (this.InvokeRequired)
        {
            this.Invoke(new Action(() => CatchApplicationException(e)));
            return;
        }

        if (MessageBox.Show($"{e?.Message}\r\n\r\nWould you like to report this error?", "An error occurred", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) == DialogResult.Yes)
        {
            SelectNode<ContactControl>()?.SetMessage($@"Hi,

I have this exception that prevents me from using the full capabilities of the SDK. Could you take a look at it and help me out?

{e}");
        }
    }
    #endregion

    #region User interaction
    private void leftTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        SelectNode(e.Node);
    }

    internal T SelectNode<T>() where T : class, IUserControl
    {
        var node = Instance.leftTreeView.Nodes.OfType<TreeNode>().FirstOrDefault(n => n.Tag is T);
        var control = node?.Tag as T;
        SelectNode(node);
        return control;
    }

    // Open right control associated to a node
    internal void SelectNode(TreeNode node)
    {
        if (leftTreeView.SelectedNode != node) leftTreeView.SelectedNode = node;

        if (node is null) return;

        mainPanel.SuspendLayout();

        mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.OnClose();

        mainPanel.Controls.Clear();

        var control = node.Tag as Control;

        if (control is null)
        {
            panelTitle.Text = "";
            return;
        }

        lnkSource.Text = $"View C# page source\n{control.GetType().Name}.cs";

        panelTitle.Text = (node.Tag as IUserControl)?.Title;

        mainPanel.Controls.Add(control);

        control.Dock = DockStyle.Fill;

        mainPanel.ResumeLayout();

        try
        {
            Cursor = Cursors.WaitCursor;
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.OnOpen();
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.PeriodicUpdate();
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }


    internal void OpenUrl(string url)
    {
        if (string.IsNullOrEmpty(url)) return;
        try
        {
            var ps = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        catch { }
    }
    #endregion

    // Timer callback to refresh the control on the right and the left menu
    private void tmrPeriodicUpdate_Tick(object sender, EventArgs e)
    {
        try
        {
            // refresh control on the right
            mainPanel.Controls.OfType<IUserControl>().FirstOrDefault()?.PeriodicUpdate();
        }
        catch { }

        try
        {
            // Refresh left menu icons and colors
            foreach (TreeNode node in leftTreeView.Nodes)
            {
                try
                {
                    var ctrl = node?.Tag as IUserControl;
                    if (ctrl == null) continue;

                    var enabled = ctrl.FeatureEnabled;

                    var key = enabled ? "ON" : "OFF";

                    if (key != node.ImageKey)
                    {
                        node.ImageKey = key;
                        node.SelectedImageKey = key;
                        node.ForeColor = enabled ? Color.Green : Color.DarkGray;
                    }
                }
                catch { }
            }
        }
        catch { }
    }



    private void titlePictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        ScreenshotsGenerator.Generate(this);
    }

    private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        OpenUrl((sender as LinkLabel)?.Text);
    }

    private void lnkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var name = mainPanel.Controls.OfType<IUserControl>().FirstOrDefault().GetType().Name;
        OpenUrl($"https://github.com/underautomation/Yaskawa.NET/blob/main/UnderAutomation.Yaskawa.Showcase.Forms/Components/{name}.cs");
    }
}