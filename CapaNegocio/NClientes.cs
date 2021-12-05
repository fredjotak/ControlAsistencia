using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NClientes
    {
        DClientes cliente = new DClientes();

        public DataTable listarClientes()
        {
            return cliente.listarCliente();
        }

        public string crudClientes(int codCliente, string nombre, string apellidos, string CI, int telefono,string accion)
        {
            return cliente.crudCliente(new DClientes(codCliente,nombre,apellidos,CI,telefono),accion);
        }

        public DataTable buscarClientes(string datoBuscar)
        {
            return cliente.buscarCliente(datoBuscar);
        }

    }
}
