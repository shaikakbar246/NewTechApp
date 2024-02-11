﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication_Hrms
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "BasicDetails",
            //    url: "BasicDetails",
            //    defaults: new { controller = "Employee", action = "BasicDetails", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "NewIndex",
            //    url: "NewIndex",
            //    defaults: new { controller = "UserRegister", action = "NewIndex", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
