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
        public ClassSidePanel()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" }); 
            Program.GetParent().LoadScreen("AddClass");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });

            List<Control> controls = Program.GetParent().Controls.Find("DefaultClassScreen", true).ToList();

            if (controls.Count == 1)
            {
                if (((Screens.DefaultClassScreen)controls[0]).listView.SelectedItems.Count == 1)
                    Program.GetParent().ClassToLoad = ((Screens.DefaultClassScreen)controls[0]).listView.SelectedItems[0].Index;
                else
                    Program.GetParent().ClassToLoad = -1;
            }
            else
                Program.GetParent().ClassToLoad = -1;
            
            Program.GetParent().LoadScreen("EditClass");
        }

        private void ClassSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            if (Program.GetParent().LoggedInUser == "student")
            {
                linkLabelAssignRooms.Visible = false;
                linkLabelEditRooms.Visible = false;
            }


        }

        private void linkLabelAssignRooms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("AssignRoom");
        }

        private void linkLabelEditRooms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("EditRoom");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });




            List<Control> controls = Program.GetParent().Controls.Find("DefaultClassScreen", true).ToList();



            if (controls.Count == 1)
            {
                if (((Screens.DefaultClassScreen)controls[0]).listView.SelectedItems.Count == 1)
                    Program.GetParent().ClassToLoad = ((Screens.DefaultClassScreen)controls[0]).listView.SelectedItems[0].Index;
                else
                    Program.GetParent().ClassToLoad = -1;
            }
            else
                Program.GetParent().ClassToLoad = -1;

            Program.GetParent().LoadScreen("DeleteClass");
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Label)sender).Text, "Click" });
            Program.GetParent().LoadScreen("DefaultClass");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("AutoAssignRooms");
        }
    }
}
