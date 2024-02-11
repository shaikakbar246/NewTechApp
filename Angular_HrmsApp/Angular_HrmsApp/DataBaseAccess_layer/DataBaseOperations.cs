using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Angular_HrmsApp.Models;

namespace Angular_HrmsApp.DataBaseAccess_layer
{
    public class DataBaseOperations
    {
        string connection = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();

        public DataSet getRecords()
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT TOP 10 empid,employee_num,fullname,cellphone,email,city from employedetails order by empid desc", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;

        }

        public void AddRecord(EmployeeDetails ed)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("insert into employedetails(employee_num,fullname,cellphone,email,city)values(@employee_num,@fullname,@cellphone,@email,@city)", con);
            cmd.Parameters.Add("@employee_num", ed.employee_num);
            cmd.Parameters.Add("@fullname", ed.fullname);
            cmd.Parameters.Add("@cellphone", ed.cellphone);
            cmd.Parameters.Add("@email",ed.email);
            cmd.Parameters.Add("@city", ed.city);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet GetRecord_by_ID(int id)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SELECT  empid,employee_num,fullname,cellphone,email,city from employedetails where empid=@empid", con);
            cmd.Parameters.Add("@empid", id);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public void updaterecord(EmployeeDetails ed)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("update employedetails set employee_num=@employee_num,fullname=@fullname,cellphone=@cellphone,email=@email,city=@city where empid=@empid", con);
            cmd.Parameters.Add("@employee_num", ed.employee_num);
            cmd.Parameters.Add("@fullname", ed.fullname);
            cmd.Parameters.Add("@cellphone", ed.cellphone);
            cmd.Parameters.Add("@email", ed.email);
            cmd.Parameters.Add("@city", ed.city);
            cmd.Parameters.Add("@empid", ed.empid);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete_Record(int id)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("delete  from  employedetails where empid=@empid", con);
            cmd.Parameters.Add("@empid", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}