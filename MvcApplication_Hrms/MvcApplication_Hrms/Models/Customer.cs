using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication_Hrms.Models
{
    public class Customer
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}