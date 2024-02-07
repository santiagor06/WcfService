using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class Datos
    {
        SqlConnection Conn=new SqlConnection("Data Source=LAPTOP-BRN5S8VP\\SQLEXPRESS;Initial Catalog=bdEjemplo;Integrated Security=True; Encrypt=False");
        public string ValidarConexion()
        {
            try { 
            Conn.Open();
            return Conn.State.ToString();
            }catch (Exception ex) { return ex.Message; }        
        }
        public List<Cliente>GetClientes()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clientes",Conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            List<Cliente>clientes = new List<Cliente>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                clientes.Add(
                    new Cliente() { Nombre = ds.Tables[0].Rows[i][0].ToString(), Direccion = ds.Tables[0].Rows[i][1].ToString(), Correo = ds.Tables[0].Rows[i][2].ToString(), Telefono = ds.Tables[0].Rows[i][3].ToString() });
            }
            return clientes;
        }
        public String CreateCliente(Cliente cliente)
        {
            string query = "INSERT INTO Clientes (Nombre, Direccion, Correo,Telefono)VALUES (@nombre,@dire,@email,@tel)";
            SqlCommand command= new SqlCommand(query, Conn);
            command.Parameters.Add("@nombre",SqlDbType.VarChar).Value=cliente.Nombre;
            command.Parameters.Add("@dire",SqlDbType.VarChar).Value=cliente.Direccion;
            command.Parameters.Add("@email",SqlDbType.VarChar).Value=cliente.Correo;
            command.Parameters.Add("@tel", SqlDbType.VarChar).Value = cliente.Telefono;
            Conn.Open();
            int respuesta=command.ExecuteNonQuery();
            Conn.Close();
            return "Se creo "+ respuesta;


        }
    }
}