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
        int random = 0;
        string classInfo = "";

        public ScheduleWidget(int r, string info)
        {
            random = r;
            classInfo = info;
            InitializeComponent();
        }

        private void ScheduleWidget_Load(object sender, EventArgs e)
        {
            Random r = new Random(random);

            List<string> locations = new List<string>();

            locations.Add("University Hall");
            locations.Add("South Hall");
            locations.Add("Hayes Hall");
            locations.Add("Education Building");


            labelLocation.Text = ((r.Next(1,3) * 100) + (r.Next(0,2) * 10) + (r.Next(1,4))).ToString() + " " + locations[r.Next(0,locations.Count)];

        }

        private void ScheduleWidget_Click(object sender, EventArgs e)
        {
            MessageBox.Show(classInfo + labelLocation.Text);
        }
    }
}
