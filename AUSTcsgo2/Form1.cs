using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUSTcsgo2
{
    public partial class Form1 : Form
    {
        WebBrowser wb = new WebBrowser();
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wb2.Navigate("http://steamcommunity.com/login/home");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wb2.Document.GetElementById("steamAccountName").InnerText = textBox1.Text;
            wb2.Document.GetElementById("steamPassword").InnerText = textBox2.Text;
            wb2.Document.GetElementById("SteamLogin").InvokeMember("click");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wb2.Document.GetElementById("authCode").InnerText = textBox3.Text;
            wb2.Document.GetElementById("twofactorcode_entry").InnerText = textBox3.Text;
            HtmlElementCollection classButton = wb2.Document.All;
            foreach (HtmlElement element in classButton)
            {
                if (element.GetAttribute("className") == "auth_button leftbtn")
                {
                    element.InvokeMember("click");
                }
            }

        }
    }
}
