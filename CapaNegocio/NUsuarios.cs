using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NUsuarios
    {
        DUsuarios usuarios = new DUsuarios();

        public bool loginUser(string usuario, string contraseña)
        {
            return usuarios.login(usuario, contraseña);
        }

        public DataTable listarUsuarios()
        {
            return usuarios.listarUsuiarios();
        }

        public DataTable buscarProducto(string datoBuscar)
        {
            return usuarios.buscarProducto(datoBuscar);
        }

        public string crudUsuario(int codUsuario, string nombre, string apellidos, string nivel, string accion)
        {
            return usuarios.crudUsuario(new DUsuarios(codUsuario, nombre, apellidos, nivel), accion);
        }
    }
}
