using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab04
{
    public partial class fBai2 : Form
    {
        public fBai2()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (tbURL.Text.Trim() == "" || tbLink.Text.Trim() == "")
            {
                MessageBox.Show("Please input URL", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WebClient webClient = new WebClient();

            try
            {
                webClient.DownloadFile(tbURL.Text, tbLink.Text);
                byte[] response_info = webClient.DownloadData(tbURL.Text);
                rtbDisplay.Text = Encoding.UTF8.GetString(response_info);
            }
            catch (WebException webException)
            {
                rtbDisplay.Text = webException.Message;
            }
        }
    }
}
