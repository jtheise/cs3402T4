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
    public partial class AddOrganizationScreen : UserControl
    {
        public AddOrganizationScreen()
        {
            InitializeComponent();
        }

        private void AddOrganizationScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}