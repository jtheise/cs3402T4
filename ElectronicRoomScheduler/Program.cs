using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElectronicRoomScheduler
{
    static class Program
    {
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
