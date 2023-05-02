using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ApplicationCallAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void CallAPI_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    rtbAPI.Text = responseBody;
                }
                catch (HttpRequestException ex)
                {
                    rtbAPI.Text = "Error: " + ex.Message;
                }
            }
        }

        private void DeleteAPI_Click(object sender, EventArgs e)
        {
            rtbAPI.Clear();
        }
    }
}