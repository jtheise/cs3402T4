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
    public partial class formMain : Form
    {
        private Stack<string> History = new Stack<string>();
        public string LoggedInUser { get; set; }

        public void GoBack()
        {
            LoadScreen(History.Pop());
        }


        public void ClearScreen()
        {
            ClearScreen(false);
        }

        public void ClearScreen(bool clearBoth)
        {
            containerLeftRight.Panel2.Controls.Clear();
            
            
            if (clearBoth)
                containerLeftRight.Panel1.Controls.Clear();

        }

        public void Login(string Name)
        {
            LoggedInUser = Name;

            if (Name == "student")
            {
                buttonReports.Visible = false;
                buttonBuildings.Visible = false;
            }
        }


        public void LoadScreen(string screenName)
        {
            History.Push(screenName);

            if (screenName == "AddClass")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AddClassScreen());
            }

            if (screenName == "EditClass")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditClassScreen());
            }

            if (screenName == "DeleteClass")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DeleteClassScreen());
            }

            if (screenName == "AssignRooms")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AssignRoomsScreen());
            }

            if (screenName == "EditRooms")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditRoomScreen());
            }
        }



        public formMain()
        {
            InitializeComponent();
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            formLogin login = new formLogin();

            this.Visible = false;
            login.ShowDialog();
            this.Visible = true;

            containerLeftRight.Panel2.Controls.Add(new Screens.HomeScreen());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel2.Controls.Add(new Screens.HomeScreen());
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.ClassSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultClassScreen());

        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.EventsSidePanel());
        }

        private void buttonNotifications_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.NotificationsSidePanel());
        }

        private void buttonOrganizations_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.OrganizationsSidePanel());
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            
            containerLeftRight.Panel1.Controls.Add(new SidePanels.ReportsSidePanel());
        }

        private void buttonBuildings_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.BuildingsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultBuildingsScreen());
        }

    }
}
