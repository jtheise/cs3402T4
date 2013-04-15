using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElectronicRoomScheduler.SidePanels
{
    public partial class ReportsSidePanel : UserControl
    {
        public ReportsSidePanel()
        {
            InitializeComponent();
        }

        private void ReportsSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("NewReport");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("LoadReport");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("EditReport");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("AddQuestion");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("LoadQuestion");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("EditQuestion");
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("DefaultReport");
        }
    }
}
