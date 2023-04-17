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
    public partial class PantallaPrincipal : Form
    {
        private LogicaDeCliente _logica;
        public PantallaPrincipal()
        {
            _logica = new LogicaDeCliente();
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            UserControl agregarCliente = new AgregarCliente(_logica);
            controlPanel.Controls.Add(agregarCliente);
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            UserControl agregarCliente = new ListarClientes(_logica);
            controlPanel.Controls.Add(agregarCliente);
        }

        private void btn_subirArchivo_click(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            UserControl subirArchivo = new SubirArchivo(_logica);
            controlPanel.Controls.Add(subirArchivo);
        }
    }
}
