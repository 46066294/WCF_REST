using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ClientController : ApiController
    {
        // GET api/client



           readonly IOperacion _operacion;
           public ClientController(IOperacion operacion)
	{
             this._operacion = operacion;
	}
           public ClientController()
           {

           }
          public IEnumerable<Cliente> Get()
        {
            return _operacion.GetAll().ToList() ;

           

        }





        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
