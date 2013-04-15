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
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            // pick some random classes and events to add to the calendar....


            DateTime start = new DateTime(2013, 4, 15, 8, 0, 0);
            Random r = new Random((int)DateTime.Now.Ticks);

            List<string> ClassesAdded = new List<string>();
            int classAddCount = 0;
            List<int> RandomNumbers = new List<int>();
            
            
            // pull 3 random classes and 3 events to add to the student's schedule

            for (int i = 0; i < Program.GetParent().ClassList.Count; i++)
            {
                int random = -1;

                while (random == -1 || RandomNumbers.Contains(random))
                    random = r.Next(0, Program.GetParent().ClassList.Count);

                RandomNumbers.Add(random);
            }

            List<string> entries = new List<string>(210); // row number * columns + (column number (day of the week))

            for (int i = 0; i < 210; i++)
            {
                entries.Add("");
            }

            for (int i = 0; i < RandomNumbers.Count; i++)
            {
                ElectronicRoomScheduler.Classes.Class c = Program.GetParent().ClassList[RandomNumbers[i]];

                string Days = "";
                foreach (var item in c.Days)
                {
                    Days += item + " ";
                }

                Days = Days.Trim();

                string classinfo = "";
                classinfo += "Course Id: " + c.CourseId + "\r\n";
                classinfo += "Course Name: " + c.CourseName + "\r\n";
                classinfo += "Section Number: " + c.SectionNumber + "\r\n";
                classinfo += "Start Time: " + c.StartTime.ToString("hh:mm tt") + " End Time: " + c.EndTime.ToString("hh:mm tt") + "\r\n";
                classinfo += "Meeting Days: " + Days + "\r\n";
                classinfo += "Department: " + c.Department + "\r\n";
                classinfo += "Instructor: " + c.Instructor + "\r\n";


                Widgets.ScheduleWidget schdule = new Widgets.ScheduleWidget(r.Next(int.MaxValue), classinfo);
                schdule.labelName.Text = c.CourseName;
                schdule.labelTime.Text = c.StartTime.ToString("hh:mm tt") + " - " + c.EndTime.ToString("hh:mm tt") +"  " +  Days;

                flowLayoutPanel1.Controls.Add(schdule);


                int hour = (c.StartTime.Hour * 2) + (c.StartTime.Minute / 30) - 16;
                int hour_end = (c.EndTime.Hour * 2) + (c.EndTime.Minute / 30) - 15;

                for (int j = hour; j < hour_end; j++)
                {

                    foreach (var item in c.Days)
                    {
                        int dayNumber = 0;

                        if (item == "Mon")
                            dayNumber = 1;
                        if (item == "Tue")
                            dayNumber = 2;
                        if (item == "Wed")
                            dayNumber = 3;
                        if (item == "Thu")
                            dayNumber = 4;
                        if (item == "Fri")
                            dayNumber = 5;
                        if (item == "Sat")
                            dayNumber = 6;
                        if (item == "Sun")
                            dayNumber = 7;


                        if (j == hour)
                            entries[j * 6 + dayNumber] = c.CourseName;
                        else if (j == hour_end - 1 && (hour_end - hour) > 2)
                            entries[j * 6 + dayNumber] = c.EndTime.ToString("hh:mm tt");
                        else if (j == hour+1 && (hour_end - hour) > 2)
                            entries[j * 6 + dayNumber] = c.StartTime.ToString("hh:mm tt");
                        else if ((hour_end - hour) <= 2)
                            entries[j * 6 + dayNumber] = c.StartTime.ToString("hh:mm") + "-" + c.EndTime.ToString("hh:mm");
                        else 
                            entries[j * 6 + dayNumber] = "...";

                    }



                }

                if (i == 2)
                    break;
            }
            

            for (int i = 0; i < 31; i++)
            {
                ListViewItem item = new ListViewItem(start.ToString("hh:mm tt"));

                string result = entries[i * 6 + 1];
                string result2 = entries[i * 6+ 2];
                string result3 = entries[i * 6 + 3];
                string result4 = entries[i * 6 + 4];
                string result5 = entries[i * 6 + 5];
                string result6 = entries[i * 6 + 6];

                if (!string.IsNullOrWhiteSpace(result))
                {
                    item.SubItems.Add(result);
                    item.SubItems[1].BackColor = Color.Red;
                }
                else
                    item.SubItems.Add(result);

                if (!string.IsNullOrWhiteSpace(result2))
                {
                    item.SubItems.Add(result2);
                    item.SubItems[2].BackColor = Color.Red;
                }
                else
                    item.SubItems.Add(result2);

                if (!string.IsNullOrWhiteSpace(result3))
                {
                    item.SubItems.Add(result3);
                    item.SubItems[3].BackColor = Color.Red;
                }
                else
                    item.SubItems.Add(result3);


                if (!string.IsNullOrWhiteSpace(result4))
                {
                    item.SubItems.Add(result4);
                    item.SubItems[4].BackColor = Color.Red;
                }
                else
                    item.SubItems.Add(result4);

                if (!string.IsNullOrWhiteSpace(result5))
                {
                    item.SubItems.Add(result5);
                    item.SubItems[5].BackColor = Color.Red;
                }
                else
                    item.SubItems.Add(result5);

                if (!string.IsNullOrWhiteSpace(result6))
                {
                    item.SubItems.Add(result6);
                    item.SubItems[6].BackColor = Color.Red;
                }
                else
                    item.SubItems.Add(result6);

                item.UseItemStyleForSubItems = false;

                listView.Items.Add(item);

                start = start.AddMinutes(30);
            }

            

        }
    }
}
