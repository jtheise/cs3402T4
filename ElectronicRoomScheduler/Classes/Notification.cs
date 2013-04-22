/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 *
 * 
 * Class Definition for our data on notifications
 * *************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicRoomScheduler.Classes
{
    [Serializable()]
    public class Notification
    {
        public List<string> PhoneOrEmail { get; set; }
        public List<string> Frequency { get; set; }
        public bool Recurring { get; set; }
        public List<string> ClassOrEvent { get; set; }
    }
}
