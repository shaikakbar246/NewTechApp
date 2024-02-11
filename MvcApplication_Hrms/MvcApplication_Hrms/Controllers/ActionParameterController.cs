using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication_Hrms.Controllers
{
    public class ActionParameterController : Controller
    {
        // GET: ActionParameter
        public ViewResult List()
        {
            return View();
        }
        public ContentResult Details()
        {
            int x = Convert.ToInt32(Request["id"]);
            string country = "";
            switch (x)
            {
                case 1: country = " India"; break;
                case 2: country = "USA"; break;
                case 3: country = "Pakistan"; break;
                default:
                    country = "Sorry You do not belongs to any country";

                    break;
            }
            return Content(country);
        }
    }
}