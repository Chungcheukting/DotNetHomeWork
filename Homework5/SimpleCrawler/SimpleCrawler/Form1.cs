using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimpleCrawler
{
    public partial class Form1 : Form
    {
        SimpleCrawler sc = new SimpleCrawler();

        public Form1()
        {
            InitializeComponent();
            sc.PageDownloaded += Crawler_PageDownloaded;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            sc.StartURL = textBox1.Text;
            listBox1.Items.Clear();
            new Thread(sc.startCrawl).Start();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Crawler_PageDownloaded(string url)
        {
            if (this.listBox1.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { url });
            }
            else
            {
                AddUrl(url);
            }
        }

        private void AddUrl(string url)
        {
            listBox1.Items.Add(url);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
