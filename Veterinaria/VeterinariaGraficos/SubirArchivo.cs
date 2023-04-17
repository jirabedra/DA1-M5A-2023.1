using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaGraficos
{
    public partial class SubirArchivo : UserControl
    {
        private LogicaDeCliente _logica;
        public SubirArchivo(LogicaDeCliente logicaDeCliente)
        {
            this._logica = logicaDeCliente;
            InitializeComponent();
        }

        private void btn_subirArchivo_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                try
                {
                    _logica.ImprimirArchivo(file);
                }
                catch (IOException)
                {
                }
            }

        }
    }
}
