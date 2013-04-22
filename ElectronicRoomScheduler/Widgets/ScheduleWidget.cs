/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Robert Risner
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

namespace ElectronicRoomScheduler.Widgets
{
    public partial class ScheduleWidget : UserControl
    {
        int random = 0; // holds the random class number
        string classInfo = ""; // string for the class infomation

        public ScheduleWidget(int r, string info)
        {
            random = r; // a random number is passed in for random number generator
            classInfo = info; // passed in class information
            InitializeComponent();
        }

        private void ScheduleWidget_Load(object sender, EventArgs e)
        {
            Random r = new Random(random);

            List<string> locations = new List<string>();

            // add these random buildings

            locations.Add("University Hall");
            locations.Add("South Hall");
            locations.Add("Hayes Hall");
            locations.Add("Education Building");

            // generate a random class number (student's schedule)
            labelLocation.Text = ((r.Next(1,3) * 100) + (r.Next(0,2) * 10) + (r.Next(1,4))).ToString() + " " + locations[r.Next(0,locations.Count)];

        }

        private void ScheduleWidget_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), "ClassWidget", "Click" });
            MessageBox.Show(classInfo + labelLocation.Text); // popup with class information
        }
    }
}
