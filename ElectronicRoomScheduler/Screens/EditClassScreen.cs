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
    public partial class EditClassScreen : UserControl
    {
        int IndexLoaded = -1;



        public EditClassScreen(int ClassIndex)
        {
            IndexLoaded = ClassIndex;
            InitializeComponent();
        }

        public EditClassScreen()
        {
            InitializeComponent();
        }

        private void EditClassScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            textBoxClassLookup.Select();

            LoadClass();
        }

        private void LoadClass()
        {
            if (IndexLoaded != -1)
            {
                Program.GetParent().AcceptButton = buttonSaveEditedClass;

                groupBox1.Visible = false;
                groupBox2.Visible = true;

                groupBox2.Location = groupBox1.Location;

                textBoxCourseId.Text = Program.GetParent().ClassList[IndexLoaded].CourseId;
                textBoxCourseName.Text = Program.GetParent().ClassList[IndexLoaded].CourseName;
                textBoxDepartment.Text = Program.GetParent().ClassList[IndexLoaded].Department;
                textBoxInstructor.Text = Program.GetParent().ClassList[IndexLoaded].Instructor;
                textBoxSection.Text = Program.GetParent().ClassList[IndexLoaded].SectionNumber;
                dateTimePickerStartTime.Value = Program.GetParent().ClassList[IndexLoaded].StartTime;
                dateTimePickerEndTime.Value = Program.GetParent().ClassList[IndexLoaded].EndTime;

                if (Program.GetParent().ClassList[IndexLoaded].Days != null)
                {
                    foreach (var item in Program.GetParent().ClassList[IndexLoaded].Days)
                    {
                        if (item == "Mon")
                            checkedListBoxClassDays.SetItemChecked(0, true);
                        if (item == "Tue")
                            checkedListBoxClassDays.SetItemChecked(1, true);
                        if (item == "Wed")
                            checkedListBoxClassDays.SetItemChecked(2, true);
                        if (item == "Thu")
                            checkedListBoxClassDays.SetItemChecked(3, true);
                        if (item == "Fri")
                            checkedListBoxClassDays.SetItemChecked(4, true);
                        if (item == "Sat")
                            checkedListBoxClassDays.SetItemChecked(5, true);
                        if (item == "Sun")
                            checkedListBoxClassDays.SetItemChecked(6, true);
                    }
                }
            }
            else
            {
                groupBox2.Visible = false;

                Program.GetParent().AcceptButton = buttonLookupClassToEdit;
            }
        }



        private void buttonLookup_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" });
            // to do: search through list and find the section / course name / number / etc.

            bool found = false;
            int counter = 0;

            // first look for course id
            foreach (var item in Program.GetParent().ClassList)
            {
                if (item.CourseId.Trim().ToLower() == textBoxClassLookup.Text.Trim().ToLower())
                {
                    found = true;
                    break;
                }

                if (item.CourseName.Trim().ToLower() == textBoxClassLookup.Text.Trim().ToLower())
                {
                    found = true;
                    break;
                }

                counter++;
            }

            if (!found)
            {
                MessageBox.Show("No classes found using: '" + textBoxClassLookup.Text.ToLower().Trim() + "'", "No results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IndexLoaded = -1;
                return;
            }

            IndexLoaded = counter;



            groupBox1.Visible = false;
            groupBox2.Visible = true;

            groupBox2.Location = groupBox1.Location;

            LoadClass();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            
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


            if (days.Count == 0)
            {
                errorProvider1.SetError(checkedListBoxClassDays, "Must select at least one day for the class.");
                hasErrors = true;
            }



            if (hasErrors)
                return;



            // update the information back to the list
            Program.GetParent().ClassList[IndexLoaded].CourseId = textBoxCourseId.Text;
            Program.GetParent().ClassList[IndexLoaded].CourseName = textBoxCourseName.Text;
            Program.GetParent().ClassList[IndexLoaded].Department = textBoxDepartment.Text;
            Program.GetParent().ClassList[IndexLoaded].EndTime = dateTimePickerEndTime.Value;
            Program.GetParent().ClassList[IndexLoaded].StartTime = dateTimePickerStartTime.Value;
            Program.GetParent().ClassList[IndexLoaded].SectionNumber = textBoxSection.Text;
            Program.GetParent().ClassList[IndexLoaded].Instructor = textBoxInstructor.Text;
            Program.GetParent().ClassList[IndexLoaded].Days = days;




            Program.GetParent().LoadScreen("DefaultClass");
        }
    }
}
