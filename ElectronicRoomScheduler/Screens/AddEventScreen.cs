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
    public partial class AddEventScreen : UserControl
    {
        public AddEventScreen()
        {
            InitializeComponent();
        }

        private void AddEventScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            dateTimePickerDateTime.Value = DateTime.Now;


            List<Control> controls = Program.GetParent().Controls.Find("EventsSidePanel", true).ToList();

            if (controls.Count != 1)
                return;

            SidePanels.EventsSidePanel sidePanel = ((SidePanels.EventsSidePanel)controls[0]);

            sidePanel.linkLabel2.Visible = false;
            sidePanel.linkLabel3.Visible = false;

        }


        private void buttonAddPerson_Click_1(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            listBoxAttending.Items.Add(textBoxPerson.Text);
            textBoxPerson.Text = "";
        }

        private void textBoxPerson_Enter_1(object sender, EventArgs e)
        {
            Program.GetParent().AcceptButton = buttonAddPerson;
        }

        private void textBoxPerson_Leave_1(object sender, EventArgs e)
        {
            Program.GetParent().AcceptButton = buttonSave;
        }

        private void listBoxAttending_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxAttending.SelectedItems.Count == 1)
                buttonRemovePerson.Enabled = true;
            else
                buttonRemovePerson.Enabled = false;
        }

        private void buttonRemovePerson_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            
            if (listBoxAttending.SelectedItems.Count == 1)
                listBoxAttending.Items.RemoveAt(listBoxAttending.SelectedIndex);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" });


            Event newEvent = new Event();

            newEvent.Date = dateTimePickerDateTime.Value;
            newEvent.Host = textBoxHostingOrg.Text;
            newEvent.Name = textBoxEventName.Text;

            newEvent.Room = comboBoxRoom.Text;

            foreach (string item in listBoxAttending.Items)
            {
                newEvent.PeopleAttending.Add(item);
            }

            Program.GetParent().EventList.Add(newEvent);

            Program.GetParent().EventList = Program.GetParent().EventList.OrderBy(x => x.Date).ToList();

            DialogResult dr = MessageBox.Show("The event was successfully added.\r\n\r\nDo you want to add another?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
                Program.GetParent().LoadScreen("AddEvent");
            else
                Program.GetParent().LoadScreen("DefaultEvent");


        }
    }
}
