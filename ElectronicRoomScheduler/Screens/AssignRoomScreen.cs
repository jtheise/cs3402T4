

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
            InitializeComponent();
        }

        private void AssignRoomScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            comboBoxClass.Select();

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

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
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
