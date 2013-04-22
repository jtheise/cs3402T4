/* CS 3240 Electronic Room Scheduler
 * Coded: Rob Risner
 * Commented: KJ Jablonowski
 * Due: 4/22/2013
 * Notification Side Menu
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
    public partial class NotificationsSidePanel : UserControl
    {
        //create notification menu
        public NotificationsSidePanel()
        {
            InitializeComponent();
        }

        //fill notification menu
        private void NotificationsSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        //Add Notification link function
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("AddNotification");
        }

        //Edit Notification link function
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("EditNotification");
        }

        //Set Notification Preferences link function
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("SetNotificationPreferences");
        }

        //Manage Notifications link function
        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Label)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("DefaultNotification");
        }
    }
}
