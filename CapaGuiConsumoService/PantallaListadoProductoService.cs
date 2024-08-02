using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaGuiConsumoService
{
    public partial class PantallaListadoProductoService : Form
    {
        public PantallaListadoProductoService()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient auxNegocioProducto = new ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient();
            
            this.dataGridViewListadoProducto.DataSource = auxNegocioProducto.buscarCodigoProductoService(this.txtCodigo.Text);
            this.dataGridViewListadoProducto.DataMember = "producto";
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient auxNegocioProducto = new ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient();

            this.dataGridViewListadoProducto.DataSource = auxNegocioProducto.retornarTotalProductoService();
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
