using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEstudiante
    {
        private int codEstudiante { get; set; }
        private int CI { get; set; }
        private String nombre { get; set; }
        private String apellidos { get; set; }
        private String celular { get; set; }
        private int gestion { get; set; }

        public DEstudiante()
        {

        }

        public DEstudiante(int codEstudiante, int CI, string nombre, string apellidos, string celular, int gestion)
        {
            this.codEstudiante = codEstudiante;
            this.CI = CI;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.celular = celular;
            this.gestion = gestion;
        }

        public DataTable listarEstudiante()
        {
            SqlConnection SqlConec = new SqlConnection();

            SqlConec.ConnectionString = Conexion.conexion;
            SqlConec.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlConec;
            SqlCmd.CommandText = "SELECT * FROM estudiantes;";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SqlCmd);

            da.Fill(dt);

            return dt;
        }

        public DataTable buscarEstudiante(string datoBuscar)
        {
            SqlConnection SqlConec = new SqlConnection();

            SqlConec.ConnectionString = Conexion.conexion;
            SqlConec.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlConec;

            SqlCmd.CommandText = "SELECT * FROM estudiantes WHERE nombre LIKE '%' + '" + datoBuscar + "' + '%';";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SqlCmd);

            da.Fill(dt);
            SqlConec.Close();

            return dt;
        }

        public string crudEstudiante(DEstudiante estudiante, string accion)
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
                SqlCmd.CommandText = "insertar_estudiante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parCI = new SqlParameter();
                parCI.ParameterName = "@ci";
                parCI.SqlDbType = SqlDbType.Int;
                parCI.Value = estudiante.CI;
                SqlCmd.Parameters.Add(parCI);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombres";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 30;
                parNombre.Value = estudiante.nombre;
                SqlCmd.Parameters.Add(parNombre);

                SqlParameter parApellido = new SqlParameter();
                parApellido.ParameterName = "@apellidos";
                parApellido.SqlDbType = SqlDbType.VarChar;
                parApellido.Size = 50;
                parApellido.Value = estudiante.apellidos;
                SqlCmd.Parameters.Add(parApellido);

                SqlParameter parCelular = new SqlParameter();
                parCelular.ParameterName = "@celular";
                parCelular.SqlDbType = SqlDbType.VarChar;
                parCelular.Size = 10;
                parCelular.Value = estudiante.celular;
                SqlCmd.Parameters.Add(parCelular);

                SqlParameter parGestion = new SqlParameter();
                parGestion.ParameterName = "@gestion";
                parGestion.SqlDbType = SqlDbType.Int;
                parGestion.Value = estudiante.gestion;
                SqlCmd.Parameters.Add(parGestion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Error insertar estudiante" : "Se añadio nuevo estudiante";

            }
            else if (accion == "2") // editar usuario
            {
                SqlCmd.Connection = SqlConec;
                SqlCmd.CommandText = "editar_estudiante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parCI = new SqlParameter();
                parCI.ParameterName = "@ci";
                parCI.SqlDbType = SqlDbType.Int;
                parCI.Value = estudiante.CI;
                SqlCmd.Parameters.Add(parCI);

                SqlParameter parIdEstudiante = new SqlParameter();
                parIdEstudiante.ParameterName = "@id_estudiante";
                parIdEstudiante.SqlDbType = SqlDbType.Int;
                parIdEstudiante.Value = estudiante.codEstudiante;
                SqlCmd.Parameters.Add(parIdEstudiante);

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@nombres";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 30;
                parNombre.Value = estudiante.nombre;
                SqlCmd.Parameters.Add(parNombre);

                SqlParameter parApellido = new SqlParameter();
                parApellido.ParameterName = "@apellidos";
                parApellido.SqlDbType = SqlDbType.VarChar;
                parApellido.Size = 50;
                parApellido.Value = estudiante.apellidos;
                SqlCmd.Parameters.Add(parApellido);

                SqlParameter parCelular = new SqlParameter();
                parCelular.ParameterName = "@celular";
                parCelular.SqlDbType = SqlDbType.VarChar;
                parCelular.Size = 10;
                parCelular.Value = estudiante.celular;
                SqlCmd.Parameters.Add(parCelular);

                SqlParameter parGestion = new SqlParameter();
                parGestion.ParameterName = "@gestion";
                parGestion.SqlDbType = SqlDbType.Int;
                parGestion.Value = estudiante.gestion;
                SqlCmd.Parameters.Add(parGestion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Error actualizar estudiante" : "Se actualizo estudiante";

            }
            else // eliminar
            {
                SqlCmd.Connection = SqlConec;
                SqlCmd.CommandText = "eliminar_estudiante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdEstudiante = new SqlParameter();
                parIdEstudiante.ParameterName = "@id_estudiante";
                parIdEstudiante.SqlDbType = SqlDbType.Int;
                parIdEstudiante.Value = estudiante.codEstudiante;
                SqlCmd.Parameters.Add(parIdEstudiante);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Se elimino correctamente el estudiante" : "Error al eliminar estudiante";
            }
            SqlConec.Close();
            return rpta;
        }

    }
}
