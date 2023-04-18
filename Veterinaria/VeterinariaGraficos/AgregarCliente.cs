using Dominio;
using Excepciones;
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
    public partial class AgregarCliente : UserControl
    {
        private LogicaDeCliente _logica;

        public AgregarCliente(LogicaDeCliente logica)
        {
            _logica = logica;
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {


        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente()
            {
                Id = (int)nupId.Value,
                Nombre = txtNombre.Text,
                FechaDeNacimiento = dtpFechaNacimiento.Value,
                EsSocio = cbEsSocio.Checked,
            };
            try
            {
                _logica.AgregarCliente(nuevoCliente);
                System.Windows.Forms.MessageBox.Show("Usuario agregado");
            }catch(ClienteExceptions ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreChanged(object sender, EventArgs e)
        {
            
        }
    }
}
