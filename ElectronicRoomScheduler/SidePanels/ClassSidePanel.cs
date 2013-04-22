/* CS 3240 Electronic Room Scheduler
 * Coded: Rob Risner
 * Commented: KJ Jablonowski
 * Due: 4/22/2013
 * Class Side Menu
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
    public partial class ClassSidePanel : UserControl
    {
        //create menu panel
        public ClassSidePanel()
        {
            InitializeComponent();
        }

        //Add Class link function
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("AddClass");
        }

        //Use class data to populate Edit Class screen
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data

            List<Control> controls = Program.GetParent().Controls.Find("DefaultClassScreen", true).ToList();

            //find class data for selected class in default class screen list
            if (controls.Count == 1)
            {
                if (((Screens.DefaultClassScreen)controls[0]).listView.SelectedItems.Count == 1)
                    Program.GetParent().ClassToLoad = ((Screens.DefaultClassScreen)controls[0]).listView.SelectedItems[0].Index;
                else
                    Program.GetParent().ClassToLoad = -1;
            }
            else
                Program.GetParent().ClassToLoad = -1;
            
            //load Edit Class
            Program.GetParent().LoadScreen("EditClass");
        }

        //load class menu panel
        private void ClassSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            //prevent student log-ins from assigning and editing rooms
            if (Program.GetParent().LoggedInUser == "student")
            {
                linkLabelAssignRooms.Visible = false;
                linkLabelEditRooms.Visible = false;
            }


        }

        //Assign Room link function
        private void linkLabelAssignRooms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("AssignRoom");
        }

        //Edit Room link function
        private void linkLabelEditRooms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("EditRoom");
        }

        //use class data to delete class
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data

            List<Control> controls = Program.GetParent().Controls.Find("DefaultClassScreen", true).ToList();

            //find class data from default class screen
            if (controls.Count == 1)
            {
                if (((Screens.DefaultClassScreen)controls[0]).listView.SelectedItems.Count == 1)
                    Program.GetParent().ClassToLoad = ((Screens.DefaultClassScreen)controls[0]).listView.SelectedItems[0].Index;
                else
                    Program.GetParent().ClassToLoad = -1;
            }
            else
                Program.GetParent().ClassToLoad = -1;

            //Delete Class link function
            Program.GetParent().LoadScreen("DeleteClass");
        }

        //Manage Classes link function
        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Label)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("DefaultClass");
        }

        //AutoAssign Rooms link function
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); //save log data
            Program.GetParent().LoadScreen("AutoAssignRooms");
        }
    }
}
