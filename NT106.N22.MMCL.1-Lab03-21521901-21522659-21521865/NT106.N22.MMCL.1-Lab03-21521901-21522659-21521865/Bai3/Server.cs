using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Server : Form
    {
        private TcpListener server = null;
        private Thread listenerThread = null;
        public Server()
        {
            InitializeComponent();
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, 8888);
            listenerThread = new Thread(new ThreadStart(ListenForClients));
            listenerThread.Start();
            lbServer.Items.Add("Server đã được khởi tạo và đang chạy");
        }
        private void ListenForClients()
        {
            this.server.Start();

            while (true)
            {
                // Chờ Client kết nối
                TcpClient client = this.server.AcceptTcpClient();

                // Tạo thread xử lý kết nối của Client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    // Chờ tin nhắn được gửi
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    // Ngắt khi tin nhắn không được gửi
                    break;
                }

                if (bytesRead == 0)
                {
                    // Ngắt kết nối Client
                    break;
                }

                // Chuyển đổi tin nhắn hiển thị lên Listbox
                string data = Encoding.ASCII.GetString(message, 0, bytesRead);
                lbServer.Invoke((MethodInvoker)(() => lbServer.Items.Add("Client: " + data)));
            }

            tcpClient.Close();
        }
    }
}