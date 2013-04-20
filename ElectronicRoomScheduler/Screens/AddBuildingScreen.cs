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
    public partial class AddBuildingScreen : UserControl
    {
        public AddBuildingScreen()
        {
            InitializeComponent();
        }

        private void AddBuildingScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

    }
}
