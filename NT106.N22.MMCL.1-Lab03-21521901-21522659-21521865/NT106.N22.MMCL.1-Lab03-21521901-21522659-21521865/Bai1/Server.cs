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
    public partial class Server : Form
    {
        private UdpClient udpServer;
        private IPEndPoint endPoint;
        public Server()
        {
            InitializeComponent();
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
            // Tạo một UdpClient lắng nghe kết nối từ Client
            udpServer = new UdpClient();
            udpServer.Client.Bind(new IPEndPoint(IPAddress.Any, 16211));
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);

            lbMessServer.Items.Add("Server đã được khởi tạo và đang chạy...");
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            // Lấy thông tin client gửi đến
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

            // Nhận dữ liệu từ Client
            Byte[] receiveBytes = udpServer.EndReceive(ar, ref remoteEndPoint);
            string receiveString = Encoding.ASCII.GetString(receiveBytes);

            // Hiển thị dữ liệu nhận được trên TextBox
            BeginInvoke(new Action(() =>
            {
                lbMessServer.Items.Add("Client: "+ remoteEndPoint.Address.ToString() + ": " + receiveString + Environment.NewLine);
            }));

            // Tiếp tục lắng nghe kết nối
            udpServer.BeginReceive(new AsyncCallback(ReceiveCallback), null);
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (udpServer != null)
            {
                udpServer.Close();
            }
        }

    }
}