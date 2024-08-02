using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class Login : Form
    {
        public Login()
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
            NegocioUsuario auxUsuarioNegocio = new NegocioUsuario();
            Usuario auxUsuario = auxUsuarioNegocio.buscarUsuario(this.txtRutUsuario.Text);

            if (string.IsNullOrEmpty(auxUsuarioNegocio.buscarUsuario(auxUsuario.Rut).Rut))

            {
                MessageBox.Show("usuario no existe", "sistema");
            }

            else
            {

                if (auxUsuario.Cargo.Equals("administrador") && auxUsuario.Clave.Equals(this.txtClaveUsuario.Text))
                {
                    MessageBox.Show("login exitoso", "sistema");
                    PantallaMenu Pmenu = new PantallaMenu();
                    Pmenu.LabelPerfilUsuario.Text = auxUsuario.Cargo;
                    Pmenu.ShowDialog();
                    this.limpiar();
                }

                if (auxUsuario.Cargo.Equals("recepcionista") && auxUsuario.Clave.Equals(this.txtClaveUsuario.Text))
                {
                    MessageBox.Show("login exitoso", "sistema");
                    PantallaMenu Pmenu = new PantallaMenu();
                    Pmenu.LabelPerfilUsuario.Text = auxUsuario.Cargo;
                    Pmenu.ShowDialog();
                    this.limpiar();
                    

                }

                if (auxUsuario.Cargo.Equals("vendedor") && auxUsuario.Clave.Equals(this.txtClaveUsuario.Text))
                {
                    MessageBox.Show("login exitoso", "sistema");
                    PantallaMenu Pmenu = new PantallaMenu();
                    Pmenu.LabelPerfilUsuario.Text = auxUsuario.Cargo;
                    Pmenu.ShowDialog();
                    this.limpiar();
                    

                }
                
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.login();


        }

       

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

     

    
    }
}
