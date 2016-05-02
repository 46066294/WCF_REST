using Autofac;
using Dominio;
using Insfrastructura;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi2.Controllers;
using Autofac.Integration.WebApi;
using System.Reflection;

namespace WebApi2.App_Start
{
    public class AutoFacConfig
    {
        public static void RegisterAutofact()
        {

            // IoCConfig.RegisterDependencies();




         
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterType<Operacion>().As<IOperacion>();
            builder.RegisterType<AppContext>().As<IRepositorio>();
         
            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //  DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

    }
}