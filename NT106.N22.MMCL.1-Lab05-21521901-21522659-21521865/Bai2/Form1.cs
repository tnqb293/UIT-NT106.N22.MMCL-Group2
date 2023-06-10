using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private readonly string server = "imap.gmail.com"; // Địa chỉ IMAP server
        private readonly int port = 993; // Port của IMAP server
        private readonly bool useSsl = true; // Sử dụng SSL hay không

        private ImapClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "21521901@gm.uit.edu.com";
            string password = "Steingate;0";

            try
            {
                ConnectToServer(username, password);
                LoadEmails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc xác thực: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Không thực hiện kết nối và tải email tự động khi form được tải lần đầu vì cần chờ đăng nhập
        }

        private void ConnectToServer(string username, string password)
        {
            client = new ImapClient();
            client.Connect(server, port, useSsl);
            client.Authenticate(username, password);
        }

        private void LoadEmails()
        {
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            var query = SearchQuery.All;
            var uids = inbox.Search(query);

            foreach (var uid in uids)
            {
                var message = inbox.GetMessage(uid);

                string subject = message.Subject;
                string from = message.From.ToString();
                string date = message.Date.ToString();

                // Thêm thông tin email vào ListView
                ListViewItem item = new ListViewItem(subject);
                item.SubItems.Add(from);
                item.SubItems.Add(date);
                listViewEmail.Items.Add(item);
            }
        }
    }
}