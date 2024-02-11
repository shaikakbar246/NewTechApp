using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_Hrms.Models;



namespace MvcApplication_Hrms.Controllers
{
    public class ModelBindingController : Controller
    {
        // GET: ModelBinding
        public ActionResult login()
        {
            return View();
        }

        //[HttpPost]
        //public ContentResult login(string username,string password)
        //{

        //    if (username == "Akbar" && password == "Saleema")
        //    {
        //        return Content("welcome Model Binding");
        //    }
        //    else
        //    {
        //        return Content("sorry:" + username);
        //    }
        //}
        [HttpPost]
        public ContentResult login(UserLogin model)
        {

            if (model.username == "Akbar" && model.password == "Saleema")
            {
                return Content("welcome Model Binding");
            }
            else
            {
                return Content("sorry:" + model.username);
            }
        }

    }
}