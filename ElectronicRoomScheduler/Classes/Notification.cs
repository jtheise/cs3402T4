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
