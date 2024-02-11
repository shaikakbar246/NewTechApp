using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication_Hrms.Controllers
{
    public class ActionParameterAccountController : Controller
    {
        // GET: ActionParameterAccount
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ContentResult validate()
        {
            string u = Request["username"];
            string P = Request["password"];
            if (u == "scott" && P == "tiger")
            {
                return Content("Wel Come");
            }
            else return Content("Sorry");
        }
        public ContentResult validate(FormCollection values)
        {
            string u = values["username"];
            string P = values["password"];
            if (u == "scott" && P == "tiger")
            {
                return Content("Wel Come");
            }
            else return Content("Sorry");
        }
    }
}