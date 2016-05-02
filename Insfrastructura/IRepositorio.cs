using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insfrastructura
{
    public interface IRepositorio : IUnitOfWork
    {
        IDbSet<Cliente> Cliente { get; set; }
        //void Update<T>(T entity) where T : class; 

    }
}
