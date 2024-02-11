using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using MvcApplication_Hrms.Models;
namespace MvcApplication_Hrms.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
       HrmsDB  empDB = new HrmsDB();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            return Json(empDB.ListAll());
        }
        [HttpPost]
        public JsonResult Add(Customer empObj)
        {
            return Json(empDB.Add(empObj));
        }
        public JsonResult GetbyID(int ID)
        {
            var Employee = empDB.ListAll().Find(x => x.EmployeeID.Equals(ID));
            return Json(Employee);
        }
        [HttpPost]
        public JsonResult Update(Customer empObj)
        {
            return Json(empDB.Update(empObj));
        }
        public JsonResult Delete(int ID)
        {
            return Json(empDB.Delete(ID));
        }
    }
}