using Dominio;
using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaGraficos
{
    public partial class ListarClientes : UserControl
    {
        private LogicaDeCliente _logica;
        public ListarClientes(LogicaDeCliente logica)
        {
            _logica = logica;
            InitializeComponent();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            UpdateUserList();
            UpdateComboBoxClientes();
            lblEjemplo.Text = "El usuario no selecciono  nada";
        }

        private void UpdateUserList()
        {
            dgUserList.Columns.Clear();
            dgUserList.Rows.Clear();
            dgUserList.Columns.Add("id", "ID");
            dgUserList.Columns.Add("name", "Nombre");
            dgUserList.Columns.Add("esSocio", "Es socio");
            List<Cliente> clientes = _logica.ObtenerClientes();
            foreach (Cliente unCliente in clientes)
            {
                string esSocio = "NO";
                if (unCliente.EsSocio)
                {
                    esSocio = "SI";
                }
                dgUserList.Rows.Add(unCliente.Id, unCliente.Nombre, esSocio);
            }
        }

        private void UpdateComboBoxClientes()
        {
            List<Cliente> clientes = _logica.ObtenerClientes();
            cbClientes.DataSource = clientes;
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)cbClientes.SelectedItem;
            lblEjemplo.Text = "El usuario  selecciono :" + clienteSeleccionado.Nombre + " y su id es: "+ clienteSeleccionado.Id;
        }

        private void PrintSelectedRow(object sender, EventArgs e)
        {
            var selected = dgUserList.SelectedRows[0];
            Console.WriteLine(selected.Cells["id"].Value);
        }
    }
}
