using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using MvcApplication_Hrms.Models;
using System.Configuration;

namespace MvcApplication_Hrms.Models
{
    public class HrmsDB
    {
        
        //Return list of all Employees
        SqlConnection con;
        public HrmsDB()
        {
            var connection = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
             con = new SqlConnection(connection);
            //var confiuration = GetConnection();
            //con = new SqlConnection(confiuration.GetSection("ConnectionStrings").GetSection("MyTestDb").Value);
        }
        //public IConfigurationRoot GetConnection()
        //{
        //    var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();
        //    return builder;
        //}
        public List<Customer> ListAll()
        {

            List<Customer> lst = new List<Customer>();
            con.Open();
            SqlCommand com = new SqlCommand("select * from employedetails", con)
            {
                CommandType = CommandType.Text
            };
            SqlDataReader rdr = com.ExecuteReader();
            while (rdr.Read())
            {
                lst.Add(new Customer
                {
                    EmployeeID = rdr["empid"].ToString(),
                    Name = rdr["fullname"].ToString(),
                    Age = rdr["age"].ToString(),
                    State = rdr["state"].ToString(),
                    City = rdr["city"].ToString(),
                });
            }
            return lst;
        }



        //Method for Adding an Employee
        public int Add(Customer emp)
        {
            int i;



            con.Open();
            SqlCommand com = new SqlCommand("INSERT INTO employedetails (fullname,age,state,city)VALUES(@Name,@Age,@State,@Country); ", con)
            {
                CommandType = CommandType.Text
            };
            com.Parameters.AddWithValue("@Name", emp.Name);
            com.Parameters.AddWithValue("@Age", emp.Age);
            com.Parameters.AddWithValue("@State", emp.State);
            com.Parameters.AddWithValue("@Country", emp.City);
            com.Parameters.AddWithValue("@Action", "Insert");
            i = com.ExecuteNonQuery();
            return i;
        }



        //Method for Updating Employee record
        public int Update(Customer emp)
        {
            int i;



            con.Open();
            SqlCommand com = new SqlCommand("update employedetails set fullname=@Name,age=@Age,state=@State,city=@Country where empid=@EmployeeID", con)
            {
                CommandType = CommandType.Text
            };
            com.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);
            com.Parameters.AddWithValue("@Name", emp.Name);
            com.Parameters.AddWithValue("@Age", emp.Age);
            com.Parameters.AddWithValue("@State", emp.State);
            com.Parameters.AddWithValue("@Country", emp.City);
            com.Parameters.AddWithValue("@Action", "Update");
            i = com.ExecuteNonQuery();
            return i;
        }



        //Method for Deleting an Employee
        public int Delete(int ID)
        {
            int i;
            con.Open();
            SqlCommand com = new SqlCommand("DELETE FROM employedetails WHERE empid=@EmployeeID", con)
            {
                CommandType = CommandType.Text
            };
            com.Parameters.AddWithValue("@EmployeeID", ID);
            i = com.ExecuteNonQuery();
            return i;
        }
        public List<UserLogin> UserListAll()
        {

            List<UserLogin> lst = new List<UserLogin>();
            con.Open();
            SqlCommand com = new SqlCommand("select * from userinfo", con)
            {
                CommandType = CommandType.Text
            };
            SqlDataReader rdr = com.ExecuteReader();
            while (rdr.Read())
            {
                lst.Add(new UserLogin
                {
                    username = rdr["username"].ToString(),
                    password = rdr["password"].ToString(),
                    email = rdr["email"].ToString(),
                    name = rdr["name"].ToString(),
                });
            }
            return lst;
        }
        public int AddUser(UserLogin sm)
        {
            int i;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into userinfo(name,username,email,password)values(@name,@username,@email,@password); ", con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("name", sm.name);
            cmd.Parameters.AddWithValue("username", sm.username);
            cmd.Parameters.AddWithValue("password", sm.password);
            cmd.Parameters.AddWithValue("email", sm.email);
            i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}

