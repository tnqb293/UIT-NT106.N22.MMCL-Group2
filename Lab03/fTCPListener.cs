using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab03
{
    public partial class fTCPListener : Form
    {
        private Socket _listenerSocket;
        private Thread _listenThread;
        public fTCPListener()
        {
            InitializeComponent();
        }

        private void ListenForClients()
        {
            _listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint listenerEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            _listenerSocket.Bind(listenerEndPoint);
            _listenerSocket.Listen(-1);

            while (true)
            {
                Socket clientSocket = _listenerSocket.Accept();
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(clientSocket);
            }
        }

        private void HandleClientComm(object clientObj)
        {
            Socket clientSocket = (Socket)clientObj;
            byte[] message = new byte[4096];
            int bytesRead;

            while (clientSocket.Connected)
            {
                bytesRead = clientSocket.Receive(message);
                string data = Encoding.ASCII.GetString(message, 0, bytesRead);
                Invoke(new Action(() => rtbMessage.AppendText(data + Environment.NewLine)));
            }

            clientSocket.Close();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                _listenThread = new Thread(new ThreadStart(ListenForClients));
                _listenThread.Start();
                btnListen.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
