using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Lab04
{
    public partial class fBai5 : Form
    {
        public fBai5()
        {
            InitializeComponent();
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            string url = tbURL.Text;
            var data = new
            {
                username = tbUsername.Text,
                password = tbPass.Text
            };
            string json = JsonConvert.SerializeObject(data);
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsync(url, stringContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
            rtbDisplay.Text = jsonObject.token;
        }

        private void fBai5_Load(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
        }
    }
}
