/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 *
 * 
 * Delete Events screen
 * *************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElectronicRoomScheduler.Screens
{
    public partial class DeleteEventScreen : UserControl
    {
        public int LoadedId { get; set; }
        public DeleteEventScreen(int EventId)
        {
            InitializeComponent();
            LoadedId = EventId;
        }

        private void DeleteEventScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            //load the event

            labelMsg.Text = labelMsg.Text.Replace("%0", Program.GetParent().EventList[LoadedId].Name);

            List<Control> controls = Program.GetParent().Controls.Find("EventsSidePanel", true).ToList();

            if (controls.Count != 1)
                return;

            SidePanels.EventsSidePanel sidePanel = ((SidePanels.EventsSidePanel)controls[0]);

            sidePanel.linkLabelEditEvent.Visible = false;
            sidePanel.linkLabelDeleteEvent.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); //log data

            //delete the event
            Program.GetParent().EventList.RemoveAt(LoadedId);

            MessageBox.Show("Event was deleted successfully. If the notify checkbox was selected, notifications have been sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Program.GetParent().LoadScreen("DefaultEvent");



        }
    }
}
