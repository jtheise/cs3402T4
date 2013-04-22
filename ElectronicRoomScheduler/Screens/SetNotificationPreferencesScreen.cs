/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 * 
 * 
 * NOT YET IMPLIMENTED
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
    public partial class SetNotificationPreferencesScreen : UserControl
    {
        public SetNotificationPreferencesScreen()
        {
            InitializeComponent();
        }

        private void SetNotificationPreferencesScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // settings would be saved here

            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" });

            // settings are not actually saved. load new screen
            Program.GetParent().LoadScreen("DefaultNotification");
        }
    }
}
