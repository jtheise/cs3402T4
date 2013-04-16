using System;
using System.Windows.Forms;

namespace ElectronicRoomScheduler
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        bool _authenticated = false;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click", textBoxName.Text });

            if (textBoxName.Text == "student")
            {
                Program.GetParent().Login("student");
                _authenticated = true;

                Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click", textBoxPassword.Text });
                Close();
            }
            else if (textBoxName.Text == "professor")
            {
                Program.GetParent().Login("professor");
                _authenticated = true;
                Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click", textBoxPassword.Text });
                Close();
            }
            else if (textBoxName.Text == "admin")
            {
                Program.GetParent().Login("admin");
                _authenticated = true;
                Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click", textBoxPassword.Text });
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" });
            Application.Exit();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            if (textBoxName != null) 
                textBoxName.Select();
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_authenticated)
                Application.Exit();
        }
    }
}
