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
    public partial class RoomsSidePanel : UserControl
    {
        public RoomsSidePanel()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.GetParent().LoadScreen("AddRoom");
        }

        private void RoomsSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.GetParent().LoadScreen("EditRoom");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.GetParent().LoadScreen("DeleteRoom");
        }

        private void linkLabelRequestTech_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.GetParent().LoadScreen("RequestTech");
        }
    }
}
