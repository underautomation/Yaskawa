using System;
using System.ComponentModel;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;
using UnderAutomation.Yaskawa.Common;
using UnderAutomation.Yaskawa.HighSpeedEServer;

public partial class ProtocolSelector : UserControl
{

    public ProtocolSelector()
    {
        InitializeComponent();
    }

    private Dictionary<string, IYaskawaClient> _protocols;

    private void tmrConnected_Tick(object sender, EventArgs e)
    {
        if (cbProtocol.DroppedDown || _protocols == null) return;

        if (_protocols.TryGetValue(cbProtocol.Text, out IYaskawaClient current) && current.Connected) return;

        foreach (string name in cbProtocol.Items)
        {
            if (_protocols.TryGetValue(name, out IYaskawaClient client) && client.Connected)
            {
                if (cbProtocol.Text != name)
                    cbProtocol.Text = name;
                return;
            }
        }
    }

    public void Initialize<T>(ISelectableControl<T> control) where T : IYaskawaClient
    {
        _protocols = new Dictionary<string, IYaskawaClient> {
            { "High Speed Ethernet Server", control.Robot.HighSpeedEServer },
            { "Ethernet Server", control.Robot.EServer },
            { "HTTP", control.Robot.Http },
            { "Host Control (Ethernet)", control.Robot.HostControlEthernet },
            { "Host Control (Serial)", control.Robot.HostControlSerial },
            { "FTP", control.Robot.Ftp }
        };

        cbProtocol.Items.Clear();

        foreach (var protocol in _protocols)
        {
            if (protocol.Value is T)
            {
                cbProtocol.Items.Add(protocol.Key);
            }
        }

        cbProtocol.SelectedIndexChanged += (o, e) =>
        {
            if (_protocols.TryGetValue(cbProtocol.Text, out IYaskawaClient client))
            {
                control.SelectedProtocol = (T)client;
            }
        };

        cbProtocol.SelectedIndex = 0;
    }

}
