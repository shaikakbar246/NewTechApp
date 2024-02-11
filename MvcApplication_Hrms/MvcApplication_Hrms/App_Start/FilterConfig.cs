using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication_Hrms
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filter)
        {
            HandleErrorAttribute errorFilter = new HandleErrorAttribute();
            errorFilter.View = "Error";
            filter.Add(errorFilter);

        }
    }
}