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
    public partial class AddClassScreen : UserControl
    {
        public AddClassScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hasErrors = false;


            if (string.IsNullOrWhiteSpace(textBoxCourseId.Text) || textBoxCourseId.Text.Length < 2 || textBoxCourseId.Text.Length > 20)
            {
                errorProvider1.SetError(textBoxCourseId, "Course ID must be between 2 and 20 characters.");
                hasErrors = true;
            }


            if (string.IsNullOrWhiteSpace(textBoxCourseName.Text) || textBoxCourseName.Text.Length < 2 || textBoxCourseName.Text.Length > 40)
            {
                errorProvider1.SetError(textBoxCourseName, "Course name must be between 2 and 40 characters.");
                hasErrors = true;
            }


            if (string.IsNullOrWhiteSpace(textBoxDepartment.Text) || textBoxDepartment.Text.Length < 2 || textBoxDepartment.Text.Length > 40)
            {
                errorProvider1.SetError(textBoxDepartment, "Department must be between 2 and 40 characters.");
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(textBoxInstructor.Text) || textBoxInstructor.Text.Length < 2 || textBoxInstructor.Text.Length > 40)
            {
                errorProvider1.SetError(textBoxInstructor, "Instructor's name must be between 2 and 40 characters.");
                hasErrors = true;
            }

            TimeSpan ts = dateTimePickerEndTime.Value - dateTimePickerStartTime.Value;

            if (ts.TotalMinutes < 10 || ts.TotalMinutes > 300)
            {
                errorProvider1.SetError(dateTimePickerStartTime, "The length of the class must be between 10 minutes and 5 hours.");
                errorProvider1.SetError(dateTimePickerEndTime, "The length of the class must be between 10 minutes and 5 hours.");
                hasErrors = true;
            }

            List<string> days = new List<string>();
            foreach (var item in checkedListBoxClassDays.CheckedItems)
            {
                days.Add(item.ToString());
            }
            bool dupID = false;
            foreach (var item in Program.GetParent().ClassList)
                if (item.CourseId.Trim().ToLower() == textBoxCourseId.Text.Trim().ToLower())
                    dupID = true;

            if (dupID)
            {
                errorProvider1.SetError(textBoxCourseId, "Course ID already exists.");
                hasErrors = true;
            }

            if (days.Count == 0)
            {
                errorProvider1.SetError(checkedListBoxClassDays, "Must select at least one day for the class.");
                hasErrors = true;
            }

            if (hasErrors)
                return;


            // insert the class into the list....


            Class c = new Class();
            c.CourseId = textBoxCourseId.Text;
            c.CourseName = textBoxCourseName.Text;
            c.Department = textBoxDepartment.Text;
            c.EndTime = dateTimePickerEndTime.Value;
            c.StartTime = dateTimePickerStartTime.Value;
            c.SectionNumber = textBoxSection.Text;
            c.Instructor = textBoxInstructor.Text;

            c.Days = days;
            Program.GetParent().ClassList.Add(c);

            DialogResult dr = MessageBox.Show("The class was successfully added.\r\n\r\nDo you want to add another class?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
                Program.GetParent().LoadScreen("AddClass");
            else
                Program.GetParent().LoadScreen("DefaultClass");

        }

        private void AddClassScreen_Load(object sender, EventArgs e)
        {
            Program.GetParent().AcceptButton = buttonAdd;

            dateTimePickerStartTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartTime.CustomFormat = "hh:mm tt";

            dateTimePickerEndTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndTime.CustomFormat = "hh:mm tt";

            textBoxCourseId.Select();
            this.Dock = DockStyle.Fill;
        }
    }
}
