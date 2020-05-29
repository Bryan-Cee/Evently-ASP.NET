using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evently.Models
{
    public class EventModel
    {
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventDate { get; set; }
    }
}