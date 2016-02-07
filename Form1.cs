using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace NetworkViewer
{
    public partial class Form1 : Form
    {
        bool local = false;
        List<Ping> pinger;
        List<IPAddress> address;

        public Form1()
        {
            pinger = new List<Ping>();
            address = new List<IPAddress>();
            InitializeComponent();
            Text = ProductName + " " + ProductVersion;
            button_mode_Click(this, null);
            button_actualiser_Click(this, null);
            modifierDimensions(this, null);
        }

        private void button_actualiser_Click(object sender, EventArgs e)
        {
            if (local)
            {
                //Vidage du tableau
                while (dataGridView_interfaces.RowCount != 0)
                    dataGridView_interfaces.Rows.RemoveAt(0);

                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                List<IPAddress> localIP = Dns.GetHostAddresses(Dns.GetHostName()).ToList();
                if (localIP.Count >= 1)
                {
                    while (localIP[0].AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork)
                        localIP.RemoveAt(0);
                }
                List<int> affichage = new List<int> { };
                for (int x = 0; x < adapters.Length; x++)
                {
                    if (adapters[x].OperationalStatus == OperationalStatus.Up 
                        && (adapters[x].NetworkInterfaceType == NetworkInterfaceType.Wireless80211
                        || adapters[x].NetworkInterfaceType == NetworkInterfaceType.Ethernet
                        || adapters[x].NetworkInterfaceType == NetworkInterfaceType.Ethernet3Megabit
                        || adapters[x].NetworkInterfaceType == NetworkInterfaceType.FastEthernetFx
                        || adapters[x].NetworkInterfaceType == NetworkInterfaceType.FastEthernetT
                        || adapters[x].NetworkInterfaceType == NetworkInterfaceType.GigabitEthernet))
                    {
                        affichage.Add(x);
                    }
                }
                for (int x = 0; x < localIP.Count; x++)
                {
                    if (x < affichage.Count)
                    {
                        int aff = affichage[x];
                        if (aff != -1)
                        {
                            dataGridView_interfaces.Rows.Add();
                            dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[0].Value = adapters[aff].Name;
                            dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[1].Value = adapters[aff].Description;
                            if (localIP[x].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[2].Value = localIP[x].ToString();
                            if (adapters[aff].GetIPProperties().GatewayAddresses.Count > 0)
                                dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[3].Value = adapters[aff].GetIPProperties().GatewayAddresses.FirstOrDefault().Address;
                            else dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[3].Value = "N/A";
                            foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapters[aff].GetIPProperties().UnicastAddresses)
                            {
                                if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                                {
                                    dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[4].Value = unicastIPAddressInformation.IPv4Mask;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                //Vidage du tableau
                while (dataGridView_netview.RowCount > 0)
                    dataGridView_netview.Rows.RemoveAt(0);
                pinger.Clear();
                address.Clear();
                IPAddress adresse = IPAddress.Parse(label_adresseIP.Text);
                for (int x = 0; x < 255; x++)
                {
                    if (x > 0)
                    {
                        adresse = IPIncrement(adresse);
                    }
                    address.Add(adresse);
                    pinger.Add(new Ping());
                    pinger.Last().PingCompleted += Pinger_PingCompleted;
                    pinger.Last().SendPingAsync(adresse);
                }
            }
        }

        private void Pinger_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            int x = pinger.IndexOf((Ping)sender);
            if (e.Reply.Status == IPStatus.Success)
            {
                dataGridView_netview.Rows.Add();
                try
                {
                    dataGridView_netview.Rows[dataGridView_netview.RowCount - 1].Cells[0].Value = Dns.GetHostEntry(address[x]).HostName;
                }
                catch(SocketException)
                {
                    dataGridView_netview.Rows[dataGridView_netview.RowCount - 1].Cells[0].Value = "Inconnu";
                }
                dataGridView_netview.Rows[dataGridView_netview.RowCount - 1].Cells[1].Value = address[x].ToString();
                dataGridView_netview.Rows[dataGridView_netview.RowCount - 1].Cells[2].Value = e.Reply.RoundtripTime.ToString() + "ms";
            }
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void modifierDimensions(object sender, EventArgs e)
        {
            dataGridView_interfaces.Size = new Size(Size.Width - 75, Size.Height - 50);
            dataGridView_netview.Size = new Size(Size.Width - 75, Size.Height - 75);
            dataGridView_interfaces.Columns[0].Width = dataGridView_interfaces.Width / 5;
            dataGridView_interfaces.Columns[1].Width = dataGridView_interfaces.Width / 3;
            for(int x=2;x<5;x++)
                dataGridView_interfaces.Columns[x].Width = dataGridView_interfaces.Width / 7;
            for (int x = 0; x < dataGridView_netview.Columns.Count; x++)
            {
                dataGridView_netview.Columns[x].Width = (dataGridView_netview.Width / dataGridView_netview.Columns.Count) - 1;
            }
        }

        private void button_mode_Click(object sender, EventArgs e)
        {
            button_actualiser.Enabled = true;
            local = !local;
            if (local)
            {
                button_mode.BackgroundImage = NetworkViewer.Properties.Resources.Réseau;
            }
            else
            {
                button_mode.BackgroundImage = NetworkViewer.Properties.Resources.Ecran;
                comboBox_interfaces.Items.Clear();
                for (int x = 0; x < dataGridView_interfaces.RowCount; x++)
                {
                    comboBox_interfaces.Items.Add(dataGridView_interfaces.Rows[x].Cells[1].Value);
                }
                if (comboBox_interfaces.Items.Count > 0)
                {
                    comboBox_interfaces.SelectedIndex = 0;
                }
            }
            dataGridView_interfaces.Visible = local;
            comboBox_interfaces.Visible = !local;
            label_adresseIP.Visible = !local;
            dataGridView_netview.Visible = !local;
        }

        private void comboBox_interfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_adresseIP.Text = "";
            if (comboBox_interfaces.SelectedIndex >= 0)
            {
                if (dataGridView_interfaces.Rows[comboBox_interfaces.SelectedIndex].Cells[3].Value.ToString() != "N/A")
                {
                    label_adresseIP.Text = dataGridView_interfaces.Rows[comboBox_interfaces.SelectedIndex].Cells[3].Value.ToString();
                    button_actualiser.Enabled = true;
                }
                else
                {
                    label_adresseIP.Text = "Recherche impossible";
                    button_actualiser.Enabled = false;
                }
            }
        }

        private IPAddress IPIncrement(IPAddress add)
        {
            byte[] bytes = add.GetAddressBytes();
            IPAddress result;

            for (int y = bytes.Length - 1; y >= 0; y--)
            {
                if (bytes[y] == byte.MaxValue)
                {
                    bytes[y] = 0;
                    continue;
                }

                bytes[y]++;

                result = new IPAddress(bytes);
                return result;
            }
            return add;
        }
    }
}
