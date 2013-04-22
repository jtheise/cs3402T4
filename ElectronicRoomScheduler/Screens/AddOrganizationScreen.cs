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
    public partial class AddOrganizationScreen : UserControl
    {
        public AddOrganizationScreen()
        {
            InitializeComponent(); //load the screen
        }

        private void AddOrganizationScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill; //dock it in the panels
        }
    }
}
