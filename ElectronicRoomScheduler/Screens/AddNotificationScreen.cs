/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 *
 * 
 * Add notifications with drag and drop
 * *************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ElectronicRoomScheduler.Classes;

namespace ElectronicRoomScheduler.Screens
{
    public partial class AddNotificationScreen : UserControl
    {
        public AddNotificationScreen()
        {
            InitializeComponent();
        }

        private void AddNotificationScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            Program.GetParent().AcceptButton = buttonSaveNotification;

            //add canned data

            EmailsAndPhoneNumbers.Add("(419) 867 - 5309");
            EmailsAndPhoneNumbers.Add("Blah@bgsu.edu");


            RunPopulateList(); //add canned data if no data found
            PopulateClassEventList(); //add data from saved data
        }
        private void RunPopulateList()
        {
            flowLayoutPanelEmailsAndPhones.Controls.Clear();
            flowLayoutPanelTo.Controls.Clear(); 

            //add data to the drag and drop panels
            foreach (var item in EmailsAndPhoneNumbers)
            {

                Label newLabel = new Label();
                newLabel.AutoSize = true;
                newLabel.Text = item;
                newLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newLabel.Margin = new System.Windows.Forms.Padding(5);
                newLabel.Padding = new System.Windows.Forms.Padding(5);
                newLabel.BackColor = Color.Yellow;
                newLabel.MouseDown += newLabel_MouseDown;
                newLabel.MouseUp += newLabel_MouseUp;
                flowLayoutPanelEmailsAndPhones.Controls.Add(newLabel);
            }
        }

        private void PopulateClassEventList()
        {
            flowLayoutPanelClassesAndEvents.Controls.Clear();
            flowLayoutPanelFor.Controls.Clear();

            int counter = 0;

            //add labels to the drag and drop
            foreach (var item in Program.GetParent().EventList)
            {
                Label newLabel2 = new Label();
                newLabel2.AutoSize = true;
                newLabel2.Text = item.Host + ": " + item.Name;
                newLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newLabel2.Margin = new System.Windows.Forms.Padding(5);
                newLabel2.Padding = new System.Windows.Forms.Padding(5);
                newLabel2.BackColor = Color.Yellow;
                newLabel2.MouseDown += newLabel2_MouseDown;
                newLabel2.MouseUp += newLabel2_MouseUp;
                
                flowLayoutPanelClassesAndEvents.Controls.Add(newLabel2);

                if (counter == 8)
                    break;

                counter++;
            }
            counter = 0;

            foreach (var item in Program.GetParent().ClassList)
            {  //add classes to the drag and drop

                Label newLabel = new Label();
                newLabel.AutoSize = true;
                newLabel.Text = item.CourseId + ": " + item.CourseName;
                newLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newLabel.Margin = new System.Windows.Forms.Padding(5);
                newLabel.Padding = new System.Windows.Forms.Padding(5);
                newLabel.BackColor = Color.Yellow;
                newLabel.MouseDown += newLabel2_MouseDown;
                newLabel.MouseUp += newLabel2_MouseUp;

                flowLayoutPanelClassesAndEvents.Controls.Add(newLabel);



                if (counter == 8)
                    break;

                counter++;
            }



        }

        void newLabel2_MouseUp(object sender, MouseEventArgs e) //drag and drop code
        {
            flowLayoutPanelTo.AllowDrop = true;
            flowLayoutPanelFor.AllowDrop = false;
        }

        void newLabel2_MouseDown(object sender, MouseEventArgs e) //drag and drop code
        {
            flowLayoutPanelTo.AllowDrop = false;
            flowLayoutPanelFor.AllowDrop = true;


            DoDragDrop(((Label)sender).Text, DragDropEffects.Copy);
        }


        private List<string> EmailsAndPhoneNumbers = new List<string>();

        
        void newLabel_MouseUp(object sender, MouseEventArgs e) //drag and drop code
        {
            flowLayoutPanelTo.AllowDrop = false;
            flowLayoutPanelFor.AllowDrop = true;
        }




        void newLabel_MouseDown(object sender, MouseEventArgs e) //drag and drop code
        {
            flowLayoutPanelTo.AllowDrop = true;
            flowLayoutPanelFor.AllowDrop = false;

            if (e.Button == System.Windows.Forms.MouseButtons.Right) //right click deletion of data
            {

                DialogResult dr = MessageBox.Show("Delete this email address or phone number?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string value = ((Label)sender).Text;
                    EmailsAndPhoneNumbers.Remove(value);
                    RunPopulateList();
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                DoDragDrop(((Label)sender).Text, DragDropEffects.Copy);
            }
        }

        private void buttonAddNewPhoneEmail_Click(object sender, EventArgs e) //add new contact info
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); //log data
            
