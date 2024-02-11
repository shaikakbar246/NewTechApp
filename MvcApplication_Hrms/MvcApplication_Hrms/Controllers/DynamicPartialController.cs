using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication_Hrms.Controllers
{
    public class DynamicPartialController : Controller
    {
        // GET: DynamicPartial
        public ViewResult DotNet()
        {
            return View();
        }
        public ViewResult PHP()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult Sidebar()
        {
            string[] courses = { "PHP", "DotNet", "Java", "ADO.NET" };
            return PartialView("_Sidebar", courses);
        }
    }
}