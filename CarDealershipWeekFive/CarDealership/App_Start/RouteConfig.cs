using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarDealership
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Details2",
               url: "Car/{Year}/{Make}/{Model}",
               defaults: new { controller = "Car", action = "Details2" }
           );

            routes.MapRoute(
                 name: "Details",
                 url: "Car/Details",
                 defaults: new { controller = "Car", action = "Index" }
             );

             routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
