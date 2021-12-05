using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DClientes
    {
        private int codCliente;
        private String nombres { get; set; }
        private String apellidos { get; set; }
        private String CI { get; set; }
        private int telefono { get; set; }

        public DClientes()
        {

        }

        public DClientes(int codCliente,string nombres, string apellidos, string CI, int telefono)
        {
            this.codCliente = codCliente;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.CI = CI;
            this.telefono = telefono;
        }

        public DataTable listarCliente()
        {
            SqlConnection SqlConec = new SqlConnection();

            SqlConec.ConnectionString = Conexion.conexion;
            SqlConec.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlConec;
            SqlCmd.CommandText = "SELECT * FROM clientes;";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SqlCmd);

            /*da.Fill(dt);
            SqlConec.Close();*/
            return dt;
        }


        public string crudCliente(DClientes cliente,string accion)
        {
            string rpta = "";
            SqlConnection SqlConec = new SqlConnection();
        
                SqlConec.ConnectionString = Conexion.conexion;
                SqlConec.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlConec;

                if(accion == "1")
                {
                    SqlCmd.CommandText = "INSERT INTO clientes VALUES('" + cliente.nombres + "','" + cliente.apellidos + "','" + cliente.CI + "'," + cliente.telefono + ");";
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "El cliente fue registrado correctamente" : "NO SE REGISTRO EL CLIENTE";
                }
                else if (accion == "2")
                {
                    SqlCmd.CommandText = "UPDATE clientes SET nombres='"+ cliente.nombres +"', apellidos='"+ cliente.apellidos +"', DNI='"+ cliente.CI +"', telefono = "+ cliente.telefono +" WHERE codCliente = "+ cliente.codCliente +";";
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "El cliente fue modificado correctamente" : "NO SE MODIFICO EL REGISTRO DEL CLIENTE";
                }else
                {
                    SqlCmd.CommandText = "DELETE FROM clientes WHERE codCliente = "+ cliente.codCliente + ";";
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "El cliente fue eliminado correctamente" : "NO SE ELIMINO EL REGISTRO SELECCIONADO";
                }
            SqlConec.Close();
            return rpta;
        }


        public DataTable buscarCliente(string DNI) 
        {
            SqlConnection SqlConec = new SqlConnection();
            DClientes cliente = new DClientes();

            SqlConec.ConnectionString = Conexion.conexion;
            SqlConec.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlConec;

            SqlCmd.CommandText = "SELECT codCliente, nombres, apellidos, DNI FROM clientes WHERE DNI LIKE '" + DNI + "' + '%';";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SqlCmd);

            da.Fill(dt);

            SqlConec.Close();

            return dt;

        }
    }
}
