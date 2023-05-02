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
using System.Net.Sockets;
using System.Threading;

namespace Lab03
{
    public partial class fIndex : Form
    {
        public fIndex()
        {
            InitializeComponent();
           
            
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            fUDPApp fBai1 = new fUDPApp();
            fBai1.Show();

        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            fTCPTelnetServer fBai2 = new fTCPTelnetServer();
            fBai2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            fTCPApp fBai3 = new fTCPApp();
            fBai3.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            fChatRoom fBai4 = new fChatRoom();
            fBai4.Show();
        }
    }

    


}
