using CapaControladorVista.Configuraciones;
using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity.Core.Objects;
namespace Insfrastructura
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

   public partial class AppContext :DbContext, IUnitOfWork , IRepositorio
    {
       public AppContext()
          :base("DefaultConnection")
       {

       }
       
       public IDbSet<Cliente> Cliente { get; set; }

      /* public void Update<T>(T entity) where T : class { 
              this.Entry(entity).State = EntityState.Modified;
       } */ 

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {

           var cn = this.Database.Connection.ConnectionString;

           modelBuilder.Configurations.Add(new ClienteConfiguracion());

           base.OnModelCreating(modelBuilder);

           //throw new UnintentionalCodeFirstException();

       }
       
    }
}
