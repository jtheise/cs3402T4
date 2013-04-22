/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 *
 * 
 * 
 * Screen to add a class to a room
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
    public partial class AssignRoomScreen : UserControl
    {
        public AssignRoomScreen()
        {
            InitializeComponent(); //load the screen
        }

        private void AssignRoomScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill; //dock it to the panel
            comboBoxClass.Select();     //set the combobox as the selected field

            comboBoxBuilding.Enabled = false;
            comboBoxRooms.Enabled = false;
            buttonAssign.Enabled = false;


            // load classes
            comboBoxClass.Items.Add("");

            foreach (var item in Program.GetParent().ClassList)
            {
                int index = comboBoxClass.Items.Add(item.CourseId + ": " + item.CourseName);
                
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e) //on change enable other boxes
        {
            if (comboBoxClass.SelectedIndex > 0)
                comboBoxBuilding.Enabled = true;
            else
                comboBoxBuilding.Enabled = false;
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" });
        }
    }
}
