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
    public partial class EditNotificationScreen : UserControl
    {
        public EditNotificationScreen()
        {
            InitializeComponent();
        }

        private List<string> EmailsAndPhoneNumbers = new List<string>();


        private void EditNotificationScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Program.GetParent().AcceptButton = buttonSaveNotification;

            EmailsAndPhoneNumbers.Add("(419) 867 - 5309");
            EmailsAndPhoneNumbers.Add("Blah@bgsu.edu");


            RunPopulateList();
            PopulateClassEventList();
        }
        private void RunPopulateList()
        {
            flowLayoutPanelEmailsAndPhones.Controls.Clear();
            flowLayoutPanelTo.Controls.Clear();

            foreach (var item in EmailsAndPhoneNumbers)
            {

                Label newLabel = new Label();
                newLabel.AutoSize = true;
                newLabel.Text = item;
                newLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newLabel.Margin = new System.Windows.Forms.Padding(5);
                newLabel.Padding = new System.Windows.Forms.Padding(5);
                newLabel.BackColor = Color.Yellow;
                //newLabel.MouseDown += newLabel_MouseDown;
                //newLabel.MouseUp += newLabel_MouseUp;
                flowLayoutPanelEmailsAndPhones.Controls.Add(newLabel);
            }
        }

        private void PopulateClassEventList()
        {
            flowLayoutPanelClassesAndEvents.Controls.Clear();
            flowLayoutPanelFor.Controls.Clear();

            int counter = 0;

            foreach (var item in Program.GetParent().EventList)
            {
                Label newLabel2 = new Label();
                newLabel2.AutoSize = true;
                newLabel2.Text = item.Host + ": " + item.Name;
                newLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newLabel2.Margin = new System.Windows.Forms.Padding(5);
                newLabel2.Padding = new System.Windows.Forms.Padding(5);
                newLabel2.BackColor = Color.Yellow;
                //newLabel2.MouseDown += newLabel2_MouseDown;
                //newLabel2.MouseUp += newLabel2_MouseUp;

                flowLayoutPanelClassesAndEvents.Controls.Add(newLabel2);

                if (counter == 8)
                    break;

                counter++;
            }
            counter = 0;

            foreach (var item in Program.GetParent().ClassList)
            {

                Label newLabel = new Label();
                newLabel.AutoSize = true;
                newLabel.Text = item.CourseId + ": " + item.CourseName;
                newLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newLabel.Margin = new System.Windows.Forms.Padding(5);
                newLabel.Padding = new System.Windows.Forms.Padding(5);
                newLabel.BackColor = Color.Yellow;
                //newLabel.MouseDown += newLabel2_MouseDown;
                //newLabel.MouseUp += newLabel2_MouseUp;

                flowLayoutPanelClassesAndEvents.Controls.Add(newLabel);



                if (counter == 8)
                    break;

                counter++;
            }



        }
    }
}
