using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using DataLayer.Context;
using System.Data.Entity;
using StructureMap;
using StructureMap.TypeRules;
using Infrastructure.IOC;
using Angular4DotNetMvc.App_Start;
using System.Web.Optimization;

namespace Angular4DotNetMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IoC.Container.Configure(cfg =>
                {
                    cfg.AddRegistry(new Factories());
                    cfg.AddRegistry(new Services());
                    cfg.AddRegistry(new Repositories());
                });

            Database.SetInitializer(new CardSeed());

            using (var context = new CardEntities())
            {
                context.Database.Initialize(force: true);
            }

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            ValueProviderFactories.Factories.Add(new JsonValueProviderFactory());
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyResolver.SetResolver(new StructureMapDependancyResolver());

        }
    }
}