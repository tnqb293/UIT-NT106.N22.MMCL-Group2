using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net;
using MailKit.Net.Imap;
using MailKit.Search;
namespace Bai4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Imap
        {
            public string server { get; set; }
            public int port { get; set; }
            public int limit = 10;
        }
        public class Account
        {
            public string username { get; set; }
            public string password { get; set; }
        }
        Account account { get; set; }
        Imap imap { get; set; }
        ImapClient client { get; set; }
        IMailFolder inbox { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                account = new Account();
                imap = new Imap();
                imap.server = tbAddressImap.Text;
                imap.port = Int32.Parse(tbPortImap.Value.ToString());
                account.username = tbUsername.Text;
                account.password = tbPassword.Text;
                client = new ImapClient();
                client.Connect(imap.server, imap.port);
                client.Authenticate(account.username, account.password);
                inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var query = SearchQuery.DeliveredAfter(DateTime.Now.AddDays(-7));
                var messages = inbox.Search(query);

                foreach (var uid in messages)
                {
                    var message = inbox.GetMessage(uid);
                    ListViewItem item = new ListViewItem(uid.ToString());
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Subject.ToString());
                    item.SubItems.Add(message.Date.ToString());
                    listView1.Items.Add(item);
                }
                btnLogin.Visible = false;
                btnLogOff.Visible = true;
                btnRefresh.Visible = true;
                btnSendMail.Visible = true;
                tbUsername.Enabled = false;
                tbPassword.Enabled = false;
                gbSetting.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Email không tồn tại hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại");
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                var query = SearchQuery.DeliveredOn(DateTime.Parse(item.SubItems[3].Text));
                var uid = inbox.Search(query);
                var message = inbox.GetMessage(uid[0]);
                ReadEmail form = new ReadEmail();
                form.lbFrom.Text = message.From.ToString();
                form.lbTo.Text = message.To.ToString();
                form.lbTitleEmail.Text = message.Subject.ToString();
                form.webBrowser1.DocumentText = message.HtmlBody;  
                form.ShowDialog();
            }
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            client.Disconnect(true);
            listView1.Items.Clear();
            btnLogin.Visible = true;
            btnLogOff.Visible = false;
            btnRefresh.Visible = false;
            btnSendMail.Visible = false;
            tbUsername.Enabled = true;
            tbPassword.Enabled = true;
            gbSetting.Enabled = true;
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var query = SearchQuery.DeliveredAfter(DateTime.Now.AddDays(-7));
            var messages = inbox.Search(query);
            foreach (var uid in messages)
            {
                var message = inbox.GetMessage(uid);
                ListViewItem item = new ListViewItem(uid.ToString());
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Subject.ToString());
                item.SubItems.Add(message.Date.ToString());
                listView1.Items.Add(item);
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            Send_Mail form = new Send_Mail();
            form.tbEmail.Text = account.username;
            form.tbPassword.Text = account.password;
            form.ShowDialog();
        }
    }
}
