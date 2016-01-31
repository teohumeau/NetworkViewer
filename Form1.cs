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
        public Form1()
        {
            InitializeComponent();
            button_actualiser_Click(this, null);
        }

        private void button_actualiser_Click(object sender, EventArgs e)
        {
            //Vidage du tableau
            while (tableau.RowCount != 0)
                tableau.Rows.RemoveAt(0);

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            List<int> affichage = new List<int> { };
            for (int x = 0; x < adapters.Length; x++)
            {
                if (adapters[x].OperationalStatus == OperationalStatus.Up)
                {
                    affichage.Add(x);
                }
            }
            for (int x = 0; x < localIP.Length; x++)
            {
                if (affichage.IndexOf(x) != -1)
                {
                    tableau.Rows.Add();
                    tableau.Rows[tableau.RowCount - 1].Cells[0].Value = adapters[x].Name;
                    tableau.Rows[tableau.RowCount - 1].Cells[1].Value = adapters[x].Description;
                    if (localIP[x].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        tableau.Rows[tableau.RowCount - 1].Cells[2].Value = localIP[x].ToString();
                    if (adapters[x].GetIPProperties().GatewayAddresses.Count > 0)
                        tableau.Rows[tableau.RowCount - 1].Cells[3].Value = adapters[x].GetIPProperties().GatewayAddresses.FirstOrDefault().Address;
                    else tableau.Rows[tableau.RowCount - 1].Cells[3].Value = "N/A";
                    foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapters[x].GetIPProperties().UnicastAddresses)
                    {
                        if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            tableau.Rows[tableau.RowCount - 1].Cells[4].Value = unicastIPAddressInformation.IPv4Mask;
                        }
                    }
                }
            }
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
