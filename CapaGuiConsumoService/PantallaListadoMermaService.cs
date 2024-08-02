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
    public partial class PantallaListadoMermaService : Form
    {
        public PantallaListadoMermaService()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServiceMantenedorMerma.WebServiceMantenedorMermaSoapClient auxNegocioMerma = new ServiceMantenedorMerma.WebServiceMantenedorMermaSoapClient();
            
            this.dataGridViewListadoMerma.DataSource = auxNegocioMerma.retornarMermaPorIdMermaService(this.txtIdMerma.Text);
            this.dataGridViewListadoMerma.DataMember = "merma";
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ServiceMantenedorMerma.WebServiceMantenedorMermaSoapClient auxNegocioMerma = new ServiceMantenedorMerma.WebServiceMantenedorMermaSoapClient();

            
            this.dataGridViewListadoMerma.DataSource = auxNegocioMerma.retornarMermaDetalleService();
            this.dataGridViewListadoMerma.DataMember = "merma";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
