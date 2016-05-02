using System.Collections.ObjectModel;
using System.Net.Http;
using WebApi2.Handler;


namespace WebApi2.App_Start
{
    public class JuguetitoConfig
    {
        public static void RegisterHandlers(Collection<DelegatingHandler> handlers)
        {
            handlers.Add(new JuguetitoHandler());
        }
    }
}