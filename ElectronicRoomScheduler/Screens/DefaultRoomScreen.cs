﻿/***************************************************
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
    public partial class DefaultRoomScreen : UserControl
    {
        public DefaultRoomScreen()
        {
            InitializeComponent(); //load the screen
        }

        private void DefaultRoomScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill; //dock in the panels
        }
    }
}
