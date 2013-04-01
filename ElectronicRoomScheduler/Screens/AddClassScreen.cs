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
            DialogResult dr = MessageBox.Show("The class was successfully added.\r\n\r\nDo you want to add another class?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
                Program.GetParent().LoadScreen("AddClass");
            else
                Program.GetParent().ClearScreen();

        }
    }
}
