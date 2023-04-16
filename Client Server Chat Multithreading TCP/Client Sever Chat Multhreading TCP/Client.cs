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
using System.Net.Sockets;
using System.Threading;

namespace Client_Sever_Chat_Multhreading_TCP
{
    public partial class Client : Form
    {
        private TcpClient client;
        private Thread thread;
        
        public Client()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                int port = int.Parse(tbPort.Text);
                IPAddress ipaddress = IPAddress.Parse(tbIP.Text);
                client.Connect(ipaddress, port);
                Task.Run(async () => await ReceiveMessageAsync());
                //thread.Start();
                lbMessage.Items.Add("Connect to server.");
            }
            catch (Exception ex)
            {
                lbMessage.Items.Add(ex.Message);
            }
        }
        private async Task ReceiveMessageAsync()
        {
            while (true)
            {
                byte[] buffer = new byte[4096];
                NetworkStream clientStream = client.GetStream();
                int bytesRead = await clientStream.ReadAsync(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    lbMessage.Invoke(new Action(() =>
                    {
                        lbMessage.Items.Add("Disconnected from server.");
                    }));

                    this.Close();
                    //thread.Abort();
                    break;
                }

                lbMessage.Invoke(new Action(() =>
                {
                    lbMessage.Items.Add(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                }));
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.Connected)
            {
                NetworkStream stream = client.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(tbName.Text + ": Logout");
                stream.Write(data, 0, data.Length);
                //client.Close();
            }
            if (thread != null && thread.IsAlive)
            {
                thread.Abort();
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSend.Text != string.Empty)
                {
                    lbMessage.Items.Add($"You: {tbSend.Text}");
                    byte[] buffer = Encoding.UTF8.GetBytes($"{tbName.Text}: {tbSend.Text}");
                    NetworkStream clientStream = client.GetStream();
                    await clientStream.WriteAsync(buffer, 0, buffer.Length);
                    await clientStream.FlushAsync();
                    tbSend.Clear();
                }
            }
            catch (Exception ex)
            {
                lbMessage.Items.Add(ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
