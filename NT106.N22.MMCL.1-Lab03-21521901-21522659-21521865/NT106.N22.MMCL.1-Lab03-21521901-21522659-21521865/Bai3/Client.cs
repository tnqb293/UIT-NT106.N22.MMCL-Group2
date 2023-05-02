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

namespace Bai3
{
    public partial class Client : Form
    {
        private TcpClient client = null;
        private NetworkStream stream = null;
        public Client()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo kết nối TCP đến Server
                this.client = new TcpClient();
                this.client.Connect("127.0.0.1", 8888);

                // Tạo luồng để gửi và nhận tin nhắn
                this.stream = client.GetStream();
                this.lbClient.Items.Add("Kết nối tới Server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            if (this.client != null)
            {
                this.client.Close();
                this.stream = null;
                this.lbClient.Items.Add("Đã ngắt kết nối tới Server");
            }
        }
        private void Send_Click(object sender, EventArgs e)
        {
            if (this.stream != null)
            {
                try
                {
                    // Chuyển đổi tin nhắn và gửi tới Server
                    string message = txtSend.Text;
                    byte[] data = Encoding.ASCII.GetBytes(this.txtSend.Text);
                    this.stream.Write(data, 0, data.Length);

                    this.txtSend.Clear();
                    lbClient.Items.Add("Client: " + message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}