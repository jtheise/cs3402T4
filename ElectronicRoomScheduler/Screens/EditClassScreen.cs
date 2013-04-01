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
        public EditClassScreen()
        {
            InitializeComponent();
        }

        private void EditClassScreen_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
            this.Dock = DockStyle.Fill;
        }
    }
}
