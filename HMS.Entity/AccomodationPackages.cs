﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entity
{
    public class AccomodationPackages
    {
        public int ID { get; set; }
        public int AccomodationTypesID { get; set; }
        public AccomodationTypes AccomodationTypes { get; set; }
    }
}
