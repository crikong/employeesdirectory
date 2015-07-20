using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace api
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute
            (
                "Company Employees",
                "companies/{CompanyId}/{action}",

                new
                {
                    controller = "companies",
                    action = "Index",
                    CompanyId = UrlParameter.Optional
                }
            );

       
       

          
        }
    }
}