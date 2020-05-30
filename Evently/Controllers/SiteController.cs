using Evently.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Evently.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public List<SiteModel> sites = new List<SiteModel>
        {
            new SiteModel{ SiteName = "Quiditch Pitch", SiteCapacity = 750, SiteBooked = false },
            new SiteModel{ SiteName = "Valhalla", SiteCapacity = 700, SiteBooked = true },
            new SiteModel{ SiteName = "Hogwarts", SiteCapacity = 650, SiteBooked = false },
        };

        public ActionResult Index()
        {
            return View(sites);
        }

        public ActionResult Site()
        {
            return View(sites);
        }
    }
}