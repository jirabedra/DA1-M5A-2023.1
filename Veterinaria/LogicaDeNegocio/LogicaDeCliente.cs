using DatosEnMemoria;
using Dominio;
using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class LogicaDeCliente
    {
        private readonly Datos _datos;

        public LogicaDeCliente()
        {
            _datos = new Datos();
        }

        public void AgregarCliente(Cliente unCliente)
        {
            if (ExisteCliente(unCliente.Nombre))
            {
                throw new ClienteExceptions("Ya existe un cliente con el nombre: " + unCliente.Nombre);
            }
            _datos.AgregarCliente(unCliente);
        }

        public void EliminarCliente(Cliente unCliente)
        {
            _datos.EliminarCliente(unCliente);
        }

        public List<Cliente> ObtenerClientes()
        {
            return _datos.ObtenerClientes();
        }

        public Cliente ObtenerCliente(int idCliente)
        {
            return _datos.ObtenerCliente(idCliente);
        }

        public void ImprimirArchivo(string file)
        {
            try
            {
                string text = File.ReadAllText(file+"0000");
                Console.WriteLine(text);
            }
            catch (IOException ex)
            {
                throw new ClienteExceptions("El archivo no existe", ex);
            }

        }

        public bool ExisteCliente(string unNombre)
        {
            return _datos.ExisteCliente(unNombre);

        }


    }
}
