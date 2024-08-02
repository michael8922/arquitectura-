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
    public partial class PantallaListadoIngresoProducto : Form
    {
        public PantallaListadoIngresoProducto()
        {
            InitializeComponent();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            Negocio_Ingreso_P auxNegocioIngreso = new Negocio_Ingreso_P();
            this.dataGridViewListadoIngreso.DataSource = auxNegocioIngreso.retornarIngresoProducto();
            this.dataGridViewListadoIngreso.DataMember = "ingreso_p";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Negocio_Ingreso_P auxNegocioIngreso = new Negocio_Ingreso_P();
            this.dataGridViewListadoIngreso.DataSource = auxNegocioIngreso.buscarPorIdIngreso(this.txtIdIngreso.Text);
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
