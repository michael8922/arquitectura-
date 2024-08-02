using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class PantallaListadoSalidaProducto : Form
    {
        public PantallaListadoSalidaProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            this.dataGridViewListadoSalida.DataSource = auxNegocioSalida.buscarIdSalida(this.txtBuscar.Text);
            this.dataGridViewListadoSalida.DataMember = "salida_p";
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            this.dataGridViewListadoSalida.DataSource = auxNegocioSalida.retornarSalidaYDetalle();
            this.dataGridViewListadoSalida.DataMember = "salida_p";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            System.GC.Collect();
        }
    }
}
