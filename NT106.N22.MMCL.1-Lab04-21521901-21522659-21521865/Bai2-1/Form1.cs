using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Imap
        {
            public readonly string server = "imap.gmail.com";
            public readonly int port = 993;
            public readonly int limit = 20;
        }
        class Pop3
        {
            public readonly string server = "pop.gmail.com";
            public readonly int port = 995;
            public readonly int limit = 20;
        }
        class Account
        {
            public string username { get; set; }
            public string password { get; set; }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Account account = new Account();
                Imap imap = new Imap();
                account.username = tbEmail.Text;
                account.password = tbPassword.Text;
                var client = new ImapClient();
                client.Connect(imap.server, imap.port);
                client.Authenticate(account.username, account.password);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                int i;
                for(i = 0; i < imap.limit; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem item = new ListViewItem(message.Subject.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    listView1.Items.Add(item);
                }
                lbTotal.Text = i.ToString();
                //client.Disconnect(true);
            }
            catch
            {
                MessageBox.Show("Email không tồn tại hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại");
            }
        }

        private void btnLoginPop_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Account account = new Account();
                Pop3 pop3 = new Pop3();
                account.username = tbEmail.Text;
                account.password = tbPassword.Text;
                var client = new Pop3Client();
                client.Connect(pop3.server, pop3.port);
                client.Authenticate(account.username, account.password);
                int i;
                for(i = 0; i < pop3.limit; i++)
                {
                    var message = client.GetMessage(i);
                    ListViewItem item = new ListViewItem(message.Subject.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    listView1.Items.Add(item);
                }    
            }
            catch
            {
                MessageBox.Show("Email không tồn tại hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại");
            }
        }
    }
}
