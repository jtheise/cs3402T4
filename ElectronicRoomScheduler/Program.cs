/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Global var declarations and functions
 * *************************************************/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElectronicRoomScheduler
{
    static class Program
    {
        //Functions to make a recording for usability data
        public static string logName = "recordings/" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Millisecond + ".csv";

        public static void LogButtonClick(string[] Data)
        {
            string line = "";

            foreach (var item in Data)
                line += item + ",";

            line = line.Trim().TrimEnd(new char[] {','});

            if (!System.IO.Directory.Exists("recordings"))
                System.IO.Directory.CreateDirectory("recordings/");


            System.IO.StreamWriter file = new System.IO.StreamWriter(logName, true);


            file.WriteLine(line);
            file.AutoFlush = true;
            file.Close();            

        } //ending the recording


        public static FormMain GetParent() //Returns main form for use translating between screens
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "FormMain")
                    return (FormMain)item;
            }

            return null;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
