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


    private void cbProtocol_SelectedValueChanged(object sender, EventArgs e)
    {

    }

    public void Initialize<T>(ISelectableControl<T> control) where T : IYaskawaClient
    {
        _protocols = new Dictionary<string, IYaskawaClient> {
            { "High Speed Ethernet Server", control.Robot.HighSpeedEServer },
            { "Ethernet Server", control.Robot.EServer },
            { "HTTP", control.Robot.Http },
            { "Host Control (Ethernet)", control.Robot.HostControlEthernet },
            { "Host Control (Serial)", control.Robot.HostControlSerial }
        };

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
