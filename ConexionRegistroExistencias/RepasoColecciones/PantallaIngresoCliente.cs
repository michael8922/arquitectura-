using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoColecciones
{
    public partial class PantallaIngresoCliente : Form
    {

        private ListadoCliente auxListadoClientePantallaIngreso;

        public ListadoCliente AuxListadoClientePantallaIngreso { get => auxListadoClientePantallaIngreso; set => auxListadoClientePantallaIngreso = value; }

        public PantallaIngresoCliente()
        {
            InitializeComponent();
            this.auxListadoClientePantallaIngreso = new ListadoCliente();
        }

        private void PantallaIngresoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            PantallaListadoCliente pListado = new PantallaListadoCliente();
            pListado.AuxListadoClientePantallaListado = this.auxListadoClientePantallaIngreso;
            pListado.ShowDialog();
        }

        private void btoguardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente auxCliente = new Cliente();
                auxCliente.Rut = this.txtrut.Text;
                auxCliente.Nombre = this.txtnombre.Text;

                this.auxListadoClientePantallaIngreso.agregaCliente(auxCliente);
                MessageBox.Show("datos guardados", "sistema");
                this.txtrut.Clear();
                this.txtnombre.Clear();
                this.txtrut.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("datos no guardados" + ex.Message, "sistema");
            }
        }
    }
}
