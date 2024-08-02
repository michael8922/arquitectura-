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
    public partial class PantallaConsultaSaldo : Form
    {
        public PantallaConsultaSaldo()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            this.dataGridViewStockProducto.DataSource = auxNegocioProducto.retornarStockProducto(this.txtCodigo.Text);
            this.dataGridViewStockProducto.DataMember = "producto";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
