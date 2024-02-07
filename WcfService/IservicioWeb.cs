using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IservicioWeb" en el código y en el archivo de configuración a la vez.
    [ServiceContract(Name ="servicioEjemplo")]
    public interface IservicioWeb
    {
        [OperationContract (Name ="OperacionSaludo")]
        string Saludo(string nombre);
        [OperationContract]
        string CrearCliente(Cliente cliente);
        [OperationContract]
        string ValidarConexion();
        [OperationContract]
        List<Cliente>GetClientes();
        [OperationContract]
        string CreateCliente(Cliente cliente);
    }
}
