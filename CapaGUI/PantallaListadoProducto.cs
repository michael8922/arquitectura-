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
    public partial class PantallaListadoProducto : Form
    {
        public PantallaListadoProducto()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            this.dataGridViewListadoProducto.DataSource = auxNegocioProducto.buscarCodigoProducto(this.txtCodigo.Text);
            this.dataGridViewListadoProducto.DataMember = "producto";
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            this.dataGridViewListadoProducto.DataSource = auxNegocioProducto.retornarTotalProducto();
            this.dataGridViewListadoProducto.DataMember = "producto";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            System.GC.Collect();
        }
    }
}
