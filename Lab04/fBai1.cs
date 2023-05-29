using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using static System.Windows.Forms.LinkLabel;

namespace Lab04
{
    public partial class fBai1 : Form
    {
        public fBai1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (tbURL.Text.Trim() == "")
            {
                MessageBox.Show("Please input URL", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            rtbResult.Text = getHTML(tbURL.Text);
        }

        public string getHTML (string url)
        {
            string bodyText = "";
            HttpWebRequest httpRequest = (HttpWebRequest) WebRequest.Create(tbURL.Text);
            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            Stream responseStream = httpResponse.GetResponseStream();
            Byte[] receiveBytes = new byte[Byte.MaxValue];
            Int32 bytes;
            while(true)
            {
                bytes = responseStream.Read(receiveBytes, 0, receiveBytes.Length);
                if (bytes <= 0) break;
                bodyText = bodyText + Encoding.UTF8.GetString(receiveBytes);
            }
            responseStream.Close();
      
            return bodyText;
        }
    }
}

/*
StreamReader responseReader = new StreamReader(responseStream);
string bodyText = responseReader.ReadToEnd();
 */
