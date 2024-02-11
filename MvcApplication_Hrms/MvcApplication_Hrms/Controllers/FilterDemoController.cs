using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication_Hrms.Controllers
{
   // [HandleError(View = "Error")] //Controller Level
    public class FilterDemoController : Controller
    {
        // GET: FilterDemo
        //[HandleError(View = "Error")] //Action Level
        public ActionResult Index()
        {
            int[] x = new int[2];
            x[2] = 100;
            return View();
        }
    }
}