using NetworkViewer.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace NetworkViewer
{
    public partial class MainWindow : Form
    {
        List<Ping> pinger;
        Ping RealTime;
        System.Net.IPAddressCollection ips;
        bool IsRealTimeRunning;

        public MainWindow()
        {
            InitializeComponent();
            Text = ProductName + " " + ProductVersion;
            Button_RefreshInterfaces_Click(this, null);
        }

        private void ComboBox_interfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Interfaces.SelectedIndex > -1)
            {
                foreach (DataGridViewRow label in dataGridView_interfaces.Rows)
                {
                    if (label.Cells[1].Value.ToString() == ComboBox_Interfaces.SelectedItem.ToString())
                    {
                        Label_AdresseIP.Text = label.Cells[2].Value.ToString();
                    }
                }
            }
        }

        private void BackgroundWorker_Ping_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            while (i < ips.Count)
            {
                pinger.Add(new Ping());
                pinger.Last().PingCompleted += Pinger_PingCompleted;
                pinger.Last().SendPingAsync(ips[i++]);
            }
        }

        private void Pinger_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Reply.Status == IPStatus.Success)
            {
                dataGridView_netview.Invoke((MethodInvoker)delegate
                {
                    dataGridView_netview.Rows.Add();
                    try
                    {
                        dataGridView_netview.Rows[dataGridView_netview.RowCount - 1].Cells[0].Value = Dns.GetHostEntry(e.Reply.Address).HostName;
                    }
                    catch (SocketException)
                    {
                        dataGridView_netview.Rows[dataGridView_netview.RowCount - 1].Cells[0].Value = "Inconnu";
                    }
                    dataGridView_netview.Rows[dataGridView_netview.RowCount - 1].Cells[1].Value = e.Reply.Address.ToString();
                    dataGridView_netview.Rows[dataGridView_netview.RowCount - 1].Cells[2].Value = e.Reply.RoundtripTime.ToString() + "ms";
                    dataGridView_netview.Rows[dataGridView_netview.RowCount - 1].Cells[3].Value = IPtoMACHelper.getMacByIp(e.Reply.Address.ToString());
                });
            }

            pinger[pinger.IndexOf((Ping)sender)] = null;

            progressBar_inResearch.Invoke((MethodInvoker)delegate
            {
                progressBar_inResearch.PerformStep();

                if (progressBar_inResearch.Value == progressBar_inResearch.Maximum)
                {
                    progressBar_inResearch.Visible = false;
                }
            });
        }

        private void Button_RefreshInterfaces_Click(object sender, EventArgs e)
        {
            //Remise à zéro interface
            while (dataGridView_interfaces.RowCount > 0)
                dataGridView_interfaces.Rows.RemoveAt(0);
            ComboBox_Interfaces.Items.Clear();
            while (dataGridView_netview.RowCount > 0)
                dataGridView_netview.Rows.RemoveAt(0);

            //Initilisation des variables
            NetworkInterface[] AllAdapters = NetworkInterface.GetAllNetworkInterfaces();
            List<NetworkInterface> AdaptersToDisplay = new List<NetworkInterface>();

            //Filtrage des interfaces
            foreach (NetworkInterface filter in AllAdapters)
            {
                if (filter.OperationalStatus == OperationalStatus.Up
                    && (filter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211
                    || filter.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                    || filter.NetworkInterfaceType == NetworkInterfaceType.Ethernet3Megabit
                    || filter.NetworkInterfaceType == NetworkInterfaceType.FastEthernetFx
                    || filter.NetworkInterfaceType == NetworkInterfaceType.FastEthernetT
                    || filter.NetworkInterfaceType == NetworkInterfaceType.GigabitEthernet))
                {
                    AdaptersToDisplay.Add(filter);
                }
            }

            //Ajout des informations
            foreach (NetworkInterface network in AdaptersToDisplay)
            {
                dataGridView_interfaces.Rows.Add();

                //Nom
                dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[0].Value = network.Name;

                //Description
                dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[1].Value = network.Description;

                //Adresse IPv4
                foreach (UnicastIPAddressInformation ip in network.GetIPProperties().UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[2].Value = ip.Address.ToString();
                    }
                }

                //Passerelle IPv4
                if (network.GetIPProperties().GatewayAddresses.Count > 0)
                {
                    dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[3].Value = network.GetIPProperties().GatewayAddresses.FirstOrDefault().Address;
                    ComboBox_Interfaces.Items.Add(network.Description);
                }
                else dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[3].Value = "N/A";

                //Masque de sous-réseau
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in network.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        dataGridView_interfaces.Rows[dataGridView_interfaces.RowCount - 1].Cells[4].Value = unicastIPAddressInformation.IPv4Mask;
                    }
                }

                //Selection de la première entrée de scan
                if (ComboBox_Interfaces.Items.Count > 0)
                {
                    ComboBox_Interfaces.SelectedIndex = 0;
                }
            }
        }

        private void Button_StartScan_Click(object sender, EventArgs e)
        {
            //Vidage du tableau
            while (dataGridView_netview.RowCount > 0)
                dataGridView_netview.Rows.RemoveAt(0);

            //Création de la liste des adresses à scanner
            pinger = new List<Ping>();
            IPNetwork2 ipn = IPNetwork2.Parse(Label_AdresseIP.Text, dataGridView_interfaces.Rows[ComboBox_Interfaces.SelectedIndex].Cells[4].Value.ToString());
            ips = ipn.ListIPAddress();

            //Lancement de la recherche
            BackgroundWorker_Scan.RunWorkerAsync();
            progressBar_inResearch.Value = 0;
            progressBar_inResearch.Maximum = ips.Count();
            progressBar_inResearch.Visible = true;
        }

        private void Button_StartRealTime_Click(object sender, EventArgs e)
        {
            NumericUpDown_Intervalle_ValueChanged(this, null);
            ListBox_RealTime.Items.Clear();
            Chart_RealTime.Series.First().Points.Clear();
            Button_StartRealTime.Enabled = false;
            Button_StopRealTime.Enabled = true;
            TextBox_AddressToWatch.Enabled = false;
            IsRealTimeRunning = true;
            RelaunchPing();
        }

        private void Button_StopRealTime_Click(object sender, EventArgs e)
        {
            IsRealTimeRunning = false;
        }

        private void RelaunchPing()
        {
            if (IsRealTimeRunning)
            {
                RealTime = new Ping();
                RealTime.PingCompleted += Pinger_RealTimeCompleted;
                BackgroundWorker_RealTime.RunWorkerAsync();
                Timer_RealTime.Start();
            }
            else
            {
                Button_StartRealTime.Invoke((MethodInvoker)delegate
                {
                    Button_StartRealTime.Enabled = true;
                });
                Button_StopRealTime.Invoke((MethodInvoker)delegate
                {
                    Button_StopRealTime.Enabled = false;
                });
                TextBox_AddressToWatch.Invoke((MethodInvoker)delegate
                {
                    TextBox_AddressToWatch.Enabled = true;
                });
            }
        }

        private void BackgroundWorker_RealTime_DoWork(object sender, DoWorkEventArgs e)
        {
            RealTime.SendPingAsync(IPAddress.Parse(TextBox_AddressToWatch.Text));
        }

        private void Pinger_RealTimeCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Reply.Status == IPStatus.Success)
            {
                Chart_RealTime.Invoke((MethodInvoker)delegate
                {
                    Chart_RealTime.Series.First().Points.AddY(e.Reply.RoundtripTime);
                });
                ListBox_RealTime.Invoke((MethodInvoker)delegate
                {
                    ListBox_RealTime.Items.Insert(0, e.Reply.RoundtripTime.ToString() + "ms");
                });
            }
            else
            {
                Chart_RealTime.Invoke((MethodInvoker)delegate
                {
                    Chart_RealTime.Series.First().Points.AddY(0);
                });
                ListBox_RealTime.Invoke((MethodInvoker)delegate
                {
                    ListBox_RealTime.Items.Insert(0, e.Reply.Status.ToString());
                });
            }
        }

        private void TextBox_AddressToWatch_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_AddressToWatch.Text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Length == 4)
            {
                try
                {
                    IPAddress.Parse(TextBox_AddressToWatch.Text);
                    Button_StartRealTime.Enabled = true;
                }
                catch (FormatException)
                {
                    Button_StartRealTime.Enabled = false;
                }
            }
            else
            {
                Button_StartRealTime.Enabled = false;
            }
        }

        private void NumericUpDown_Intervalle_ValueChanged(object sender, EventArgs e)
        {
            Timer_RealTime.Interval = (int)NumericUpDown_Intervalle.Value * 1000;
        }

        private void Timer_RealTime_Tick(object sender, EventArgs e)
        {
            Timer_RealTime.Stop();
            RelaunchPing();
        }
    }
}
