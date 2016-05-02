using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Servicio;
using Insfrastructura;
using System.Web.Mvc;
using WebApi.Controllers;
using System.Web.Http;
using Dominio;
using System.Reflection;
using WebApi;

using Autofac.Builder;
using Autofac.Integration.WebApi;
using System.Security;

namespace WebApi.App_Start
{
    public  class AutoFacConfig
    {
        //[SecurityCritical]
        public static void RegisterAutofact()
        {

        // IoCConfig.RegisterDependencies();




            // Register MVC-related dependencies
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);



            builder.RegisterType<ClientController>().As<ApiController>();
            builder.RegisterType<Operacion>().As<IOperacion>();
            builder.RegisterType<AppContext>().As<IRepositorio>();
            builder.RegisterType<Cliente>();



            // Set the MVC dependency resolver to use Autofac
            var container = builder.Build();

           config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //  DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

    }
}