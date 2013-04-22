/* CS 3240 Electronic Room Scheduler
 * Coded: Rob Risner
 * Commented: KJ Jablonowski
 * Due: 4/22/2013
 * Building Side Menu
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
    public partial class BuildingsSidePanel : UserControl
    {
        //create menu panel
        public BuildingsSidePanel()
        {
            InitializeComponent();
        }

        //Add Building link function
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Name, "Click" }); //save log data
            Program.GetParent().LoadScreen("AddBuilding");
        }

        //Edit Building link function
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Name, "Click" }); //save log data
            Program.GetParent().LoadScreen("EditBuilding");
        }

        //Delete Building link function
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Name, "Click" }); //save log data
            Program.GetParent().LoadScreen("DeleteBuilding");
        }

        //load the Building panel
        private void BuildingsSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        //Manage Buildings link function
        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.GetParent().LoadScreen("DefaultBuilding");
        }
    }
}
