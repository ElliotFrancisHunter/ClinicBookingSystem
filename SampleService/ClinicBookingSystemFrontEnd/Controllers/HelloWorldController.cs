using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.Encodings.Web
using System.Web.Mvc;

namespace ClinicBookingSystemFrontEnd.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes(1))
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}