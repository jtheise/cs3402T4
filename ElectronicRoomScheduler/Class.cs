using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicRoomScheduler
{
    [Serializable()]
    public class Class
    {
        public string CourseId { get; set; }
        public string Department { get; set; }
        public string Instructor { get; set; }

        public string CourseName { get; set; }
        public string SectionNumber { get; set; }
        public List<string> Days { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
