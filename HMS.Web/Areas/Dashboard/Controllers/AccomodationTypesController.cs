using HMS.Entity;
using HMS.Services;
using HMS.Web.Areas.Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Web.Areas.Dashboard.Controllers
{
    public class AccomodationTypesController : Controller
    {
        // GET: Dashboard/AccomodationTypes
        AccomodationTypesServices accomodationTypesServices = new AccomodationTypesServices();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listing()
        {
            AccomodationTypesListingModels models = new AccomodationTypesListingModels();
            models.AccomodationTypes = accomodationTypesServices.GetAllAccomodationTypes();
            return PartialView("Listing", models);
        }

        [HttpGet]
        public ActionResult Action()
        {
            AccomodationTypesActionModels models = new AccomodationTypesActionModels();

            return PartialView("_Action",models);
        }

        [HttpPost]
        public JsonResult Action(AccomodationTypesActionModels models)
        {
            JsonResult json = new JsonResult();

            AccomodationTypes accomodationTypes = new AccomodationTypes();
            accomodationTypes.Name = models.Name;
            accomodationTypes.Description = models.Description;

            var result = accomodationTypesServices.SaveAccomodationTypes(accomodationTypes);
            if(result)
            {
                json.Data = new { success = true };
            }
            else
            {
                json.Data = new { success = false, Message = "Unable to add Accomodation Type." };
            }

            return json;
        }

    }
}