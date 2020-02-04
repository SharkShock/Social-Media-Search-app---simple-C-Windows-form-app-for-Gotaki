using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gotaki_Search_Robot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(button1_Click);
            this.AcceptButton = button1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+facebook+" + textBox1.Text.Replace(' ', '+') );
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+instagram+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+twitter+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+google+plus+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+yelp+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+foursquare+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+tripadvisor+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+timeout+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+lonely+planet+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+orbitz+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+kayak+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+oyster.com+" + textBox1.Text.Replace(' ', '+'));
            Process.Start("chrome.exe", "https://www.google.rs/search?q=" + "+wotif+" + textBox1.Text.Replace(' ', '+'));


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
