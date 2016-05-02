using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi2.Controllers
{
    public class ClientController : ApiController
    {

         readonly IOperacion _operacion;

         public ClientController(IOperacion operacion)
        {

            this._operacion = operacion;
        }


         // GET api/client
        public IEnumerable<Cliente> Get()
        {
            return _operacion.GetAll().ToList();
        }

        // GET api/values/5
        public Cliente Get(int id)
        {
            Cliente cliente = _operacion.Get(id);

            return cliente;
        }

        // POST api/values
        public void Post([FromBody]Cliente cliente)
        {
            if (cliente.Nombre == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
             }

            _operacion.Add(cliente);
        }

       /* public HttpResponseMessage Post([FromBody]Cliente cliente)
        {
            if (cliente.Nombre == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

         return Request.CreateResponse<Cliente> (   _operacion.Add(cliente);
        }*/



        


        // PUT api/client/5
        public void Put(int id, [FromBody]Cliente cliente)
        {

            cliente.Id = id;


            if (cliente == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _operacion.Update(cliente);


           
        }

        // DELETE api/client/5
      /*  public void Delete(int id)
        {
        } */


        public void Delete(int id )
        {
            Cliente cliente = _operacion.Get(id);

            if (cliente == null)
            {
                 throw new HttpResponseException  (HttpStatusCode.NotFound);
            }
             _operacion.Delete(cliente);


           // return cliente;
        }



    }
}
