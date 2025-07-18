using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPSecurityCenter
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://go.microsoft.com/fwlink/?LinkId=33575");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://go.microsoft.com/fwlink/?LinkId=21940");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://go.microsoft.com/fwlink/?LinkId=21941");
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://go.microsoft.com/fwlink/?LinkId=33575");
        }

        private void Option3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("inetcpl.cpl");
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-settings:firewall");
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ms-settings:windowsupdate");
        }
    }
}
