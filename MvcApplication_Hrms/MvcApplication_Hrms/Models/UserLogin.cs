using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication_Hrms.Models
{
    public class UserLogin
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string name { get; set; }
    }
}