using Dominio;
using Insfrastructura;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;




namespace Servicio
{
    public class Operacion: ServiceBase, IOperacion 
    {
        readonly IRepositorio _repositorioCliente;

        


        public Operacion(IRepositorio repositorioCliente) : base (repositorioCliente)
        {
            if (null == repositorioCliente)
            {
                throw new ArgumentNullException("Nulo en repositorioCliente");
            }
            this._repositorioCliente = repositorioCliente;
          
        }

            

        public Cliente Add(Cliente cliente)
        {
            var  customerNew =    _repositorioCliente.Cliente.Add(cliente);
            SaveChanges();
            
            return customerNew;
        }


        public int Delete(Cliente cliente) 
        {
            using (_repositorioCliente)
            {
                _repositorioCliente.Cliente.Remove(cliente);
                return _repositorioCliente.SaveChanges();
            }
            

        }

        public int Update(Cliente cliente) {
               // Entry(object entity) 
               //_repositorioCliente.Cliente.Entry(  Entry( .Entry(clientes) .State 

               // _repositorioCliente.Cliente. .State = EntityState.Modified;

               // _repositorioCliente.Cliente.Entry(cliente).State = EntityState.Modified;

                var UserBD = Get(cliente.Id);

                UserBD.Nombre = cliente.Nombre;
                UserBD.Phone = cliente.Phone;
                //_repositorioCliente.Update(cliente);

               return _repositorioCliente.SaveChanges();            
             }

        public Cliente Get(int id) {


            var Customer = _repositorioCliente.Cliente.Where(c => c.Id == id).FirstOrDefault();
                if (null != Customer)
                    return Customer;
         
            return new Cliente() ; 
        
        }

        public IEnumerable<Cliente> GetAll() {
            return _repositorioCliente.Cliente;        
        }

    }
}
