/* CS 3240 Electronic Room Scheduler
 * Coded: Rob Risner
 * Commented: KJ Jablonowski
 * Due: 4/22/2013
 * Organizations Side Menu
 */

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
        //create side panel
        public OrganizationsSidePanel()
        {
            InitializeComponent();
        }

        //fill side panel menu
        private void OrganizationsSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        //Add Organization link function
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("AddOrganization");
        }

        //Edit Organization link function
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("EditOrganization");
        }

        //Delete Organization link function
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("DeleteOrganization");
        }

        //Manage Organizations link function
        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Label)sender).Text, "Click" }); //save log function
            Program.GetParent().LoadScreen("DefaultOrganization");
        }
    }
}
