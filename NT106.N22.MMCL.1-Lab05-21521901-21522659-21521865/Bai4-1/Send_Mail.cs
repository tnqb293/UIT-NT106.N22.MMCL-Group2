using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit.Text;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net;

namespace Bai4_1
{
    public partial class Send_Mail : Form
    {
        public Send_Mail()
        {
            InitializeComponent();
        }
        class Smtp
        {
            public string server { get; set; }
            public int port { get; set; }
        }
        Smtp smtp;
        private void btnSend_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            smtp = new Smtp();
            smtp.server = form.tbAddressSmtp.Text;
            smtp.port = Int32.Parse(form.tbPortSmtp.Value.ToString());
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string name = tbName.Text;
            string from = tbEmail.Text;
            string to = tbEmailTo.Text;
            var client = new SmtpClient();
            client.Connect(smtp.server, smtp.port);
            client.Authenticate(new NetworkCredential(email, password));
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(name, from));
            message.To.Add(new MailboxAddress("", to));
            message.Subject = tbSubject.Text;
            var builder = new BodyBuilder();
            if(IsHTML.Checked == true)
            {
                builder.HtmlBody = richTextBox1.Text;
                builder.Attachments.Add(tbFilePath.Text);
                message.Body = builder.ToMessageBody();
                client.Send(message);
            }
            else
            {
                builder.TextBody = richTextBox1.Text;
                builder.Attachments.Add(tbFilePath.Text);
                message.Body = builder.ToMessageBody();
                client.Send(message);
            }
            tbEmailTo.Clear();
            tbFilePath.Clear();
            tbSubject.Clear();
            tbName.Clear();
            
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = ofd.FileName;
            }
        }
    }
}
