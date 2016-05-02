using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IServiceCustomer
    {
        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json)]
        IEnumerable<Cliente> GetAll();

        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json, UriTemplate="Cliente/{id}")]
        Cliente GetClienteById(string id);

        [OperationContract]     //tipo dato   parametro
        [WebInvoke(UriTemplate = "AddCliente/",
            Method="POST")]
        Cliente AddCliente( Cliente cliente);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdateCliente/", Method="PUT")]
        int UpdateCliente(Cliente cliente);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteBook/", Method="DELETE")]
        int DeleteCliente(Cliente cliente);

        //Cliente Add(Cliente cliente);
        //int Delete(Cliente cliente);
        //int Update(Cliente cliente);
        //Cliente Get(int id);
        //IEnumerable<Cliente> GetAll();

        

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
