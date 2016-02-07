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

        public Form1()
        {
            InitializeComponent();
            button_mode_Click(this, null);
            button_actualiser_Click(this, null);
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
                        && adapters[x].NetworkInterfaceType != NetworkInterfaceType.Loopback
                        && adapters[x].NetworkInterfaceType != NetworkInterfaceType.Tunnel)
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
                modifierDimensions();
            }
            else
            {
                
            }
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void modifierDimensions()
        {
            dataGridView_interfaces.AutoResizeColumns();
            if(Size.Height<200)
                Size = new Size(Size.Width, 200);
            int large = 0;
            for(int x=0;x<dataGridView_interfaces.ColumnCount;x++)
            {
                large += dataGridView_interfaces.Columns[x].Width;
            }
            dataGridView_interfaces.Size = new Size(large, Size.Height - 50);
            dataGridView_netview.Size = new Size(large, Size.Height - 75);
            Size = new Size(dataGridView_interfaces.Location.X + large + 20, Size.Height);
        }

        private void button_mode_Click(object sender, EventArgs e)
        {
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
            button_actualiser.PerformClick();
        }

        private void comboBox_interfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_adresseIP.Text = "";
            if (comboBox_interfaces.SelectedIndex >= 0)
            {
                if (dataGridView_interfaces.Rows[comboBox_interfaces.SelectedIndex].Cells[2].Value.ToString() != "")
                {
                    label_adresseIP.Text = dataGridView_interfaces.Rows[comboBox_interfaces.SelectedIndex].Cells[2].Value.ToString();
                }
            }
        }
    }
}
