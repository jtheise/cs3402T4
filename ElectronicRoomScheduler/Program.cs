using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElectronicRoomScheduler
{
    static class Program
    {
        public static formMain GetParent()
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "formMain")
                    return (formMain)item;
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
            Application.Run(new formMain());
        }
    }
}
