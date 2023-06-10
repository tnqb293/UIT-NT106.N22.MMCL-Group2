using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Security;
using MailKit.Net.Smtp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MimeKit;
using MimeKit.Text;

namespace Bai1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string SMTPHost = "smtp.gmail.com";
        private static int SMTPPort = 465;

        class Account
        {
            public string username { get; set;}
            public string password { get; set;}
        }
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new Account();
                account.username = tbEmailSend.Text;
                account.password = tbPassword.Text;
                var client = new SmtpClient();
                client.Connect(SMTPHost, SMTPPort, true);
                client.Authenticate(account.username, account.password);
                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(tbEmailSend.Text));
                message.To.Add(MailboxAddress.Parse(tbEmailReceive.Text));
                message.Subject = tbSubject.Text;
                message.Body = new TextPart(TextFormat.Html)
                {
                    Text = tbBody.Text,
                };
                client.Send(message);
                MessageBox.Show($"Gửi tin nhắn đến email {tbEmailReceive.Text} thành công.");
            }
            catch
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng. Vui lòng kiểm tra lại");
            }
        }
    }
}
