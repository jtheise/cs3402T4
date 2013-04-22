/* CS 3240 Electronic Room Scheduler
 * Coded: Rob Risner
 * Commented: KJ Jablonowski
 * Due: 4/22/2013
 * Event Side Menu
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
    public partial class EventsSidePanel : UserControl
    {
        //create menu panel
        public EventsSidePanel()
        {
            InitializeComponent();
        }

        //fill panel with menu options
        private void EventsSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            linkLabelEditEvent.Visible = false;     //Edit Event and Delete Event
            linkLabelDeleteEvent.Visible = false;   //not visible until an event is selected
        }

        //Add Event link function
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("AddEvent");
        }

        //Edit Event link function
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // find the panel with the item selected....

            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            List<Control> controls = Program.GetParent().Controls.Find("DefaultEventScreen", true).ToList();

            if (controls.Count == 1)
                Program.GetParent().LoadScreen("EditEvent|" + ((Screens.DefaultEventScreen)controls[0]).SelectedIndex.ToString());
        }

        //Delete Event link function
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data

            List<Control> controls = Program.GetParent().Controls.Find("DefaultEventScreen", true).ToList();

            if (controls.Count == 1)
                Program.GetParent().LoadScreen("DeleteEvent|" + ((Screens.DefaultEventScreen)controls[0]).SelectedIndex.ToString());

        }

        //Manage Events link function
        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Label)sender).Text, "Click" });
            Program.GetParent().LoadScreen("DefaultEvent");
        }
    }
}
