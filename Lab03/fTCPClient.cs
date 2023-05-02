using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class fTCPClient : Form
    {
        private Socket _clientSocket;
        private Thread _clientThread;
        public fTCPClient()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string serverIP = "127.0.0.1";
                int port = 8080;
                _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _clientSocket.Connect(serverIP, port);
                _clientThread = new Thread(new ThreadStart(ClientReceive));
                _clientThread.Start();
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientReceive()
        {
            byte[] buffer = new byte[1024];
            int bytesReceived;
            while (_clientSocket.Connected)
            {
                bytesReceived = _clientSocket.Receive(buffer);
                string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                Invoke(new Action(() => rtbMessage.AppendText(receivedData + Environment.NewLine)));
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_clientSocket != null && _clientSocket.Connected)
            {
                byte[] message = Encoding.ASCII.GetBytes(rtbMessage.Text);
                _clientSocket.Send(message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (_clientSocket != null && _clientSocket.Connected)
            {
                _clientSocket.Shutdown(SocketShutdown.Both);
                _clientSocket.Close();
                _clientThread.Abort();
                btnConnect.Enabled = true;
            }
        }
    }
}
