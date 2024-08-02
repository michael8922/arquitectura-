using System;
using System.Collections;
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
    public partial class PantallaListadoCliente : Form
    {

        private ListadoCliente auxListadoClientePantallaListado;
        public PantallaListadoCliente()
        {
            InitializeComponent();

        }

        public ListadoCliente AuxListadoClientePantallaListado { get => auxListadoClientePantallaListado; set => auxListadoClientePantallaListado = value; }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            IEnumerator iter = this.auxListadoClientePantallaListado.LisCliente1.GetEnumerator();

            this.listBoxCliente.Items.Clear();

            while (iter.MoveNext()) 
            {
                Cliente auxCliente = new Cliente();
                auxCliente = (Cliente)iter.Current;
                this.listBoxCliente.Items.Add(auxCliente.Rut+ " " + auxCliente.Nombre );
            }

        }
    }
}
