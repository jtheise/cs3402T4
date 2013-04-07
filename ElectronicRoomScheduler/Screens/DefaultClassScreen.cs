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
    public partial class DefaultClassScreen : UserControl
    {
        public DefaultClassScreen()
        {
            InitializeComponent();
        }

        private void DefaultClassScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            // add something to listview

            listView.Items.Add(new ListViewItem(new string[] { "1", "HIST 2011: Introduction to Art History", "Art Department", "Paul Picasso" }));
        }
    }
}
