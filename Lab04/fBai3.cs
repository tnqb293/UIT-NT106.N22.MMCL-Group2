using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class fBai3 : Form
    {
        public fBai3()
        {
            InitializeComponent();
            webView.NavigationCompleted += WebView_NavigationCompleted;
        }

        static string html { get; set; }

        private void fBai3_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate(url);
        }

        private void btnHtmlDown_Click(object sender, EventArgs e)
        {
            html = webView.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML").Result;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML files (*.html)|*.html";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(html);
                }
            }
        }

        private void btnSourceDown_Click(object sender, EventArgs e)
        {
            string url = webView.CoreWebView2.Source;
            string html = webView.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML").Result;

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);

            WebClient webClient = new WebClient();

            foreach (HtmlNode node in document.DocumentNode.DescendantsAndSelf())
            {
                if (node.Name == "img")
                {
                    string imageUrl = node.GetAttributeValue("src", "");
                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        string fileName = Path.GetFileName(imageUrl);
                        webClient.DownloadFile(imageUrl, fileName);
                    }
                }
            }
        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            txtURL.Text = webView.CoreWebView2.Source;
        }
    }
}
