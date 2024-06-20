using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // we need this shit

namespace ZA_launcher_concept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // close program
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("..."); //link to website
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("..."); //link to website
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("..."); //link to website
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(@"..."); //za directory
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"..."); //file directory
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(@"..."); //file directory
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("..."); //link to website
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //not done yet bruh, open other form.cs
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open other form.cs
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open other form.cs
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
