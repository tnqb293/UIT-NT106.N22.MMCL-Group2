using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string host { get; set; }
        private string user { get; set; }
        private string password { get; set; }
        public string pathFile { get; set; }
        private FtpWebRequest ftpRequest { get; set; }
        private FtpWebResponse ftpResponse { get; set; }
        private Stream ftpStream  { get; set; }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tên tập tin", typeof(string));
            try
            {
                user = tbUsername.Text;
                password = tbPassword.Text;
                host = tbIpAddr.Text;
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + '/' + "shared/");
                ftpRequest.Credentials = new NetworkCredential(user, password);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                StreamReader reader = new StreamReader(ftpStream);
                string line = reader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    string fileName = line;
                    dataTable.Rows.Add(fileName);
                    line = reader.ReadLine();
                }
                dgvRemoteControls.DataSource = dataTable;
                reader.Close();
            }
            catch(WebException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                ftpStream.Close();
                ftpResponse.Close();
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                byte[] fileData = File.ReadAllBytes(ofd.FileName);
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + '/' + "shared/" + ofd.SafeFileName);
                ftpRequest.Credentials = new NetworkCredential(user, password);
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.UseBinary = true;
                using (Stream requestStream = ftpRequest.GetRequestStream())
                {
                    requestStream.Write(fileData, 0, fileData.Length);
                }
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                MessageBox.Show("Tải lên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                ftpStream.Close();
                ftpResponse.Close();
            }
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = dgvRemoteControls.CurrentCell.Value.ToString();
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.ShowDialog();
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + '/' + "shared/" + fileName);
                ftpRequest.Credentials = new NetworkCredential(user, password);
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                using (Stream responseStream = ftpResponse.GetResponseStream())
                {
                    using (FileStream fileStream = new FileStream(ofd.FileName, FileMode.Create))
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, bytesRead);
                        }
                    }
                }
                MessageBox.Show("Tải file thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                ftpResponse.Close();
            }

        }
    }
}
