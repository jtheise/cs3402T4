﻿using System;
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
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" });
            Program.GetParent().LoadScreen("DefaultNotification");
        }
    }
}
