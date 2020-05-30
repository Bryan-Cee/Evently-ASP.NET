using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evently.Models
{
    public class SiteModel
    {
        public string SiteName { get; set; }
        public int SiteCapacity { get; set; }
        public bool SiteBooked { get; set; }
    }
}