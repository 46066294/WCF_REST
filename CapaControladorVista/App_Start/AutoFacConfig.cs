using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac.Integration.Mvc;
using CapaControladorVista.Controllers;
using Servicio;
using Insfrastructura;
using System.Web.Mvc;

namespace CapaControladorVista.App_Start
{
    public static class AutoFacConfig
    {
        public static void RegisterAutofact(Action<IDependencyResolver> setResolver)
        {
            //IoCConfig.RegisterDependencies();

            // Register MVC-related dependencies
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();


            //builder.RegisterType<MantenimentoClientesController>().As<Controller>().InstancePerHttpRequest();
            builder.RegisterType<Operacion>().As<IOperacion>().InstancePerHttpRequest();
            builder.RegisterType<AppContext>().As<IRepositorio>().InstancePerHttpRequest();
            //builder.RegisterType<Cliente>().InstancePerHttpRequest();


            builder.RegisterModelBinderProvider();

            // Set the MVC dependency resolver to use Autofac
            var container = builder.Build();

            setResolver(new AutofacDependencyResolver(container));

          //  DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

    }
}