using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtsenderPassword.UseSystemPasswordChar = true;
        }
        private void SEND_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các control trên giao diện
                string smtpServer = txtSmtpServer.Text;
                int port = int.Parse(txtPort.Text);
                string senderEmail = txtsenderEmail.Text;
                string senderPassword = txtsenderPassword.Text;
                string recipientEmail = txtRecipientEmail.Text;
                string subject = txtSubject.Text;
                string body = txtBody.Text;

                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage(senderEmail, recipientEmail, subject, body);

                // Tạo đối tượng SmtpClient
                SmtpClient smtpClient = new SmtpClient(smtpServer, port);

                // Thiết lập thông tin xác thực với Mail Server
                NetworkCredential credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.Credentials = credentials;

                // Bật SSL để sử dụng kết nối bảo mật
                smtpClient.EnableSsl = true;

                // Gửi email
                smtpClient.Send(mail);

                MessageBox.Show("Email đã được gửi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}