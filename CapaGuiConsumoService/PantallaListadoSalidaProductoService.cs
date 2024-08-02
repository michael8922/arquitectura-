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
    public partial class PantallaListadoSalidaProductoService : Form
    {
        public PantallaListadoSalidaProductoService()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient auxNegocioSalida = new ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient();
            
            
            this.dataGridViewListadoSalida.DataSource = auxNegocioSalida.buscarIdSalidaService(this.txtBuscar.Text);
            this.dataGridViewListadoSalida.DataMember = "salida_p";
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient auxNegocioSalida = new ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient();
            
            this.dataGridViewListadoSalida.DataSource = auxNegocioSalida.retornarSalidaYDetalleService();
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
