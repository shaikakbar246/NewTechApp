using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication_Hrms.Controllers
{
    public class ActionSelectorController : Controller
    {
        // GET: ActionSelector
        [ActionName("aboutus")]
        public ViewResult About()
        {
            //return View();// if we mention this View method at the time of defining "ActionName" selector it will throwgh
            //Error . for avoiding this error we should return the View("about");
            return View("About");
        }
        [NonAction]
        public string Greet()
        {
            return "Hello World"; //public action method it will treated as request
        }
        //by default it is tretaed as Httpget
        public ViewResult Contact()
        {
            return View();
        }
    }
}