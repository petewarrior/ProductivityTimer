using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Productivity
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
            versionLabel.Text = "Version: " + Application.ProductVersion;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://prodtimer.petewarrior.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
        }
    }
}
