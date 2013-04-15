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
    public partial class OrganizationsSidePanel : UserControl
    {
        public OrganizationsSidePanel()
        {
            InitializeComponent();
        }

        private void OrganizationsSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("AddOrganization");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("EditOrganization");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("DeleteOrganization");
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("DefaultOrganization");
        }
    }
}
