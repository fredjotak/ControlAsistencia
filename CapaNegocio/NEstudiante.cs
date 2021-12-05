using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NEstudiante
    {
        DEstudiante estudiante = new DEstudiante();

        public DataTable listarEstudiante()
        {
            return estudiante.listarEstudiante();
        }

        public DataTable buscarEstudiante(string datoBuscar)
        {
            return estudiante.buscarEstudiante(datoBuscar);
        }

        public string crudEstudiante(int codEstudiante, int CI, string nombre, string apellidos, string telefono,int gestion, string accion)
        {
            return estudiante.crudEstudiante(new DEstudiante(codEstudiante, CI ,nombre, apellidos,telefono, gestion), accion);
        }

    }
}
