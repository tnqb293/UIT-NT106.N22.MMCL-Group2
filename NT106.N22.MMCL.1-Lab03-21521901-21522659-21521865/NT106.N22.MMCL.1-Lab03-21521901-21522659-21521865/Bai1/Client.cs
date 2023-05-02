using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Client : Form
    {
        private UdpClient udpClient;
        private IPEndPoint endPoint;
        public Client()
        {
            InitializeComponent();
        }

        private void StartClient_Click(object sender, EventArgs e)
        {
            udpClient = new UdpClient();
            endPoint = new IPEndPoint(IPAddress.Parse(txtServerIP.Text), 16211);

            lbMessClient.Items.Add("Đã kết nối tới Server " + txtServerIP.Text + ":16211");
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (udpClient != null)
            {
                // Gửi thông điệp tới Server
                string message = txtSendClient.Text;
                Byte[] sendBytes = Encoding.ASCII.GetBytes(txtSendClient.Text);
                udpClient.Send(sendBytes, sendBytes.Length, endPoint);
                lbMessClient.Items.Add("Client: " + message);
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (udpClient != null)
            {
                udpClient.Close();
            }
        }
    }
}