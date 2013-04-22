/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 * Login Screen setup
 * *************************************************/

using System;
using System.Windows.Forms;

namespace ElectronicRoomScheduler
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent(); //load the form
        }

        bool _authenticated = false; //var to check login sucess

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click", textBoxName.Text }); //send data to output file

            if (textBoxName.Text == "student") //check login names to verify and then login as the user
            {
                Program.GetParent().Login("student");
                _authenticated = true;

                Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click", textBoxPassword.Text }); //log data
                Close(); //close this form
            }
            else if (textBoxName.Text == "professor")
            {
                Program.GetParent().Login("professor");
                _authenticated = true;
                Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click", textBoxPassword.Text }); //log data
                Close(); //close this form
            }
            else if (textBoxName.Text == "admin")
            {
                Program.GetParent().Login("admin");
                _authenticated = true;
                Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click", textBoxPassword.Text }); //log data
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error message for wrong user
            }

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); //log data
            Application.Exit(); //exit the application
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            if (textBoxName != null) 
                textBoxName.Select();
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_authenticated)
                Application.Exit(); //if they can't be authenticated close the application
        }
    }
}
