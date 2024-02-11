using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCApplication.Models;
using System.Configuration;

namespace MVCApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public  ViewResult studentdata()
        {
            var connection = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select *  from employedetails", con);
            List<Student> lst = new List<Student>();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Student s = new Student();
                s.employee_num = dr["employee_num"].ToString();
                s.fullname = dr["employee_num"].ToString();
                s.nationality = dr["employee_num"].ToString();
                s.gender = dr["employee_num"].ToString();
                lst.Add(s);
            }
            return View(lst);
        }

        public ActionResult create()
        {
            return View();
        }

        public ViewResult getDepartment()
        {
            var connection = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select * from departments", con);
            List<Student> deptlist = new List<Student>();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Student s = new Student();
                s.department = dr["department"].ToString();
                s.deptid = dr["deptid"].ToString();
                deptlist.Add(s);
            }
            ViewBag.contentlist = deptlist;
            return View();
        }
    }
}