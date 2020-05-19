using HMS.Data;
using HMS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Services
{
    public class AccomodationTypesServices
    {
        public IEnumerable<AccomodationTypes> GetAllAccomodationTypes()
        {
            var context = new HMSContext();

            return context.AccomodationTypes.AsEnumerable();
        }

        public bool SaveAccomodationTypes(AccomodationTypes accomodationTypes)
        {
            var context = new HMSContext();

            context.AccomodationTypes.Add(accomodationTypes);
            return context.SaveChanges() > 0 ;
        }
    }
}
