using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElectronicRoomScheduler
{
    static class Program
    {
        public static void LogButtonClick(string[] Data)
        {
            string line = "";

            foreach (var item in Data)
                line += item + ",";

            line = line.Trim().TrimEnd(new char[] {','});

            System.IO.StreamWriter file = new System.IO.StreamWriter("recording.csv", true);

            file.WriteLine(line);
            file.AutoFlush = true;
            file.Close();            

        }


        public static FormMain GetParent()
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
