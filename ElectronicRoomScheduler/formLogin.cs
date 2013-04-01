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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "student")
            {
                Program.GetParent().Login("student");

                this.Close();
            }
            else if (textBoxName.Text == "professor")
            {

                this.Close();
            }
            else if (textBoxName.Text == "admin")
            {

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
            textBoxName.Focus();
        }
    }
}
