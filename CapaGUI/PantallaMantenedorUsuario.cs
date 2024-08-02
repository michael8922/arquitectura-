using CapaDTO;
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
    public partial class PantallaMantenedorUsuario : Form
    {
        public PantallaMantenedorUsuario()
        {
            InitializeComponent();
        }

        private int posicion;
        private int ultimo;



        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        //-------------------------------------------------------------------------------------------------------------------------------------------


        public void desHabilitar()
        {
            this.txtRut.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtClave.Enabled = false;
            this.comboBoxCargo.Enabled = false;
        }
        
        public void habilitar()
        {
            this.txtRut.Enabled = true;
            this.txtNombre.Enabled = true;
            this.txtClave.Enabled = true;
            this.comboBoxCargo.Enabled = true;
            this.comboBoxCargo.DropDownStyle = ComboBoxStyle.DropDownList;          

        }
        
        public void limpiar()
        {
            this.txtRut.Text = "";
            this.txtNombre.Text = "";
            this.txtClave.Text = "";
            this.comboBoxCargo.Text = "";
            
        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        public void mostrarUsuario()
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            Usuario auxUsuario = new Usuario();
            this.ultimo = auxNegocioUsuario.retornarUsuario().Tables["usuario"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= ultimo)
                this.posicion = ultimo;

            auxUsuario = auxNegocioUsuario.retornaPosicionUsuario(this.posicion);
            this.txtRut.Text = auxUsuario.Rut;
            this.txtNombre.Text = auxUsuario.Nombre;
            this.txtClave.Text = auxUsuario.Clave;
            this.comboBoxCargo.Text = auxUsuario.Cargo;

        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.btnAgregar.Text.Equals("guardar"))
            {
                this.habilitar();
                this.btnAgregar.Text = "confirmar";
                this.btnEliminar.Text = "cancelar";
                this.limpiar();
                this.btnSiguiente.Visible = false;
                this.btnAnterior.Visible = false;              
                this.btnModificar.Visible = false;
            }
            else
            {
                try
                {
                    Usuario auxUsuario = new Usuario();
                    auxUsuario.Rut = this.txtRut.Text;
                    auxUsuario.Nombre = this.txtNombre.Text;
                    auxUsuario.Clave = this.txtClave.Text;
                    auxUsuario.Cargo = this.comboBoxCargo.Text;
                    NegocioUsuario auxNegocioUsuario = new NegocioUsuario();

                    if (String.IsNullOrEmpty(auxNegocioUsuario.buscarUsuario(auxUsuario.Rut).Rut))
                    {

                        if (string.IsNullOrEmpty(this.txtRut.Text) 
                            || string.IsNullOrEmpty(this.txtNombre.Text) 
                            || string.IsNullOrEmpty(this.txtClave.Text) 
                            || string.IsNullOrEmpty(this.comboBoxCargo.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            auxNegocioUsuario.insertarUsuario(auxUsuario);
                            this.comboBoxCargo.DropDownStyle = ComboBoxStyle.Simple;
                            this.limpiar();
                            MessageBox.Show("datos guardados correctamente", "sistema");
                            this.btnAgregar.Text = "guardar";
                            this.btnEliminar.Text = "eliminar";
                            this.desHabilitar();
                            this.btnSiguiente.Visible = true;
                            this.btnAnterior.Visible = true;
                            this.btnModificar.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Marca ya existe", "sistema");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al guardar" + ex.Message, "sistema");
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void PantallaMantenedorUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.controlExistenciasDataSet.usuario);
            this.desHabilitar();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario auxUsuario = new Usuario();
            auxUsuario.Rut = this.txtRut.Text;
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();        

            if (this.btnEliminar.Text == "eliminar")
            {
                if (this.txtRut.Text == "" )
                {
                    MessageBox.Show(" ingrese un rut para eliminar ", "sistema");
                }
                else
                {
                    if (String.IsNullOrEmpty(auxNegocioUsuario.buscarUsuario(auxUsuario.Rut).Rut) )
                    {
                        MessageBox.Show("ingrese un rut ", " sistema");
                    }
                    else
                    {
                        auxNegocioUsuario.eliminarUsuario(auxUsuario.Rut);
                        MessageBox.Show(" usuario eliminado ", "sistema");
                        this.limpiar();                        
                    }
                }
            }
            if (this.btnEliminar.Text == "cancelar")
            {
                this.desHabilitar();
                this.btnEliminar.Text = "eliminar";
                this.btnAgregar.Text = "guardar";
                this.btnModificar.Text = "modificar";
                this.btnModificar.Visible = true;
                this.btnAgregar.Visible = true;
                this.btnSiguiente.Visible = true;
                this.btnAnterior.Visible = true;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtRut.Text == "")
            {
                MessageBox.Show("ingrese id marca", "sistema");
            }
            else
            {
                if (this.btnModificar.Text.Equals("modificar"))
                {
                    this.txtRut.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtClave.Enabled = true;
                    this.comboBoxCargo.Enabled = true;
                    this.btnAgregar.Visible = false;
                    this.btnModificar.Text = "confirmar";
                    this.btnEliminar.Text = "cancelar";
                    this.btnAnterior.Visible = false;
                    this.btnSiguiente.Visible = false;
                    this.comboBoxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
                    Usuario auxUsuario = new Usuario();
                    auxUsuario.Rut = this.txtRut.Text;
                    auxUsuario.Nombre = this.txtNombre.Text;
                    auxUsuario.Clave = this.txtClave.Text;
                    auxUsuario.Cargo = this.comboBoxCargo.Text;
                    auxNegocioUsuario.actualizarUsuario(auxUsuario);
                    this.btnModificar.Text = "modificar";
                    this.desHabilitar();
                    this.btnAgregar.Visible = true;
                    this.btnAnterior.Visible = true;
                    this.btnSiguiente.Visible = true;
                    this.btnEliminar.Text = "eliminar";
                    MessageBox.Show("producto actualizado", "sistema");
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion - 1;
            this.mostrarUsuario();
            this.comboBoxCargo.DropDownStyle = ComboBoxStyle.Simple;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion + 1;
            this.mostrarUsuario();
            this.comboBoxCargo.DropDownStyle = ComboBoxStyle.Simple;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            this.dataGridViewListadoUsuario.DataSource = auxNegocioUsuario.buscarRutUsuario(this.txtBuscarRut.Text);
            this.dataGridViewListadoUsuario.DataMember = "usuario";
        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            this.dataGridViewListadoUsuario.DataSource = auxNegocioUsuario.retornarUsuario();
            this.dataGridViewListadoUsuario.DataMember = "usuario";
        }
    }
}
