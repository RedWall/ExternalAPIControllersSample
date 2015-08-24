using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace ExternalAPIControllersSample.App_Start
{
    public class AutofacConfig
    {
        public static void Configure(Assembly[] assemblies)
        {
            var config = GlobalConfiguration.Configuration;

            var builder = new ContainerBuilder();

            // Register your Web API controllers.
            builder.RegisterApiControllers(assemblies);

            // Run other optional steps, like registering filters,
            // per-controller-type services, etc., then set the dependency resolver
            // to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}