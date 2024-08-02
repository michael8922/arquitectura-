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
    public partial class PantallaConsultaSaldoService : Form
    {
        public PantallaConsultaSaldoService()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient auxNegocioProducto = new ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient();

            
            this.dataGridViewStockProducto.DataSource = auxNegocioProducto.retornarStockProductoService(this.txtCodigo.Text);
            this.dataGridViewStockProducto.DataMember = "producto";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
