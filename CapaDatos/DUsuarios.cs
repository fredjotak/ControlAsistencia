using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaDatos
{
    public class DUsuarios
    {
            private int codUsuario { get; set; }
            private String nombre { get; set; }
            private String apellidos { get; set; }
            private String nivel { get; set; }

            public DUsuarios()
            {

            }

            public DUsuarios(int codUsuario, string nombre, string apellidos, String nivel)
            {
                this.codUsuario = codUsuario;
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.nivel = nivel;
            }

            public DataTable listarUsuiarios()
            {
                SqlConnection SqlConec = new SqlConnection();

                SqlConec.ConnectionString = Conexion.conexion;
                SqlConec.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlConec;
                SqlCmd.CommandText = "SELECT id_usuario, nombre, apellidos, nivel FROM usuarios;";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(SqlCmd);

                da.Fill(dt);

                return dt;
            }

            public DataTable buscarProducto(string datoBuscar)
            {
                SqlConnection SqlConec = new SqlConnection();

                SqlConec.ConnectionString = Conexion.conexion;
                SqlConec.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlConec;

                SqlCmd.CommandText = "SELECT * FROM usuarios WHERE id_usuario LIKE '%' + '" + datoBuscar + "' + '%';";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(SqlCmd);

                da.Fill(dt);
                SqlConec.Close();

                return dt;
            }

        public string crudUsuario(DUsuarios cliente, string accion)
        {
            string rpta = "";
            SqlConnection SqlConec = new SqlConnection();

            SqlConec.ConnectionString = Conexion.conexion;
            SqlConec.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlConec;

            if (accion == "1") // insertar usuario
            {
                SqlCmd.Connection = SqlConec;
                SqlCmd.CommandText = "insertar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombres";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = cliente.nombre;
                SqlCmd.Parameters.Add(parNombre);

                SqlParameter parApellido = new SqlParameter();
                parApellido.ParameterName = "@apellidos";
                parApellido.SqlDbType = SqlDbType.VarChar;
                parApellido.Size = 60;
                parApellido.Value = cliente.apellidos;
                SqlCmd.Parameters.Add(parApellido);

                SqlParameter parNivel = new SqlParameter();
                parNivel.ParameterName = "@nivel";
                parNivel.SqlDbType = SqlDbType.VarChar;
                parNivel.Size = 30;
                parNivel.Value = cliente.nivel;
                SqlCmd.Parameters.Add(parNivel);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Error insertar usuario" : "Se añadio nuevo usuario";

            }
            else if (accion == "2") // editar usuario
            {
                SqlCmd.Connection = SqlConec;
                SqlCmd.CommandText = "editar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdUsuario = new SqlParameter();
                parIdUsuario.ParameterName = "@id_usuario";
                parIdUsuario.SqlDbType = SqlDbType.Int;
                parIdUsuario.Value = cliente.codUsuario;
                SqlCmd.Parameters.Add(parIdUsuario);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombres";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = cliente.nombre;
                SqlCmd.Parameters.Add(parNombre);

                SqlParameter parApellido = new SqlParameter();
                parApellido.ParameterName = "@apellidos";
                parApellido.SqlDbType = SqlDbType.VarChar;
                parApellido.Size = 60;
                parApellido.Value = cliente.apellidos;
                SqlCmd.Parameters.Add(parApellido);

                SqlParameter parNivel = new SqlParameter();
                parNivel.ParameterName = "@nivel";
                parNivel.SqlDbType = SqlDbType.VarChar;
                parNivel.Size = 30;
                parNivel.Value = cliente.nivel;
                SqlCmd.Parameters.Add(parNivel);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Error actualizar usuario" : "Se actualizo usuario";
            }
            else // eliminar
            {
                SqlCmd.Connection = SqlConec;
                SqlCmd.CommandText = "eliminar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdUsuario = new SqlParameter();
                parIdUsuario.ParameterName = "@id_usuario";
                parIdUsuario.SqlDbType = SqlDbType.Int;
                parIdUsuario.Value = cliente.codUsuario;
                SqlCmd.Parameters.Add(parIdUsuario);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Se elimino correctamente para el usuario" : "Error al eliminar usuario";
            }
            SqlConec.Close();
            return rpta;
        }

        public bool login(string user, string contraseña)
        {
            
            SqlConnection SqlConec = new SqlConnection();

                SqlConec.ConnectionString = Conexion.conexion;
                SqlConec.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlConec;
                SqlCmd.CommandText = "SELECT * FROM usuarios WHERE HASHBYTES('sha1', usuario) = HASHBYTES('sha1', '" + user + "') AND HASHBYTES('sha1', CONVERT(VARCHAR(40), DECRYPTBYPASSPHRASE('secreto', contrasenia))) = HASHBYTES('sha1', '" + contraseña + "')";

                SqlDataReader reader = SqlCmd.ExecuteReader();

            bool ConecExito = reader.HasRows;
            if (SqlConec.State == ConnectionState.Open) SqlConec.Close();

            if (ConecExito)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
