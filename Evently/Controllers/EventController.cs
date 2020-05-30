using Evently.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EventlyDataLibrary;
using EventlyDataLibrary.BusinessLogic;

namespace Evently.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            var data = EventProcessor.LoadEvents();

            List<EventModel> events = new List<EventModel>();

            foreach (var row in data)
            {
                events.Add(new EventModel
                {
                    EventName = row.EventName,
                    EventDescription = row.EventDescription,
                    EventDate = row.EventDate
                });
            }

            return View(events);
        }

        public ActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEvent(EventModel model)
        {
            if(ModelState.IsValid)
            {
                int rec = EventProcessor.CreateEvent(model.EventName, model.EventDescription, model.EventDate);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}