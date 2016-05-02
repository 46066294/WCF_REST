using Dominio;
using Insfrastructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public interface IOperacion 
    {
        Cliente Add(Cliente cliente);
        int Delete(Cliente cliente);
        int Update(Cliente cliente);
        Cliente Get(int id);
        IEnumerable<Cliente> GetAll();
       

    }
}
