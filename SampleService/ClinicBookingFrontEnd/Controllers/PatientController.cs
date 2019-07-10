using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicBookingFrontEnd.Controllers
{
    public class PatientController : Controller
    {
        /// <summary>
        /// Gets the /Patient/ 
        /// </summary>
        /// <returns>
        /// Default action string.
        /// </returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Gets the /Patient/Welcome/
        /// </summary>
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}