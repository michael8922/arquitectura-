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
    public partial class PantallaMenuService : Form
    {
        public PantallaMenuService()
        {
            InitializeComponent();
        }

        public void OtorgarPermiso()
        {
            if (this.LabelPerfilUsuario.Text == "administrador")
            {
                this.btnUsuario.Visible = true;
                this.btnProducto.Visible = true;
                this.btnProveedor.Visible = true;
                this.btnIngresoProducto.Visible = true;
                this.btnSalidaProducto.Visible = true;
                this.btnMerma.Visible = true;
                this.btnUbicacion.Visible = true;
                this.btnConsultaSaldo.Visible = true;

            }
            if (this.LabelPerfilUsuario.Text == "recepcionista")
            {
                this.btnUsuario.Visible = false;
                this.btnProducto.Visible = false;
                this.btnProveedor.Visible = false;
                this.btnIngresoProducto.Visible = true;
                this.btnSalidaProducto.Visible = false;
                this.btnMerma.Visible = true;
                this.btnUbicacion.Visible = false;
                this.btnConsultaSaldo.Visible = true;
            }
            if (this.LabelPerfilUsuario.Text == "vendedor")
            {
                this.btnUsuario.Visible = false;
                this.btnProducto.Visible = false;
                this.btnProveedor.Visible = false;
                this.btnIngresoProducto.Visible = false;
                this.btnSalidaProducto.Visible = true;
                this.btnMerma.Visible = true;
                this.btnUbicacion.Visible = true;
                this.btnConsultaSaldo.Visible = true;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        private void diseño()
        {

            this.panelSubMenuUsuario.Visible = false;
            this.panelSubMenuProducto.Visible = false;
            this.panelSubMenuProveedor.Visible = false;
            this.panelSubMenuIngresoProducto.Visible = false;
            this.panelSubMenuSalidaProducto.Visible = false;
            this.panelSubMenuMerma.Visible = false;
            this.panelSubMenuUbicacion.Visible = false;
            this.panelSubMenuConsultaSaldo.Visible = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void activarSubMenu()
        {
            if (this.panelSubMenuUsuario.Visible == true)
            {
                this.panelSubMenuUsuario.Visible = false;
            }
            if (this.panelSubMenuProducto.Visible == true)
            {
                this.panelSubMenuProducto.Visible = false;
            }
            if (this.panelSubMenuProveedor.Visible == true)
            {
                this.panelSubMenuProveedor.Visible = false;
            }
            if (this.panelSubMenuIngresoProducto.Visible == true)
            {
                this.panelSubMenuIngresoProducto.Visible = false;
            }
            if (this.panelSubMenuSalidaProducto.Visible == true)
            {
                this.panelSubMenuSalidaProducto.Visible = false;
            }
            if (this.panelSubMenuMerma.Visible == true)
            {
                this.panelSubMenuMerma.Visible = false;
            }
            if (this.panelSubMenuUbicacion.Visible == true)
            {
                this.panelSubMenuUbicacion.Visible = false;
            }
            if (this.panelSubMenuConsultaSaldo.Visible == true)
            {
                this.panelSubMenuConsultaSaldo.Visible = false;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                this.activarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)

            activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(childForm);
            panelFormulario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        //------------------------------------------------------------------------------------------------------------------------------------
        

        private void PantallaMenu_Load(object sender, EventArgs e)
        {
            
                this.diseño();
                this.OtorgarPermiso();
            
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.mostrarSubMenu(this.panelSubMenuUsuario);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.mostrarSubMenu(this.panelSubMenuProducto);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.mostrarSubMenu(this.panelSubMenuProveedor);
        }

        private void btnIngresoProducto_Click(object sender, EventArgs e)
        {
            this.mostrarSubMenu(this.panelSubMenuIngresoProducto);
        }

        private void btnSalidaProducto_Click(object sender, EventArgs e)
        {
            this.mostrarSubMenu(this.panelSubMenuSalidaProducto);
        }

        private void btnMerma_Click(object sender, EventArgs e)
        {
            this.mostrarSubMenu(this.panelSubMenuMerma);
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            this.mostrarSubMenu(this.panelSubMenuUbicacion);
        }

        private void btnConsultaSaldo_Click(object sender, EventArgs e)
        {
            this.mostrarSubMenu(this.panelSubMenuConsultaSaldo);
        }


        //------------------------------------------------------------------------------------------------------------------------------------
        


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaMantenedorProductoService());
            this.activarSubMenu();
        }

        private void btnListadoProducto_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaListadoProductoService());
            this.activarSubMenu();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaMantenedorUsuarioService());
            this.activarSubMenu();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaMantenedorProveedorService());
            this.activarSubMenu();
        }

        private void btnAgregarIngresoProducto_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaIngresoProductoService());
            this.activarSubMenu();
        }

        private void btnListadoIngresoProducto_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaListadoIngresoProductoService());
            this.activarSubMenu();
        }

        private void btnAgregarSalidaProducto_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaSalidaProductoService());
            this.activarSubMenu();
        }

        private void btnListadoSalidaProducto_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaListadoSalidaProductoService());
            this.activarSubMenu();
        }

        private void btnAgregarMerma_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaMantenedorMermaService());
            this.activarSubMenu();
        }

        private void btnListadoMerma_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaListadoMermaService());
            this.activarSubMenu();
        }

        private void btnAgregarUbicacion_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaMantenedorUbicacionService());
            this.activarSubMenu();
        }

        private void btnBuscarSaldo_Click(object sender, EventArgs e)
        {
            openChildForm(new PantallaConsultaSaldoService());
            this.activarSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
    
}
