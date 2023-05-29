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
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http;
using Newtonsoft.Json;

namespace Lab04
{
    public partial class fBai4 : Form
    {
        public fBai4()
        {
            InitializeComponent();
        }

        data.pageInfo json = null;

        private void fBai3_Load(object sender, EventArgs e)
        {
            lbPage.Text = string.Empty;
            lbTotalPage.Text = string.Empty;
            lbTotalUsers.Text = string.Empty;
            lbUsers.Text = string.Empty;
            Net(null, null);
            tbNum.ReadOnly = true;
            tbNum.TextAlign = HorizontalAlignment.Center;
            tbNum.Text = "1";
        }

        private HttpClient httpClient = new HttpClient();
        private async void Net(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://reqres.in/api/users?page=1").ConfigureAwait(false);
                string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                BeginInvoke((Action)(() =>
                {
                    json = JsonConvert.DeserializeObject<data.pageInfo>(responseString);
                    lbPage.Text = json.page.ToString();
                    lbTotalPage.Text = json.total_pages.ToString();
                    lbUsers.Text = json.per_page.ToString();
                    lbTotalUsers.Text = json.total.ToString();
                    ShowInfo(0, json);
                }));
            }
            catch (HttpRequestException ex)
            {
                BeginInvoke((Action)(() =>
                {
                    MessageBox.Show(ex.Message);
                }));
            }
        }
        void ShowInfo(int i, data.pageInfo json)
        {

            lbName.Text = json.data[i].first_name.ToString() + " " + json.data[i].last_name.ToString();

            lbEmail.Text = json.data[i].email.ToString();
            ptbAvatar.ImageLocation = json.data[i].avatar.ToString();
            if (i == 0) { btnBack.Enabled = false; }
            else {btnBack.Enabled = true; }
            if (i == json.per_page - 1) {btnNext.Enabled = false; }
            else {btnNext.Enabled = true; }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tbNum.Text = (Int32.Parse(tbNum.Text) - 1).ToString();
            ShowInfo(Int32.Parse(tbNum.Text) - 1, json);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbNum.Text = (Int32.Parse(tbNum.Text) + 1).ToString();
            ShowInfo(Int32.Parse(tbNum.Text) - 1, json);
        }

        private void ptbAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
