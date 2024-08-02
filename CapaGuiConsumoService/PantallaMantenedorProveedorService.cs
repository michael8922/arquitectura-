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
    public partial class PantallaMantenedorProveedorService : Form
    {
        public PantallaMantenedorProveedorService()
        {
            InitializeComponent();
        }

        private void PantallaMantenedorProveedorService_Load(object sender, EventArgs e)
        {
            this.desHabilitar();
        }

        private int posicion;
        private int ultimo;



        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public void mostrarProveedor()
        {
            ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient auxNegocioProveedor = new ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient();
            ServiceMantenedorProveedor.Proveedor auxProveedor = new ServiceMantenedorProveedor.Proveedor();
            
            this.ultimo = auxNegocioProveedor.retornarProveedorService().Tables["proveedor"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= ultimo)
                this.posicion = ultimo;

            auxProveedor = auxNegocioProveedor.retornaPosicionProveedorService(this.posicion);
            this.txtRol.Text = auxProveedor.Rol;
            this.txtNombre.Text = auxProveedor.Nombre_proveedor;
            this.txtDireccion.Text = auxProveedor.Direccion;
            this.txtTelefono.Text = Convert.ToString(auxProveedor.Telefono);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        public void habilitar()
        {
            this.txtRol.Enabled = true;
            this.txtNombre.Enabled = true;
            this.txtDireccion.Enabled = true;
            this.txtTelefono.Enabled = true;
        }


        public void desHabilitar()
        {
            this.txtRol.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtTelefono.Enabled = false;
        }

        public void limpiar()
        {
            this.txtRol.Text = "";
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
        }

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
                    ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient auxNegocioProveedor = new ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient();
                    ServiceMantenedorProveedor.Proveedor auxProveedor = new ServiceMantenedorProveedor.Proveedor();
                    
                    auxProveedor.Rol = this.txtRol.Text;
                    auxProveedor.Nombre_proveedor = this.txtNombre.Text;
                    auxProveedor.Direccion = this.txtDireccion.Text;
                    auxProveedor.Telefono = int.Parse(this.txtTelefono.Text);
                    

                    if (String.IsNullOrEmpty(auxNegocioProveedor.buscarProveedorService(auxProveedor.Rol).Rol))
                    {
                        if (string.IsNullOrEmpty(this.txtRol.Text)
                            || string.IsNullOrEmpty(this.txtNombre.Text)
                            || string.IsNullOrEmpty(this.txtDireccion.Text)
                            || string.IsNullOrEmpty(this.txtTelefono.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            auxNegocioProveedor.insertarProveedorService(auxProveedor);
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
                        MessageBox.Show("Proveedor ya existe", "sistema");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al guardar" + ex.Message, "sistema");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtRol.Text == "")
            {
                MessageBox.Show("ingrese Rol Proveedor", "sistema");
            }
            else
            {
                if (this.btnModificar.Text.Equals("modificar"))
                {
                    this.txtRol.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtDireccion.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.btnAgregar.Visible = false;
                    this.btnModificar.Text = "confirmar";
                    this.btnEliminar.Text = "cancelar";
                    this.btnAnterior.Visible = false;
                    this.btnSiguiente.Visible = false;
                }
                else
                {
                    ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient auxNegocioProveedor = new ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient();
                    ServiceMantenedorProveedor.Proveedor auxProveedor = new ServiceMantenedorProveedor.Proveedor();
                    
                    auxProveedor.Rol = this.txtRol.Text;
                    auxProveedor.Nombre_proveedor = this.txtNombre.Text;
                    auxProveedor.Direccion = this.txtDireccion.Text;
                    auxProveedor.Telefono = int.Parse(this.txtTelefono.Text);
                    auxNegocioProveedor.actualizarProveedorService(auxProveedor);
                    this.btnModificar.Text = "modificar";
                    this.desHabilitar();
                    this.btnAgregar.Visible = true;
                    this.btnAnterior.Visible = true;
                    this.btnSiguiente.Visible = true;
                    this.btnEliminar.Text = "eliminar";
                    MessageBox.Show("Proveedor actualizado", "sistema");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient auxNegocioProveedor = new ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient();
            ServiceMantenedorProveedor.Proveedor auxProveedor = new ServiceMantenedorProveedor.Proveedor();
            
            auxProveedor.Rol = this.txtRol.Text;
            

            if (this.btnEliminar.Text == "eliminar")
            {
                if (this.txtRol.Text == "")
                {
                    MessageBox.Show(" ingrese Rol de proveedor para eliminar ", "sistema");
                }
                else
                {
                    if (String.IsNullOrEmpty(auxNegocioProveedor.buscarProveedorService(auxProveedor.Rol).Rol))
                    {
                        MessageBox.Show("ingrese un rut ", " sistema");
                    }
                    else
                    {
                        auxNegocioProveedor.eliminarProveedorService(auxProveedor.Rol);
                        MessageBox.Show(" Proveedor eliminado ", "sistema");
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

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion - 1;
            this.mostrarProveedor();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion + 1;
            this.mostrarProveedor();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient auxNegocioProveedor = new ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient();
            
            this.dataGridViewListadoProveedor.DataSource = auxNegocioProveedor.buscarRolProveedorService(this.txtBuscarProveedor.Text);
            this.dataGridViewListadoProveedor.DataMember = "proveedor";
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient auxNegocioProveedor = new ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient();
            
            this.dataGridViewListadoProveedor.DataSource = auxNegocioProveedor.retornarProveedorService();
            this.dataGridViewListadoProveedor.DataMember = "proveedor";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
