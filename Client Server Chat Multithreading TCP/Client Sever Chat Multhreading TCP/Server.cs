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
using System.Net;
using System.Threading;
using System.Security.Cryptography;

namespace Client_Sever_Chat_Multhreading_TCP
{
    public partial class Server : Form
    {
        private TcpListener serverListener;
        private List<TcpClient> clients = new List<TcpClient>();
        public Server()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            try
            {
                 int port = int.Parse(tbPort.Text);
                 serverListener = new TcpListener(IPAddress.Any, port);
                 serverListener.Start();
                 lbMessage.Items.Add($"Server is starting with port {port}.");
                 btnStart.Enabled = false;
                 btnStop.Enabled = true;
                 btnCreateClient.Enabled = true;
                 Thread thread = new Thread(new ThreadStart(AcceptClient));
                 thread.Start();
            }
            catch (Exception ex)
            {
                lbMessage.Items.Add("Server said: " + ex.Message + $" Example port is: 8080, 8888, etc...");
            }
        }
        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            try
            {
                Form clientForm = new Client();
                clientForm.Show();
                
            }
            catch (Exception ex)
            {
                lbMessage.Items.Add($"{ex.Message}");
            }
        }
        private void AcceptClient()
        {
                // Chấp nhận kết nối từ Client và tạo TcpClient mới để xử lý kết nối
            try
            {
                if (serverListener != null)
                {
                    while (true)
                    {
                        TcpClient client = serverListener.AcceptTcpClient();
                        clients.Add(client);
                        Thread thread = new Thread(new ParameterizedThreadStart(HandleClient));
                        thread.Start(client);
                        lbMessage.Invoke(new Action(() =>
                        {
                            lbMessage.Items.Add("Client connected.");
                        }));
                    }
                }
            }
            catch
            {
                
            }
            
           
        }
        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream clientStream = client.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;
            string mess = string.Empty;
            try
            {
                while (true)
                {
                    // Nhận tin nhắn từ Client và gửi đến tất cả các Client khác
                    bytesRead = 0;
                    try
                    {
                        bytesRead = clientStream.Read(message, 0, 4096);
                        mess = Encoding.UTF8.GetString(message, 0, bytesRead);
                    }
                    catch
                    {
                        break;
                    }
                    if (mess.Contains("Logout"))
                    {
                        // Nếu Client ngắt kết nối, đóng kết nối và xóa khỏi danh sách clients
                        lbMessage.Invoke(new Action(() =>
                        {
                            lbMessage.Items.Add("Client disconnected");
                        }));
                        client.Close();
                        clients.Remove(client);
                        break;
                    }
                    else
                    {
                        string data = Encoding.UTF8.GetString(message, 0, bytesRead);
                        string dataInfor = data;
                        SetText(dataInfor);
                        // Gửi tin nhắn đến tất cả các Client khác

                        foreach (TcpClient c in clients)
                        {
                            if (c != client && c.Connected)
                            {
                                NetworkStream stream = c.GetStream();
                                stream.Write(message, 0, bytesRead);
                                stream.Flush();
                            }
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                lbMessage.Invoke(new Action(() =>
                {
                    lbMessage.Items.Add(ex.Message);
                }));

            }
        }
        private void SetText(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(SetText), new object[] { text });
                return;
            }

            lbMessage.Items.Add(text);
        }
        private void Server_Load(object sender, EventArgs e)
        {
            btnCreateClient.Enabled = false;
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(serverListener != null)
            //    serverListener.Stop();
            //foreach (TcpClient client in clients)
            //{
            //    if (client != null && client.Connected)
            //        client.Close();
            //}
            StopServer();
            foreach (TcpClient client in clients)
            {
                client.Close();
            }
            clients.Clear();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopServer();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void StopServer()
        {
            if (serverListener != null)
            {
                serverListener.Stop();
                foreach (TcpClient client in clients)
                {
                    client.Close();
                }
                clients.Clear();
            }
        }
    }
}
