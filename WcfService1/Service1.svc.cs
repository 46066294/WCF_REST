using Dominio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IServiceCustomer
    {

        readonly IOperacion _serviceCustomer;

        public Service1(IOperacion serviceCustomer) 
        {
            _serviceCustomer = serviceCustomer;
        }

        
        
        public IEnumerable<Cliente> GetAll() 
        {
            return _serviceCustomer.GetAll();
        }

        public Cliente GetClienteById(string id)
        {
            int cl = Convert.ToInt32(id);
            return _serviceCustomer.Get(cl);
        }

        public Cliente AddCliente(Cliente cliente)
        {
            return _serviceCustomer.Add(cliente);
        }

        public int UpdateCliente(Cliente cliente)
        {
            return _serviceCustomer.Update(cliente);
        }

        public int DeleteCliente(Cliente cliente)
        {
            return _serviceCustomer.Delete(cliente);
        }





        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
