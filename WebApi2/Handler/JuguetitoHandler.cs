
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace WebApi2.Handler
{
    public class JuguetitoHandler : DelegatingHandler
    {
        const string X_Vueling = "X-Vueling";


        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var variable = int.Parse(request.Headers.GetValues(X_Vueling).First()) * 2;



            return base.SendAsync(request, cancellationToken).ContinueWith<HttpResponseMessage>(t =>
            {
                HttpResponseMessage resp = t.Result;
                resp.Headers.Add(X_Vueling, variable.ToString());
                return resp;
            });

          


                
        }

       
    }
}