/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 *
 * 
 * Deleting a class screen
 * *************************************************/

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
    public partial class DeleteClassScreen : UserControl
    {
        public DeleteClassScreen()
        {
            InitializeComponent();
        }

        private void DeleteClassScreen_Load(object sender, EventArgs e)
        {
            //if something was selected fill out the delete
            if (Program.GetParent().ClassToLoad != -1)
                textBoxClassLookup.Text = Program.GetParent().ClassList[Program.GetParent().ClassToLoad].CourseId;

            this.Dock = DockStyle.Fill;
            this.textBoxClassLookup.Select();
            Program.GetParent().AcceptButton = buttonLookupClassToDelete;
        }

        private void buttonLookup_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" });  //log data 
            bool found = false;
            int counter = 0;


            //check for the class to be deleted
            foreach (var item in Program.GetParent().ClassList)
            {
                if (item.CourseId.Trim().ToLower() == textBoxClassLookup.Text.Trim().ToLower())
                {
                    found = true;
                    break;
                }
                counter++;
            }
            if (!found)
            {
                MessageBox.Show("No classes were found with course id '" + textBoxClassLookup.Text.Trim().ToLower() + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this class?", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                Program.GetParent().LoadScreen("DeleteClass");
                return;
            }

            Program.GetParent().ClassList.RemoveAt(counter); // removes the last class

            Program.GetParent().LoadScreen("DefaultClass");
        }

     
    }
}
