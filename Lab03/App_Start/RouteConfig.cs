﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab03
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Index",
               url: "danh-sach-rss",
               defaults: new { controller = "Blog", action = "Index", type = "blog.rss" }
           );

            routes.MapRoute(
                name: "PostFeed",
                url: "Feed/{type}",
                defaults: new { controller = "Blog", action = "PostFeed", type = "blog.rss" }
            );

            routes.MapRoute(
               name: "ReadRSS",
               url: "readrss",
               defaults: new { controller = "Blog", action = "ReadRSS", type = "blog.rss" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
