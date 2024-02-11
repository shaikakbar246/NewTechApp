using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_Hrms.Models;
namespace MvcApplication_Hrms.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            List<City> lstcity = new List<City>();
            City obj = new City();
            obj.id = 1;
            obj.name = "Hyderabad";
            lstcity.Add(obj);
            City obj1 = new City();
            obj1.id = 2;
            obj1.name = "Chennai";
            lstcity.Add(obj1);
            City obj2 = new City();
            obj2.id = 3;
            obj2.name = "Mumbai";
            lstcity.Add(obj2);
            City obj3 = new City();
            obj3.id = 4;
            obj3.name = "Bangalore";
            lstcity.Add(obj3);

            ViewBag.CityList = lstcity;
            return View();
        }
    }
}