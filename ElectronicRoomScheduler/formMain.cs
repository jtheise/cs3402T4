/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Comments: Justin Theisen
 * This section sets up the main form and starts the program
 * *************************************************/


using ElectronicRoomScheduler.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace ElectronicRoomScheduler
{
    public partial class FormMain : Form
    {
        private Stack<string> History = new Stack<string>();
        public string LoggedInUser { get; set; }


        public List<Class> ClassList;
        public int ClassToLoad { get; set; }


        public List<Event> EventList;
        public int EventToLoad { get; set; }

        public List<Notification> NotificationList;
        public int NotificationToLoad { get; set; }


        public void GoBack()
        {
            LoadScreen(History.Pop()); //goes back a screen
        }

        public void ClearScreen()
        {
            ClearScreen(false);  //clears the current screens
        }

        public void ClearScreen(bool clearBoth)
        {
            containerLeftRight.Panel2.Controls.Clear(); //clears sidepanels

            
            containerLeftRight.SplitterDistance = 170;
            containerLeftRight.Panel1.Show();

            if (clearBoth)
                containerLeftRight.Panel1.Controls.Clear();
        }

        public void Login(string name)
        {
            LoggedInUser = name; //get the logged in name and deisplay the right panels for them

            if (name == "student")
            {
                buttonReports.Visible = false;
                buttonBuildings.Visible = false;
                buttonClasses.Visible = false;
                buttonEvents.Visible = false;
                buttonBuildings.Visible = false;
                buttonRooms.Visible = false;
            }

            if (name == "admin")
            {
                buttonHome.Visible = false;
            }
        }

        #region LoadScreen(string screenName)

        //This region handels the swaping and loading of screens logically

        public void LoadScreen(string screenName)
        {
            History.Push(screenName);

            if (screenName == "DefaultBuilding")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DefaultBuildingsScreen());
            }

            if (screenName == "DefaultClass")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DefaultClassScreen());
            }
            if (screenName == "DefaultEvent")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DefaultEventScreen());
            }
            if (screenName == "DefaultNotification")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DefaultNotificationScreen());
            }
            if (screenName == "DefaultOrganization")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DefaultOrganizationScreen());
            }
            if (screenName == "DefaultReport")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DefaultReportScreen());
            }
            if (screenName == "DefaultRoom")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DefaultRoomScreen());
            }
            if (screenName == "AddClass")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AddClassScreen());
            }

            if (screenName == "EditClass")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditClassScreen(ClassToLoad));
            }

            if (screenName == "DeleteClass")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DeleteClassScreen());
            }

            if (screenName == "AssignRoom")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AssignRoomScreen());
            }
            if (screenName == "AutoAssignRooms")
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.AutoAssignRoomsScreen());
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
            if (screenName.StartsWith("EditEvent"))
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.EditEventScreen(int.Parse(screenName.Split('|')[1])));
            }
            if (screenName.StartsWith("DeleteEvent"))
            {
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(new Screens.DeleteEventScreen(int.Parse(screenName.Split('|')[1])));
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
        #endregion

        public FormMain()
        {
            InitializeComponent(); //load main form
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin(); //start the login form
            LoggedInUser = "";

            this.Visible = false;
            login.ShowDialog();
            this.Visible = true;

            containerLeftRight.Panel1.Hide();
            containerLeftRight.SplitterDistance = 0;
            containerLeftRight.Panel2.Select();
            
            ClassList = new List<Class>();
            NotificationList = new List<Notification>();
            EventList = new List<Event>();


            // load class data
            try
            {
                using (Stream stream = File.Open("class.data", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter(); //saving data

                    ClassList = (List<Class>)bin.Deserialize(stream);
                }
            }
            catch (Exception) // does not exist (most likely)
            {
                ClassList = new List<Class>();
            }


            try
            {
                using (Stream stream = File.Open("notification.data", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter(); //writing output data

                    NotificationList = (List<Notification>)bin.Deserialize(stream);
                }
            }
            catch (Exception) // does not exist (most likely)
            {
                NotificationList = new List<Notification>();
            }


            try
            {
                using (Stream stream = File.Open("event.data", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter(); //saving data

                    EventList = (List<Event>)bin.Deserialize(stream);
                }
            }
            catch (Exception) // does not exist (most likely)
            {
                EventList = new List<Event>();
            }




            // populate with canned data if it has zero items...
            if (EventList.Count == 0)
            {
                Event evt = new Event();

                evt.Date = DateTime.Now.AddDays(1);
                evt.Host = "AEΩ";
                evt.Name = "Meeting";
                evt.PeopleAttending.Add("Student A");
                evt.Room = "104 South Hall";
                EventList.Add(evt);
            }


            if (ClassList.Count == 0)
            {
                Class cls = new Class();

                cls.CourseId = "11785";
                cls.CourseName = "Usability Engineering";
                cls.Days = new List<string>();
                cls.Days.Add("Mon");
                cls.Days.Add("Wed");
                cls.SectionNumber = "1001";
                cls.Department = "Computer Science";

                cls.StartTime = new DateTime(2013, 4, 12, 16, 30, 0);
                cls.EndTime = new DateTime(2013, 4, 12, 17, 45, 0);
                cls.Instructor = "Michael Findler";

                ClassList.Add(cls);


                cls = new Class();

                cls.CourseId = "11783";
                cls.CourseName = "Information Management Technologies";
                cls.Days = new List<string>();
                cls.Days.Add("Mon");
                cls.Days.Add("Wed");
                cls.Days.Add("Fri");
                cls.SectionNumber = "1001";
                cls.Department = "Computer Science";

                cls.StartTime = new DateTime(2013, 4, 12, 13, 30, 0);
                cls.EndTime = new DateTime(2013, 4, 12, 14, 20, 0);
                cls.Instructor = "Jong Kwan Lee";

                ClassList.Add(cls);


                cls = new Class();

                cls.CourseId = "72401";
                cls.CourseName = "Numerical Analysis";
                cls.Days = new List<string>();
                cls.Days.Add("Mon");
                cls.Days.Add("Wed");
                cls.Days.Add("Fri");
                cls.SectionNumber = "1001";
                cls.Department = "Computer Science";

                cls.StartTime = new DateTime(2013, 4, 12, 14, 30, 0);
                cls.EndTime = new DateTime(2013, 4, 12, 15, 20, 0);
                cls.Instructor = "Tong Sun";

                ClassList.Add(cls);
            }




            if (LoggedInUser != "admin")
                containerLeftRight.Panel2.Controls.Add(new Screens.HomeScreen());
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save class data....
            try
            {
                using (Stream stream = File.Open("class.data", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, ClassList);
                }
            }
            catch (Exception)
            {
                
            }



            // save event data
            try
            {
                using (Stream stream = File.Open("event.data", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, EventList);
                }
            }
            catch (Exception)
            {
                
            }





            try
            {
                using (Stream stream = File.Open("notification.data", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, NotificationList);
                }
            }
            catch (Exception)
            {
                
            }

        }

        #region Button Clicks

        //this region handels the loading of the screens and menus related to side screens

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); //load the home screen
            ClearScreen(true);

            containerLeftRight.Panel1.Hide();
            containerLeftRight.SplitterDistance = 0;

            containerLeftRight.Panel2.Controls.Add(new Screens.HomeScreen());
        }

        private void buttonClasses_Click(object sender, EventArgs e) //load classes menus
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.ClassSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultClassScreen());

        }

        private void buttonEvents_Click(object sender, EventArgs e) //load event menus
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.EventsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultEventScreen());
        }

        private void buttonNotifications_Click(object sender, EventArgs e) //load notitifcation menus
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.NotificationsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultNotificationScreen());
        }

        private void buttonOrganizations_Click(object sender, EventArgs e) //load organization menus
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.OrganizationsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultOrganizationScreen());
        }

        private void buttonReports_Click(object sender, EventArgs e) //load reports menus
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.ReportsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultReportScreen());
        }

        private void buttonBuildings_Click(object sender, EventArgs e)  //load buildings menus
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" });
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.BuildingsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultBuildingsScreen());
        }

        private void buttonRooms_Click(object sender, EventArgs e) //load room menus
        {
            Program.LogButtonClick(new string[] { DateTime.Now.ToString(), ((Button)sender).Name, "Click" }); 
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.RoomsSidePanel());
            containerLeftRight.Panel2.Controls.Add(new Screens.DefaultRoomScreen());
        }
        #endregion
    }
}
