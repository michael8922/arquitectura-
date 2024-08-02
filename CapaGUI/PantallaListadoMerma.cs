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
    public partial class PantallaListadoMerma : Form
    {
        public PantallaListadoMerma()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioMerma auxNegocioIngreso = new NegocioMerma();
            this.dataGridViewListadoMerma.DataSource = auxNegocioIngreso.retornarMermaPorIdMerma(this.txtIdMerma.Text);
            this.dataGridViewListadoMerma.DataMember = "merma";
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            NegocioMerma auxNegocioIngreso = new NegocioMerma();
            this.dataGridViewListadoMerma.DataSource = auxNegocioIngreso.retornarMermaDetalle();
            this.dataGridViewListadoMerma.DataMember = "merma";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
