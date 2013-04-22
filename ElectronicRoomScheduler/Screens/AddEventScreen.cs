/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 *
 * 
 * Add event Screen
 * *************************************************/


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


            //if a control wasn't picked don't load this panel
            if (controls.Count != 1)
                return;

            SidePanels.EventsSidePanel sidePanel = ((SidePanels.EventsSidePanel)controls[0]);

            sidePanel.linkLabelEditEvent.Visible = false;
            sidePanel.linkLabelDeleteEvent.Visible = false;


            List<string> rooms = new List<string>();

            Random r = new Random((int)DateTime.Now.Ticks);

            List<string> locations = new List<string>();

            //canned data

            locations.Add("University Hall");
            locations.Add("South Hall");
            locations.Add("Hayes Hall");
            locations.Add("Education Building");
            locations.Add("Math/Science Building");

            rooms.Add("Hayes Hall 217");

            for (int i = 0; i < 100; i++) //populate lists
            {
                string building = locations[r.Next(0, 4)];


                string tempLocation = building + " " + ((r.Next(1, 3) * 100) + (r.Next(0, 4) * 10) + (r.Next(1, 9))).ToString();

                while (rooms.Contains(tempLocation))
                {
                    building = locations[r.Next(0, 4)];
                    tempLocation = building + " " + ((r.Next(1, 3) * 100) + (r.Next(0, 4) * 10) + (r.Next(1, 9))).ToString();
                }

                rooms.Add(tempLocation);
            }

            var sorted = from s in rooms
                   orderby s
                   select s;



            foreach (var item in sorted)
            {
                comboBoxRoom.Items.Add(item);
            }

        }


        private void buttonAddPerson_Click_1(object sender, EventArgs e) //add a person attending an event
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            listBoxAttending.Items.Add(textBoxPerson.Text);
            textBoxPerson.Text = "";
        }

        private void textBoxPerson_Enter_1(object sender, EventArgs e)
        {
            Program.GetParent().AcceptButton = buttonAddPerson; //add person
        }

        private void textBoxPerson_Leave_1(object sender, EventArgs e)
        {
            Program.GetParent().AcceptButton = buttonSave; //save
        }

        private void listBoxAttending_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxAttending.SelectedItems.Count == 1) //remove a person avalible after adding a person
                buttonRemovePerson.Enabled = true;
            else
                buttonRemovePerson.Enabled = false;
        }

        private void buttonRemovePerson_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); //log data
            
            //remove selected person
            
            if (listBoxAttending.SelectedItems.Count == 1)
                listBoxAttending.Items.RemoveAt(listBoxAttending.SelectedIndex);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {   
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); //log data


            Event newEvent = new Event(); //new event class to handle event added

            newEvent.Date = dateTimePickerDateTime.Value;
            newEvent.Host = textBoxHostingOrg.Text;
            newEvent.Name = textBoxEventName.Text;

            newEvent.Room = comboBoxRoom.Text;

            foreach (string item in listBoxAttending.Items)
            {
                newEvent.PeopleAttending.Add(item);
            }

            //add data to the list then exit this panel unless the user wants to enter more

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
