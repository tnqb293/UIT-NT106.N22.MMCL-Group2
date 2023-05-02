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
    public partial class fUDPApp : Form
    {
        public fUDPApp()
        {
            InitializeComponent();
        }

        private void btnUDPServer_Click(object sender, EventArgs e)
        {
            fUDPServer udpServer = new fUDPServer();
            udpServer.Show();
        }

        private void btnUDPClient_Click(object sender, EventArgs e)
        {
            fUDPClient udpClient = new fUDPClient();    
            udpClient.Show();
        }

        private void fUDPApp_Load(object sender, EventArgs e)
        {

        }
    }
}
