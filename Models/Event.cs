using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebsiteforCBTA.Models
{
    public class Event
    {
 
        public int EventId { get; set; }
        public string EventName { get; set; } 

        public DateTime EventstartDate { get; set; }
        public DateTime EventendDate { get; set; }
        public DateTime EventStartTime { get; set; }
        public DateTime EventEndTime { get; set; }
        public string GuestSpeaker { get; set; }
        public double   Price { get; set; }

        public string Venue { get; set; }

        public virtual ICollection<Booking> EventBookings { get; set;}
    }
}