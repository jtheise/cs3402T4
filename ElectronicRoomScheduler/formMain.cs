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
    public partial class FormMain : Form
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

            
            containerLeftRight.SplitterDistance = 170;
            containerLeftRight.Panel1.Show();

            if (clearBoth)
                containerLeftRight.Panel1.Controls.Clear();

        }

        public void Login(string name)
        {
            LoggedInUser = name;

            if (name == "student")
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

            if (screenName == "AssignRoom")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AssignRoomsScreen());
            }

            if (screenName == "EditRoom")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditRoomScreen());
            }

            if (screenName == "AddBuilding")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AddBuildingScreen());
            }

            if (screenName == "EditBuilding")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditBuildingScreen());
            }

            if (screenName == "DeleteBuilding")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DeleteBuildingScreen());
            }

            if (screenName == "AddEvent")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AddEventScreen());
            }
            if (screenName == "EditEvent")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditEventScreen());
            }
            if (screenName == "DeleteEvent")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DeleteEventScreen());
            }


            if (screenName == "AddNotification")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AddNotificationScreen());
            }
            if (screenName == "EditNotification")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditNotificationScreen());
            }
            if (screenName == "SetNotificationPreferences")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.SetNotificationPreferencesScreen());
            }

            if (screenName == "AddOrganization")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AddOrganizationScreen());
            }
            if (screenName == "EditOrganization")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditOrganizationScreen());
            }
            if (screenName == "DeleteOrganization")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DeleteOrganizationScreen());
            }



            if (screenName == "NewReport")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.NewReportScreen());
            }
            if (screenName == "LoadReport")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.LoadReportScreen());
            }
            if (screenName == "EditReport")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditReportScreen());
            }
            if (screenName == "AddQuestion")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AddQuestionScreen());
            }
            if (screenName == "LoadQuestion")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.LoadQuestionScreen());
            }
            if (screenName == "EditQuestion")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditQuestionScreen());
            }


            if (screenName == "AddRoom")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AddRoomScreen());
            }
            if (screenName == "DeleteRoom")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DeleteRoomScreen());
            }
            if (screenName == "RequestTech")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.RequestTechScreen());
            }
        }



        public FormMain()
        {
            InitializeComponent();
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            LoggedInUser = "";

            this.Visible = false;
            login.ShowDialog();
            this.Visible = true;


            containerLeftRight.Panel1.Hide();
            containerLeftRight.SplitterDistance = 0;

            containerLeftRight.Panel2.Controls.Add(new Screens.HomeScreen());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Hide();
            containerLeftRight.SplitterDistance = 0;

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
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultEventScreen());
        }

        private void buttonNotifications_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.NotificationsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultNotificationScreen());
        }

        private void buttonOrganizations_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.OrganizationsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultOrganizationScreen());
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.ReportsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultReportScreen());
        }

        private void buttonBuildings_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.BuildingsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultBuildingsScreen());
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.RoomsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultRoomScreen());
        }

    }
}
