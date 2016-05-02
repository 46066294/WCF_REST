using Autofac;
using Autofac.Integration.Web;
using Dominio;
using Insfrastructura;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebAppCliente;

namespace WebAppCliente
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider _containerProvider;

        // Instance property that will be used by Autofac HttpModules
        // to resolve and inject dependencies.
        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }


        void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();
            
            
            builder.RegisterType<Operacion>().As<IOperacion>().InstancePerHttpRequest();
            builder.RegisterType<AppContext>().As<IRepositorio>().InstancePerHttpRequest();


            // Código que se ejecuta al iniciarse la aplicación
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            _containerProvider = new ContainerProvider(builder.Build());

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Código que se ejecuta al cerrarse la aplicación

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se produce un error sin procesar

        }
    }
}
