/* CS 3240 Electronic Room Scheduler
 * Coded: Rob Risner
 * Commented: KJ Jablonowski
 * Due: 4/22/2013
 * Reports Side Menu
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
    public partial class ReportsSidePanel : UserControl
    {
        //create side panel
        public ReportsSidePanel()
        {
            InitializeComponent();
        }

        //fill panel with menu
        private void ReportsSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        //new Report link function
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("NewReport");
        }

        //Load Report link function
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("LoadReport");
        }

        //Edit Report link function
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("EditReport");
        }

        //Add Question link function
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("AddQuestion");
        }

        //Load Question link function
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("LoadQuestion");
        }

        //Edit Question link function
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("EditQuestion");
        }

        //Manage Reports link function
        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Label)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("DefaultReport");
        }
    }
}
