using Insfrastructura;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ServiceBase : IDisposable
    {
        readonly IUnitOfWork _unitOfWork ;

        public ServiceBase(IUnitOfWork unitOfWork)
        {
            if (null == unitOfWork) {
                throw new ArgumentNullException("Nulo en unitOfWork");
            }
            _unitOfWork = unitOfWork;

        }

        public int SaveChanges()
        {
            return _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();

        }

    }
}
