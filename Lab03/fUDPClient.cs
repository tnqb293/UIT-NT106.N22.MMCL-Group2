using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class fUDPClient : Form
    {
        private UdpClient _client;

        public fUDPClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string ipAddress = txtbIPRemoteHost.Text;
            int port = int.Parse(txtbPort.Text);

            string message = rtbMessage.Text;

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message to send in the RichTextBox.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(ipAddress))
            {
                MessageBox.Show("Please enter the server IP address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtbPort.Text))
            {
                MessageBox.Show("Please enter the server port number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _client = new UdpClient();
                byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                _client.Send(sendBytes, sendBytes.Length, ipAddress, port);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
