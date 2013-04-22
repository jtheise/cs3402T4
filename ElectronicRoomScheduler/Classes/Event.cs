/***************************************************
 * CS3240 Electronic Room Seceduler
 * Coded: Rob Risner
 * Commented: Justin Theisen
 *
 * 
 * Class Definition for our data on events
 * *************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicRoomScheduler.Classes
{
    [Serializable()]
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Room { get; set; }
        public string Host { get; set; }
        public List<string> PeopleAttending { get; set; }

        public Event()
        {
            PeopleAttending = new List<string>();
        }
    }
}
