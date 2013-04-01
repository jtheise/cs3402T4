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
        private List<string> History = new List<string>();

        public void GoBack()
        {

        }

        public void ClearScreen()
        {
            containerLeftRight.Panel2.Controls.Clear();
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
            History.Add(screenName);


            if (screenName == "AddClass")
            {
                Screens.AddClassScreen addClass = new Screens.AddClassScreen();
                

                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(addClass);

                

                addClass.Focus();
            }

            if (screenName == "EditClass")
            {
                Screens.EditClassScreen editClass = new Screens.EditClassScreen();
                containerLeftRight.Panel2.Controls.Clear();
                containerLeftRight.Panel2.Controls.Add(editClass);

                
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

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            buttonOrganizations.Visible = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            buttonOrganizations.Visible = false;
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            containerLeftRight.Panel1.Controls.Clear();
            containerLeftRight.Panel1.Controls.Add(new SidePanels.ClassSidePanel());

            ClearScreen();
        }

    }
}
