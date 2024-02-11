using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Mvc;
using MvcApplication_Hrms.Models;
using System.Data;
using System.Data.SqlClient;

namespace MvcApplication_Hrms.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Index()
        {
            var connection = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT TOP 10 Name,Address,Email,Gender,CityId,Languages from EmpDetails", con);
            List<RegisterViewModel> emplist = new List<RegisterViewModel>();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                RegisterViewModel s = new RegisterViewModel();
                s.Name = dr["Name"].ToString();
                s.Email = dr["Email"].ToString();
                s.Gender = dr["Gender"].ToString();
                s.Address = dr["Address"].ToString();
                emplist.Add(s);
            }
            ViewBag.contentlist = emplist;
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Login(FormCollection values)
        {

            return View();
        }
        public ViewResult Register()
        {
            List<City> lstcity = new List<City>();
            City obj = new City();
            obj.id = 1;
            obj.name = "Hyderaba";
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
        [HttpPost]
        public ActionResult Register(RegisterViewModel model, string command)
        {
            if (command == "Register")
            {

                var connection = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand("insert into EmpDetails(Name,Address,Email,Gender,CityId,Password,ConfirmPassword)values(@Name,@Address,@Email,@Gender,@CityId,@Password,@ConfirmPassword)", con);
                cmd.Parameters.Add("@Name", model.Name);
                cmd.Parameters.Add("@Address", model.Address);
                cmd.Parameters.Add("@Email", model.Email);
                cmd.Parameters.Add("@Gender", model.Gender);
                cmd.Parameters.Add("@CityId", model.CityId);
                // cmd.Parameters.Add("@Languages", model.Languages);
                cmd.Parameters.Add("@Password", model.Password);
                cmd.Parameters.Add("@ConfirmPassword", model.ConfirmPassword);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return RedirectToAction("Index");
            }
            else if(command== "Cancel")
            {
                Session["Data"] = "AccountController";
                //ModelState.Clear();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public ActionResult Close()
        {
            return View();
        }
    }
}