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
        public EventsSidePanel()
        {
            InitializeComponent();
        }

        private void EventsSidePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("AddEvent");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // find the panel with the item selected....

            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            List<Control> controls = Program.GetParent().Controls.Find("DefaultEventScreen", true).ToList();

            if (controls.Count == 1)
                Program.GetParent().LoadScreen("EditEvent|" + ((Screens.DefaultEventScreen)controls[0]).SelectedIndex.ToString());


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });

            List<Control> controls = Program.GetParent().Controls.Find("DefaultEventScreen", true).ToList();

            if (controls.Count == 1)
                Program.GetParent().LoadScreen("DeleteEvent|" + ((Screens.DefaultEventScreen)controls[0]).SelectedIndex.ToString());

        }

        private void labelHeader_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((LinkLabel)sender).Text, "Click" });
            Program.GetParent().LoadScreen("DefaultEvent");
        }
    }
}
