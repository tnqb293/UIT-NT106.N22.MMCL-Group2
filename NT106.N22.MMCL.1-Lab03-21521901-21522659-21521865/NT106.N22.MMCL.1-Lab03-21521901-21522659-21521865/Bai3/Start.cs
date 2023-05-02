namespace Bai3
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void OpenServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void NewClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}