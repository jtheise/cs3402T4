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
    public partial class EditEventScreen : UserControl
    {
        public int LoadedEvent { get; set; }

        public EditEventScreen(int EventId)
        {
            InitializeComponent();


            LoadedEvent = EventId;
        }

        private void EditEventScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            // get the event to edit (based on index)
            if (Program.GetParent().EventList.Count - 1 < LoadedEvent)
                Program.GetParent().LoadScreen("DefaultEvent");



            dateTimePickerDateTime.Value = Program.GetParent().EventList[LoadedEvent].Date;
            textBoxEventName.Text = Program.GetParent().EventList[LoadedEvent].Name;
            textBoxHostingOrg.Text = Program.GetParent().EventList[LoadedEvent].Host;
            comboBoxRoom.Text = Program.GetParent().EventList[LoadedEvent].Room;

            foreach (var item in Program.GetParent().EventList[LoadedEvent].PeopleAttending)
            {
                listBoxAttending.Items.Add(item);
            }




            List<Control> controls = Program.GetParent().Controls.Find("EventsSidePanel", true).ToList();

            if (controls.Count == 1)
            {
                SidePanels.EventsSidePanel sidePanel = ((SidePanels.EventsSidePanel)controls[0]);

                sidePanel.linkLabel2.Visible = false;
                sidePanel.linkLabel3.Visible = false;
            }

        }

        private void textBoxPerson_Enter(object sender, EventArgs e)
        {
            Program.GetParent().AcceptButton = buttonAddPerson;
        }

        private void textBoxPerson_Leave(object sender, EventArgs e)
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
            if (listBoxAttending.SelectedItems.Count == 1)
                listBoxAttending.Items.RemoveAt(listBoxAttending.SelectedIndex);
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            listBoxAttending.Items.Add(textBoxPerson.Text);
            textBoxPerson.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < Program.GetParent().EventList.Count; i++)
            {
                if (i == LoadedEvent)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                Program.GetParent().LoadScreen("DefaultEvent");


            ElectronicRoomScheduler.Classes.Event editEvent = Program.GetParent().EventList[LoadedEvent];

            editEvent.Date = dateTimePickerDateTime.Value;
            editEvent.Host = textBoxHostingOrg.Text;
            editEvent.Name = textBoxEventName.Text;

            editEvent.Room = comboBoxRoom.Text;

            editEvent.PeopleAttending.Clear();

            foreach (string item in listBoxAttending.Items)
            {
                editEvent.PeopleAttending.Add(item);
            }

            
            Program.GetParent().LoadScreen("DefaultEvent");





        }
    }
}
