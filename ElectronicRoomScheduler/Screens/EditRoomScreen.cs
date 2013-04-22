/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 * Add buildings Screen
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
    public partial class EditRoomScreen : UserControl
    {
        public EditRoomScreen()
        {
            InitializeComponent(); //load the screen
        }

        private void EditRoomScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill; //dock in panels
        }
    }
}
