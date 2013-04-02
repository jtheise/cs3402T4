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
            if (Name == "student")
            {
                buttonReports.Visible = false;
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

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            ClearScreen(true);

            containerLeftRight.Panel1.Controls.Add(new SidePanels.ClassSidePanel());
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

    }
}
