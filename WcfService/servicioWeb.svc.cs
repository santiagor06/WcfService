using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "servicioWeb" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione servicioWeb.svc o servicioWeb.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class servicioWeb : IservicioWeb
    {
        Datos datos = new Datos();
        public string CrearCliente(Cliente cliente)
        {
            return cliente.Nombre + cliente.Direccion;
        }

        public string CreateCliente(Cliente cliente)
        {
            return datos.CreateCliente(cliente);
        }

        public List<Cliente> GetClientes()
        {
            return datos.GetClientes();
        }

        public string Saludo(string nombre)
        {
            return "Hola"+ nombre;
        }

        public string ValidarConexion()
        {
            
            return datos.ValidarConexion();
        }
    }
}
