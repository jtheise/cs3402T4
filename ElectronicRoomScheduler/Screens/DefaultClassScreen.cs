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
    public partial class DefaultClassScreen : UserControl
    {
        public DefaultClassScreen()
        {
            InitializeComponent();
        }

        private void DefaultClassScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            

            // add something to listview
            listView.Items.Clear();

            foreach (Class item in Program.GetParent().ClassList)
            {
                string classDays = "";
                if (item.Days != null)
                {
                    foreach (var day in item.Days)
                    {
                        if (day.Length != 3)
                            continue;

                        if (day == "Sun" || day == "Sat" || day == "Thu" || day == "Tue")
                            classDays += day.Substring(0, 2) + ","; // two characters
                        else
                            classDays += day.Substring(0,1) + ",";
                    }

                    classDays = classDays.TrimEnd(',').Trim();
                }
                listView.Items.Add(new ListViewItem(new string[] { item.CourseId, item.CourseName, item.SectionNumber, item.Department, item.Instructor, item.StartTime.ToString("t"), item.EndTime.ToString("t"), classDays }));
            }

            if (listView.Items.Count > 0)
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            else
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 1)
                return;

            Program.GetParent().ClassToLoad = listView.SelectedItems[0].Index;
            Program.GetParent().LoadScreen("EditClass");

        }
    }
}
