using HMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Web.Areas.Dashboard.Models
{
    public class AccomodationTypesListingModels
    {
        public IEnumerable<AccomodationTypes> AccomodationTypes { get; set; }
    }

    public class AccomodationTypesActionModels
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

}