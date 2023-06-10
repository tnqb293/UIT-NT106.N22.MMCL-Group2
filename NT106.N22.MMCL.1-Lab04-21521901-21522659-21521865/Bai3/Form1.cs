using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Windows.Forms;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace Bai3
{
    public partial class Form1 : Form
    {
        private Pop3Client pop3Client;
        private List<OpenPop.Mime.Message> messages;

        public Form1()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = true; // Ẩn mật khẩu khi nhập
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pop3Client = new Pop3Client();
        }

        // Phương thức xử lý sự kiện khi nút "Connect" được nhấn
        private void connectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối tới máy chủ POP3 với thông tin đã nhập
                pop3Client.Connect(serverTextBox.Text, int.Parse(PortTextBox.Text), true);
                pop3Client.Authenticate(usernameTextBox.Text, passwordTextBox.Text);

                // Lấy số lượng email trong hộp thư
                int messageCount = pop3Client.GetMessageCount();
                statusTextBox.Text = "Connected. " + messageCount + " messages in mailbox.";

                // Lấy các email gần đây nhất (50 email)
                int startIndex = Math.Max(1, messageCount - 50 + 1);
                int endIndex = messageCount;

                messages = new List<OpenPop.Mime.Message>();
                messageListBox.Items.Clear();

                // Lặp qua các email từ startIndex đến endIndex và hiển thị thông tin của mỗi email trong danh sách
                for (int i = startIndex; i <= endIndex; i++)
                {
                    OpenPop.Mime.Message email = pop3Client.GetMessage(i);
                    messages.Add(email);

                    // Lấy thông tin người gửi, thời gian gửi và tiêu đề email
                    string senderInfo = email.Headers.From.DisplayName ?? email.Headers.From.Address;
                    string dateInfo = email.Headers.DateSent.ToString("yyyy-MM-dd HH:mm");
                    string listItemText = string.Format("From: {0}, Date: {1}, Subject: {2}", senderInfo, dateInfo, email.Headers.Subject);

                    // Thêm thông tin email vào danh sách hiển thị trên giao diện
                    messageListBox.Items.Add(listItemText);
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Phương thức xử lý sự kiện khi nút "Disconnect" được nhấn
        private void disconnectionButton_Click(object sender, EventArgs e)
        {
            if (pop3Client.Connected)
            {
                // Ngắt kết nối POP3 và làm sạch danh sách email trên giao diện
                pop3Client.Disconnect();
                statusTextBox.Text = "Disconnected.";
                messageListBox.Items.Clear();
            }
        }

        // Phương thức xử lý sự kiện khi người dùng chọn một email trong danh sách
        private void messageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (messageListBox.SelectedIndex >= 0 && messageListBox.SelectedIndex < messages.Count)
            {
                int selectedIndex = messageListBox.SelectedIndex;
                OpenPop.Mime.Message selectedMessage = messages[selectedIndex];

                if (selectedMessage.MessagePart != null && selectedMessage.MessagePart.IsText)
                {
                    // Lấy nội dung email dạng văn bản
                    string bodyText = selectedMessage.MessagePart.GetBodyAsText();

                    if (bodyText != null)
                    {
                        // Hiển thị thông tin chi tiết của email trong hộp văn bản
                        messageTextBox.Text = "From: " + selectedMessage.Headers.From + Environment.NewLine +
                                               "To: " + selectedMessage.Headers.To + Environment.NewLine +
                                               "Subject: " + selectedMessage.Headers.Subject + Environment.NewLine +
                                               "Date: " + selectedMessage.Headers.Date + Environment.NewLine + Environment.NewLine +
                                               bodyText;
                    }
                    else
                    {
                        messageTextBox.Text = "Failed to retrieve the message body.";
                    }
                }
                else
                {
                    messageTextBox.Text = "The message does not contain a text body.";
                }
            }
        }
    }
}
