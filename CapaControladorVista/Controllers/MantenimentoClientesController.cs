using CapaControladorVista.Filters;
using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaControladorVista.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class MantenimentoClientesController : Controller
    {

       
        //
        // GET: /MantenimentoClientes/
        readonly IOperacion _operacion;
        //IContexto contexto = new Contexto();
        public MantenimentoClientesController(IOperacion operacion)
        {

            this._operacion = operacion;
        }

        
       


        public ActionResult Index()
        {
            return View(_operacion.GetAll().ToList() );
        }


        // [ValidateAntiForgeryToken]  
        public ActionResult Create(Cliente cliente)
        {
            
            if (cliente.Nombre != null)
            {

                _operacion.Add(cliente);
                return RedirectToAction("Index");

            }

            return View(cliente);

            
        }

        public ActionResult Delete(int id = 0)
        {
            Cliente cliente  = _operacion.Get(id) ;

            if (cliente == null)
            {
                return HttpNotFound();
            }
           // _operacion.Delete(cliente);


            return View(cliente);
        }


        [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]  
        public ActionResult DeleteConfirmed(int id)
        {
                      

            Cliente cliente = _operacion.Get(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            _operacion.Delete(cliente);


            return RedirectToAction("Index");


        }


        public ActionResult Details(int id = 0)
        {
            Cliente clientes = _operacion.Get(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }


        // [ValidateAntiForgeryToken]  
        public ActionResult Edit(int id = 0)
        {
            Cliente clientes = _operacion.Get(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        //
        // POST: /MantenimientoCliente/Edit/5

        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
          

           // Cliente cliente = _operacion.Get(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            _operacion.Update(cliente);


            return RedirectToAction("Index");


        }










        //public ActionResult GetClientes()
        //{
        //    var listClientes = _operacion;
        //}
    }
}
