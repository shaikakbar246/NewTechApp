using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular_HrmsApp.Models;
using System.Data;
using System.Data.SqlClient;

namespace Angular_HrmsApp.Controllers
{
    public class CURDController : Controller
    {
        // GET: CURD
        DataBaseAccess_layer.DataBaseOperations dblayer = new DataBaseAccess_layer.DataBaseOperations();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Show_Data()
        {
            return View();
        }
        public ActionResult Update_Data(int id)
        {
            return View();
        }
        public JsonResult Get_Data_By_ID(int id)
        {
            DataSet ds = dblayer.GetRecord_by_ID(id);
            List<EmployeeDetails> deptlist = new List<EmployeeDetails>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                EmployeeDetails s = new EmployeeDetails();
                s.empid = dr["empid"].ToString();
                s.employee_num = dr["employee_num"].ToString();
                s.fullname = dr["fullname"].ToString();
                s.cellphone = dr["cellphone"].ToString();
                s.email = dr["email"].ToString();
                s.city = dr["city"].ToString();
                deptlist.Add(s);
            }
            return Json(deptlist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Add_Record(EmployeeDetails emp)
        {
            string result = string.Empty;
            dblayer.AddRecord(emp);
            result = "Inserted";
            return Json(result, JsonRequestBehavior.AllowGet);
            RedirectToAction("Index");
        }

        public JsonResult Get_Record()
        {
            DataSet ds = dblayer.getRecords();
            List<EmployeeDetails> deptlist = new List<EmployeeDetails>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                
                EmployeeDetails s = new EmployeeDetails();
                s.empid = dr["empid"].ToString();
                s.employee_num = dr["employee_num"].ToString();
                s.fullname = dr["fullname"].ToString();
                s.cellphone = dr["cellphone"].ToString();
                s.email = dr["email"].ToString();
                s.city = dr["city"].ToString();
                deptlist.Add(s);
            }
            return Json(deptlist, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update_Record(EmployeeDetails emp)
        {
            string result = string.Empty;
            dblayer.updaterecord(emp);
            result = "Update";
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int id)
        {
            string result = string.Empty;
            dblayer.Delete_Record(id);
            result = "Delete";
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}