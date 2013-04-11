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


                listView.Items.Add(new ListViewItem(new string[] { item.CourseId, item.CourseName, item.SectionNumber, item.Department, item.Instructor, item.StartTime.ToString("t"), item.EndTime.ToString("t") }));
            }

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
