using ExternalAPIControllersSample.App_Start;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ExternalAPIControllersSample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            var assemblies = GetAssemblies();
            var additionalControllerNamespaces = assemblies.SelectMany(a => a.GetTypes().Where(t => t.IsSubclassOf(typeof(ApiController))).Select(t => t.Namespace));

            AutofacConfig.Configure(assemblies);

            RouteConfig.RegisterRoutes(RouteTable.Routes, additionalControllerNamespaces);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private static Assembly[] GetAssemblies()
        {
            var path = HttpContext.Current.Server.MapPath("~/bin");

            return Directory.GetFiles(path, "*Controller*.dll").Select(Assembly.LoadFrom).ToArray();
        }
    }
}
