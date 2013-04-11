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
            this.Dock = DockStyle.Fill;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            Program.GetParent().ClassList.RemoveAt(Program.GetParent().ClassList.Count - 1); // removes the last class






            Program.GetParent().LoadScreen("DefaultClass");
        }
    }
}
