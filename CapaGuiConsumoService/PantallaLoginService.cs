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
    public partial class PantallaLoginService : Form
    {
        public PantallaLoginService()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            this.txtRutUsuario.Text = "";
            this.txtClaveUsuario.Text = "";
        }

        private void login()


        {
            ServiceMantenedorUsuario.WebServiceMantenedorUsuarioSoapClient auxNegocioUsuario = new ServiceMantenedorUsuario.WebServiceMantenedorUsuarioSoapClient();
            ServiceMantenedorUsuario.Usuario auxUsuario = auxNegocioUsuario.buscarUsuarioService(this.txtRutUsuario.Text);


            if (this.txtRutUsuario.Text == "" || this.txtClaveUsuario.Text == "" )
            {
                MessageBox.Show("complete todos los campos", "sistema");
            }
            else
            {
                if (string.IsNullOrEmpty(auxNegocioUsuario.buscarUsuarioService(auxUsuario.Rut).Rut))

                {
                    MessageBox.Show("usuario no existe", "sistema");
                }

                else
                {

                    if (auxUsuario.Cargo.Equals("administrador") && auxUsuario.Clave.Equals(this.txtClaveUsuario.Text))
                    {
                        MessageBox.Show("login exitoso", "sistema");
                        PantallaMenuService Pmenu = new PantallaMenuService();
                        Pmenu.LabelPerfilUsuario.Text = auxUsuario.Cargo;
                        Pmenu.LabelNombre.Text = auxUsuario.Nombre;
                        Pmenu.ShowDialog();
                        this.limpiar();

                    }

                    if (auxUsuario.Cargo.Equals("recepcionista") && auxUsuario.Clave.Equals(this.txtClaveUsuario.Text))
                    {
                        MessageBox.Show("login exitoso", "sistema");
                        PantallaMenuService Pmenu = new PantallaMenuService();
                        Pmenu.LabelPerfilUsuario.Text = auxUsuario.Cargo;
                        Pmenu.LabelNombre.Text = auxUsuario.Nombre;
                        Pmenu.ShowDialog();
                        this.limpiar();


                    }

                    if (auxUsuario.Cargo.Equals("vendedor") && auxUsuario.Clave.Equals(this.txtClaveUsuario.Text))
                    {
                        MessageBox.Show("login exitoso", "sistema");
                        PantallaMenuService Pmenu = new PantallaMenuService();
                        Pmenu.LabelPerfilUsuario.Text = auxUsuario.Cargo;
                        Pmenu.LabelNombre.Text = auxUsuario.Nombre;
                        Pmenu.ShowDialog();
                        this.limpiar();


                    }

                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.login();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
