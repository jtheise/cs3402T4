using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElectronicRoomScheduler
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        bool Authenticated = false;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "student")
            {
                Program.GetParent().Login("student");
                Authenticated = true;
                this.Close();
            }
            else if (textBoxName.Text == "professor")
            {
                Authenticated = true;
                this.Close();
            }
            else if (textBoxName.Text == "admin")
            {
                Authenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            textBoxName.Select();
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Authenticated)
                Application.Exit();
        }
    }
}
