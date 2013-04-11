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
            Program.GetParent().LoadScreen("AddClass");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
            Program.GetParent().LoadScreen("AssignRoom");
        }

        private void linkLabelEditRooms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.GetParent().LoadScreen("EditRoom");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.GetParent().LoadScreen("DeleteClass");
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.GetParent().LoadScreen("DefaultClass");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.GetParent().LoadScreen("AutoAssignRooms");
        }
    }
}
