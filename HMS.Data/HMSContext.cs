﻿using HMS.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data
{
    public class HMSContext : IdentityDbContext<HMSUser>
    {
        public HMSContext() : base("HMSConnectionString")
        {
        }
        public static HMSContext Create()
        {
            return new HMSContext();
        }
        public DbSet<AccomodationTypes> AccomodationTypes { get; set; }
        public DbSet<AccomodationPackages> AccomodationPackages { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        
    }
}
