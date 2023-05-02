using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class fTCPTelnetServer : Form
    {
        public fTCPTelnetServer()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            // Khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];
            // Tạo socket bên gửi
            Socket clientSocket;
            // Tạo socket bên nhận, socket này là socket lắng nghe các kết nối tới nó tại địa chỉ IP 
            // của máy và port 8080.Đây là 1 TCP / IP socket.
            //AddressFamily: Với địa chỉ Ipv4 cần chọn AddressFamily.InterNetwork
            //SocketType: kiểu kết nối socket, ở đây dùng luồng Stream để nhận dữ liệu
            Socket listenerSocket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);
            // bắt đầu lắng nghe. Socket.Listen(int backlog) 
            listenerSocket.Listen(-1);
            //Đồng ý kết nối
            clientSocket = listenerSocket.Accept();
            //Nhận dữ liệu
            listView.Items.Add(new ListViewItem("New client"));
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                listView.Items.Add(new ListViewItem(text));
            }
            listenerSocket.Close();
        }
    }
}
