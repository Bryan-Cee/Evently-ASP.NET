using Evently.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Evently.Controllers
{
    public class EventController : Controller
    {
        public List<EventModel> events { get; set; }
        // GET: Event
        public ActionResult Index()
        {
            events = new List<EventModel>
            {
                new EventModel { EventName = "Microsoft Build", EventDescription = "Just a meet up for developers", EventDate = DateTime.Now },
                new EventModel { EventName = "Google IO", EventDescription = "Google IO meet up for new things", EventDate = new DateTime(2010, 1, 1, 8, 0, 15) },
                new EventModel { EventName = "Amazon Webinar", EventDescription = "Anything AWS", EventDate = DateTime.Now }
            };

            return View(events);
        }

        public ActionResult CreateEvent()
        {
            return View();
        }
    }
}