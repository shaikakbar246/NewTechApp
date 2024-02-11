using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication_Hrms.Controllers
{
    public class UserRegisterController : Controller
    {
        // GET: UserRegister
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewIndex()
        {
            return View();
        }
    }
}