using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ElectronicRoomScheduler.Classes;

namespace ElectronicRoomScheduler.Screens
{
    public partial class DefaultEventScreen : UserControl
    {
        public int SelectedIndex { get; set; }

        public DefaultEventScreen()
        {
            InitializeComponent();
        }

        private void DefaultEventScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            // add something to listview
            listView.Items.Clear();

            foreach (Event item in Program.GetParent().EventList)
            {        
                listView.Items.Add(new ListViewItem(new string[] { item.Name, item.Date.ToShortDateString() + " " + item.Date.ToShortTimeString(), item.Room, item.Host, item.PeopleAttending.Count.ToString() }));
            }

            if (listView.Items.Count > 0)
            {
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            List<Control> controls = Program.GetParent().Controls.Find("EventsSidePanel", true).ToList();

            if (controls.Count == 1)
            {
                SidePanels.EventsSidePanel sidePanel = ((SidePanels.EventsSidePanel)controls[0]);

                if (listView.SelectedItems.Count == 1)
                {
                    SelectedIndex = listView.SelectedIndices[0];
                    sidePanel.linkLabel2.Visible = true;
                    sidePanel.linkLabel3.Visible = true;
                }
                else
                {
                    SelectedIndex = -1;
                    sidePanel.linkLabel2.Visible = false;
                    sidePanel.linkLabel3.Visible = false;
                }
            }

        }
    }
}
