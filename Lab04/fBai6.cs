using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class fBai6 : Form
    {
        private int progressValue = 0;

        public fBai6()
        {
            InitializeComponent();
            webView.NavigationCompleted += WebView_NavigationCompleted;
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            string url = tbURL.Text;
            await webView.EnsureCoreWebView2Async(null);

            // Đặt giá trị ProgressBar về 0
            progressValue = 0;
            progressBar.Value = progressValue;

            webView.CoreWebView2.Navigate(url);
        }

        private void fBai6_Load(object sender, EventArgs e)
        {
            
        }

        private void lvWeb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // Cập nhật giá trị tiến trình
            progressValue = 100;
            progressBar.Value = progressValue;

            tbURL.Text = webView.CoreWebView2.Source;
        }
    }
}
