using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEnMemoria
{
    public class Datos
    {
        private  List<Cliente> Clientes {  get; set; }

        public Datos()
        {
            Clientes = new List<Cliente>();
        }

        public void AgregarCliente(Cliente unCliente)
        {
            Clientes.Add(unCliente);
        }

        public void EliminarCliente(Cliente unCliente)
        {
            Clientes.Remove(unCliente);
        }

        public List<Cliente> ObtenerClientes()
        {
            return Clientes;
        }

        public Cliente ObtenerCliente(int idCliente)
        {
            return Clientes.FirstOrDefault(x => x.Id == idCliente);
        }

        public bool ExisteCliente(string unNombre)
        {
            return Clientes.FirstOrDefault(x => x.Nombre == unNombre) != null;

        }

    }
}
