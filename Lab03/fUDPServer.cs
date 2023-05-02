using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab03
{
    public partial class fUDPServer : Form
    {
        
        private UdpClient _server;
        private IPEndPoint _remoteEndPoint;
        public fUDPServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread serverthread = new Thread(Listen);
            serverthread.IsBackground = true;
            serverthread.Start();
        }

        private void Listen()
        {
            try
            {
                _server = new UdpClient(Convert.ToInt32(txtbPort.Text));
                _remoteEndPoint = new IPEndPoint(IPAddress.Any, Convert.ToInt32(txtbPort.Text));

                while (true)
                {
                    byte[] receivedBytes = _server.Receive(ref _remoteEndPoint);
                    string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

                    Invoke((MethodInvoker)delegate
                    {
                        rtbRecMessage.AppendText($"[{DateTime.Now}] {receivedMessage}\n");
                    });
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
