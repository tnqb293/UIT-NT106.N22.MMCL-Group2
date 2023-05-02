using System;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}