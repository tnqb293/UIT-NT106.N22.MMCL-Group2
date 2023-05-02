using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Telnet : Form
    {
        private Socket listenerSocket;
        private Thread listenerThread;

        public Telnet()
        {
            InitializeComponent();
            LISTEN.Click += new EventHandler(lISTEN_Click);
        }

        private void lISTEN_Click(object sender, EventArgs e)
        {
            // Khởi tạo socket lắng nghe kết nối TCP trên cổng 8080
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenerSocket.Bind(new IPEndPoint(IPAddress.Any, 8080));
            listenerSocket.Listen(10);

            // Khởi tạo luồng lắng nghe
            listenerThread = new Thread(new ThreadStart(ListenThread));
            listenerThread.Start();

            MessageBox.Show("Đã bắt đầu lắng nghe kết nối Telnet trên cổng 8080.");
            lbTelnet.Items.Add("Kết nối thành công");
        }

        private void ListenThread()
        {
            try
            {
                while (true)
                {
                    // Chấp nhận kết nối
                    Socket clientSocket = listenerSocket.Accept();
                    // Tạo một thread mới để xử lý kết nối từ Client
                    Thread clientThread = new Thread(() =>
                    {
                        try
                        {
                            // Hướng dẫn nhập tin nhắn(Enter 2 lần để bắt đầu nhập tin nhắn)
                            string welcomeMessage = "De bat dau gui tin nhan, vui long nhan phim Enter\r\n";
                            byte[] welcomeMessageBytes = Encoding.ASCII.GetBytes(welcomeMessage);
                            clientSocket.Send(welcomeMessageBytes);
                            // Nhận và xử lý dữ liệu từ Client
                            while (true)
                            {
                                // Nhận dữ liệu
                                byte[] receiveBuffer = new byte[1024];
                                int bytesReceived = clientSocket.Receive(receiveBuffer);

                                // Kiểm tra xem Client đã ngắt kết nối hay chưa
                                if (bytesReceived == 0)
                                {
                                    // Client ngắt kết nối, thoát vòng lặp
                                    break;
                                }

                                // Chuyển đổi dữ liệu nhận được sang chuỗi và hiển thị lên ListBox
                                while (clientSocket.Connected)
                                {
                                    StringBuilder textBuilder = new StringBuilder("Telnet: ");
                                    do
                                    {
                                        bytesReceived = clientSocket.Receive(receiveBuffer);
                                        textBuilder.Append(Encoding.ASCII.GetString(receiveBuffer, 0, bytesReceived));
                                    } while (receiveBuffer[bytesReceived - 1] != '\n' && bytesReceived > 0);
                                    if (bytesReceived == 0)
                                    {
                                        break;
                                    }
                                    string text = textBuilder.ToString();
                                    lbTelnet.Invoke(new Action(() => lbTelnet.Items.Add(text)));
                                }
                            }

                            // Đóng kết nối với Client
                            clientSocket.Shutdown(SocketShutdown.Both);
                            clientSocket.Close();
                        }
                        catch (Exception ex)
                        {
                            Invoke(new Action(() => MessageBox.Show(ex.Message)));
                        }
                    });
                    // Bắt đầu thread xử lý kết nối của Client
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => MessageBox.Show(ex.Message)));
            }
        }
    }
}