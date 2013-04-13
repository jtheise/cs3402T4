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
    public partial class DefaultNotificationScreen : UserControl
    {
        public DefaultNotificationScreen()
        {
            InitializeComponent();
        }

        private void DefaultNotificationScreen_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;







            listView.Items.Clear();

            foreach (Notification item in Program.GetParent().NotificationList)
            {
                string sentTo = "";
                string frequency = "";
                string ClasssAndEvents = "";

                for (int i = 0; i < item.Frequency.Count; i++)
                {
                    frequency += item.Frequency[i] + ",";
                    if (i == 4)
                        break;
                }
                frequency = frequency.Trim().TrimEnd(',');


                for (int i = 0; i < item.ClassOrEvent.Count; i++)
                {
                    ClasssAndEvents += item.ClassOrEvent[i] + ",";
                    if (i == 4)
                        break;
                }
                ClasssAndEvents = ClasssAndEvents.Trim().TrimEnd(',');


                for (int i = 0; i < item.PhoneOrEmail.Count; i++)
                {
                    sentTo += item.PhoneOrEmail[i] + ",";
                    if (i == 4)
                        break;
                }
                sentTo = sentTo.Trim().TrimEnd(',');


                listView.Items.Add(new ListViewItem(new string[] { sentTo, frequency, item.Recurring ? "Yes" : "No", ClasssAndEvents }));
            }

            if (listView.Items.Count > 0)
            {
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
    }
}