            //empty input boxes
            EmailsAndPhoneNumbers.Add(textBoxPhoneEmail.Text);
            RunPopulateList();
            textBoxPhoneEmail.Text = "";
        }

        private void flowLayoutPanelTo_DragDrop(object sender, DragEventArgs e)
        {
            string val = (string)e.Data.GetData(DataFormats.Text);

            // search if its already there....
            foreach (var item in flowLayoutPanelTo.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    if (((Label)item).Text == val)
                        return; // already exists...
                }
            }

            foreach (var item in flowLayoutPanelEmailsAndPhones.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    if (((Label)item).Text == val)
                    {
                        ((Label)item).Visible = false;
                    }
                }
            }

            //add a new label with the new info to the drag and drop list

            Label newLabel = new Label();
            newLabel.AutoSize = true;
            newLabel.Text = val;
            newLabel.Margin = new System.Windows.Forms.Padding(5);
            newLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newLabel.Padding = new System.Windows.Forms.Padding(5);
            newLabel.BackColor = Color.Yellow;
            newLabel.Click += newLabel_Click;
            flowLayoutPanelTo.Controls.Add(newLabel);
        }

        void newLabel_Click(object sender, EventArgs e)
        {
            // remove it and add it back to the first column...
            int index = flowLayoutPanelTo.Controls.GetChildIndex((Control)sender);

            string value = ((Label)flowLayoutPanelTo.Controls[index]).Text;


            flowLayoutPanelTo.Controls.RemoveAt(index);


            foreach (var item in flowLayoutPanelEmailsAndPhones.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    if (((Label)item).Text == value)
                        ((Label)item).Visible = true;
                }
            }
        }

        private void flowLayoutPanelTo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy; //drag and drop code
        }

        private void textBoxPhoneEmail_Enter(object sender, EventArgs e)
        {
            Program.GetParent().AcceptButton = buttonAddNewPhoneEmail; //add new emails
        }

        private void textBoxPhoneEmail_Leave(object sender, EventArgs e)
        {
            Program.GetParent().AcceptButton = buttonSaveNotification; //save notification
        }

        private void flowLayoutPanelFor_DragDrop(object sender, DragEventArgs e)
        {
            string val = (string)e.Data.GetData(DataFormats.Text);



            // search if its already there....
            foreach (var item in flowLayoutPanelFor.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    if (((Label)item).Text == val)
                        return; // already exists...
                }
            }

            foreach (var item in flowLayoutPanelClassesAndEvents.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    if (((Label)item).Text == val)
                    {
                        ((Label)item).Visible = false;
                    }
                }
            }


            //add new labels with the data entered

            Label newLabel = new Label();
            newLabel.AutoSize = true;
            newLabel.Text = val;
            newLabel.Margin = new System.Windows.Forms.Padding(5);
            newLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newLabel.Padding = new System.Windows.Forms.Padding(5);
            newLabel.BackColor = Color.Yellow;
            //newLabel.Click += newLabel_Click;
            flowLayoutPanelFor.Controls.Add(newLabel);


        }

        private void flowLayoutPanelFor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy; //drag and drop code
        }

        private void buttonClearEventsClasses_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); //log data
            PopulateClassEventList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); //log data

            // save it out

            Notification n = new Notification();

            n.ClassOrEvent = new List<string>();
            n.Frequency = new List<string>();
            n.PhoneOrEmail = new List<string>();
            n.Recurring = checkBoxRecurring.Checked;


            foreach (var item in flowLayoutPanelFor.Controls)
                if (item.GetType() == typeof(Label))
                    n.ClassOrEvent.Add(((Label)item).Text);

            foreach (var item in flowLayoutPanelTo.Controls)
                if (item.GetType() == typeof(Label))
                    n.PhoneOrEmail.Add(((Label)item).Text);


            foreach (var item in checkedListBoxFrequency.CheckedItems)
            {
                n.Frequency.Add(item.ToString());
            }

            Program.GetParent().NotificationList.Add(n);

            MessageBox.Show("Notification saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.GetParent().LoadScreen("DefaultNotification");
        }
    }
}
