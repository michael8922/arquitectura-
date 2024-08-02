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
    public partial class PantallaListadoIngresoProductoService : Form
    {
        public PantallaListadoIngresoProductoService()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient auxNegocioIngreso = new ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient();

            
            this.dataGridViewListadoIngreso.DataSource = auxNegocioIngreso.buscarPorIdIngresoService(this.txtIdIngreso.Text);
            this.dataGridViewListadoIngreso.DataMember = "ingreso_p";
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient auxNegocioIngreso = new ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient();

            this.dataGridViewListadoIngreso.DataSource = auxNegocioIngreso.retornarIngresoProductoService();
            this.dataGridViewListadoIngreso.DataMember = "ingreso_p";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            System.GC.Collect();
        }
    }
}
