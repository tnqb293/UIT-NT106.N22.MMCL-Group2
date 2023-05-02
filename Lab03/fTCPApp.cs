using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class fTCPApp : Form
    {
        public fTCPApp()
        {
            InitializeComponent();
        }

        private void btnTCPServer_Click(object sender, EventArgs e)
        {
            fTCPListener tcpListener = new fTCPListener();
            tcpListener.Show();
        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
            fTCPClient tcpClient = new fTCPClient();
            tcpClient.Show();
        }
    }
}
