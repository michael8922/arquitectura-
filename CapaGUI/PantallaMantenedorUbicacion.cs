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
    public partial class PantallaMantenedorUbicacion : Form
    {
        public PantallaMantenedorUbicacion()
        {
            InitializeComponent();
        }


        private int posicion;
        private int ultimo;



        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void habilitar()
        {
            this.txtIdUbicacion.Enabled = true;
            this.dateTimePickerFecha.Enabled = true;
            this.comboBoxCodigoProducto.Enabled = true;
            this.txtNombreUbicacion.Enabled = true;
            this.txtCantidad.Enabled = true;


        }

        public void desHabilitar()
        {
            this.txtIdUbicacion.Enabled = false;
            this.dateTimePickerFecha.Enabled = false;
            this.comboBoxCodigoProducto.Enabled = false;
            this.txtNombreUbicacion.Enabled = false;
            this.txtCantidad.Enabled = false;
        }

        public void limpiar()
        {
            this.txtIdUbicacion.Text = "";
            this.dateTimePickerFecha.Text = "";
            this.comboBoxCodigoProducto.Text = "";
            this.txtNombreUbicacion.Text = "";
            this.txtCantidad.Text = "";

        }

        public void desHabilitarBoton()
        {
            this.btnAgregar.Visible = false;
            this.btnEliminar.Visible = false;
            this.btnModificar.Visible = false;
            this.btnAnterior.Visible = false;
            this.btnSiguiente.Visible = false;
            
        }

        public void habilitarBotonIngreso()
        {
            this.btnAgregar.Visible = true;
            this.btnEliminar.Visible = true;
            this.btnModificar.Visible = true;
            this.btnAnterior.Visible = true;
            this.btnSiguiente.Visible = true;
            
        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        public void mostrarUbicacion()
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            Ubicacion auxUbicacion = new Ubicacion();


            this.ultimo = auxNegocioUbicacion.retornarUbicacion().Tables["ubicacion"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= ultimo)
                this.posicion = ultimo;

            auxUbicacion = auxNegocioUbicacion.retornaPosicionUbicacion(this.posicion);
            this.txtIdUbicacion.Text = auxUbicacion.Id_ubicacion;
            this.dateTimePickerFecha.Text = Convert.ToString(auxUbicacion.Fecha_ingreso_ubicacion);
            this.txtNombreUbicacion.Text = auxUbicacion.Nombre_ubicacion;
            this.comboBoxCodigoProducto.Text = auxUbicacion.Producto_codigo;
            this.txtCantidad.Text = Convert.ToString(auxUbicacion.Cantidad);

        }

        ///-----------------------------------------------------------------------------------------------------------------------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.btnAgregar.Text.Equals("guardar"))
            {
                this.habilitar();
                this.btnAgregar.Text = "confirmar";
                this.btnEliminar.Text = "cancelar";
                this.limpiar();
                this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
                this.btnSiguiente.Visible = false;
                this.btnAnterior.Visible = false;              
                this.btnModificar.Visible = false;
            }
            else
            {
                try
                {
                    Ubicacion auxUbicacion = new Ubicacion();
                    auxUbicacion.Id_ubicacion = this.txtIdUbicacion.Text;
                    auxUbicacion.Fecha_ingreso_ubicacion = DateTime.Parse(this.dateTimePickerFecha.Text);
                    auxUbicacion.Producto_codigo = this.comboBoxCodigoProducto.SelectedValue.ToString();
                    auxUbicacion.Nombre_ubicacion = this.txtNombreUbicacion.Text;
                    auxUbicacion.Cantidad = int.Parse(this.txtCantidad.Text);
                    NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();

                    if (String.IsNullOrEmpty(auxNegocioUbicacion.buscarUbicacion(auxUbicacion.Id_ubicacion).Id_ubicacion))
                    {

                        if (string.IsNullOrEmpty(this.txtIdUbicacion.Text) 
                            || string.IsNullOrEmpty(this.dateTimePickerFecha.Text) 
                            || string.IsNullOrEmpty(this.comboBoxCodigoProducto.Text) 
                            || string.IsNullOrEmpty(this.txtNombreUbicacion.Text) 
                            || string.IsNullOrEmpty(this.txtCantidad.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            auxNegocioUbicacion.insertarUbicacion(auxUbicacion);
                            this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.Simple;
                            this.limpiar();
                            MessageBox.Show("datos guardados correctamente", "sistema");
                            this.btnAgregar.Text = "guardar";
                            this.btnEliminar.Text = "eliminar";
                            this.desHabilitar();
                            this.btnModificar.Visible = true;
                            this.btnSiguiente.Visible = true;
                            this.btnAnterior.Visible = true;                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ubicacion ya existe", "sistema");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al guardar" + ex.Message, "sistema");
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtIdUbicacion.Text == "")
            {
                MessageBox.Show("campo ID Ubicacion vacio", "sistema");
            }
            else
            {
                if (this.btnModificar.Text.Equals("modificar"))
                {
                    this.habilitar();
                    this.txtIdUbicacion.Enabled = false;
                    this.btnAgregar.Visible = false;
                    this.btnModificar.Text = "confirmar";
                    this.btnEliminar.Text = "cancelar";
                    this.btnAnterior.Visible = false;
                    this.btnSiguiente.Visible = false;
                    this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.DropDownList;                  
                }
                else
                {
                    NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
                    Ubicacion auxUbicacion = new Ubicacion();
                    auxUbicacion.Id_ubicacion = this.txtIdUbicacion.Text;
                    auxUbicacion.Fecha_ingreso_ubicacion = DateTime.Parse(this.dateTimePickerFecha.Text);
                    auxUbicacion.Producto_codigo = this.comboBoxCodigoProducto.SelectedValue.ToString();
                    auxUbicacion.Nombre_ubicacion = this.txtNombreUbicacion.Text;
                    auxUbicacion.Cantidad = int.Parse(this.txtCantidad.Text);
                    auxNegocioUbicacion.actualizarUbicacion(auxUbicacion);
                    this.btnModificar.Text = "modificar";
                    this.desHabilitar();
                    this.btnAgregar.Visible = true;
                    this.btnAnterior.Visible = true;
                    this.btnSiguiente.Visible = true;
                    this.btnEliminar.Text = "eliminar";
                    MessageBox.Show("Ingreso actualizado", "sistema");
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Ubicacion auxUbicacion = new Ubicacion();
            auxUbicacion.Id_ubicacion = this.txtIdUbicacion.Text;
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();

            if (this.btnEliminar.Text == "eliminar")
            {
                if (this.txtIdUbicacion.Text == "")
                {
                    MessageBox.Show(" ingrese un Id ubicacion para eliminar ", "sistema");
                }
                else
                {
                    if (String.IsNullOrEmpty(auxNegocioUbicacion.buscarUbicacion(auxUbicacion.Id_ubicacion).Id_ubicacion))
                    {
                        MessageBox.Show("ingrese un id Ubicacion ", " sistema");
                    }
                    else
                    {
                        auxNegocioUbicacion.eliminarUbicacion(auxUbicacion.Id_ubicacion);
                        MessageBox.Show(" Ubicacion eliminada ", "sistema");
                        this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.Simple;
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

        //-------------------------------------------------------------------------------------------------------------------------------------------

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            this.dataGridViewListadoUbicacion.DataSource = auxNegocioUbicacion.buscarUbicacionCodigoProducto(this.txtBuscarCodigo.Text);
            this.dataGridViewListadoUbicacion.DataMember = "ubicacion";
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            this.dataGridViewListadoUbicacion.DataSource = auxNegocioUbicacion.retornarUbicacion();
            this.dataGridViewListadoUbicacion.DataMember = "ubicacion";
        }

        //----------------------------------------------------------------------------------------------------------------------------------------
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion - 1;
            this.mostrarUbicacion();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion + 1;
            this.mostrarUbicacion();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
        
        //---------------------------------------------------------------------------------------------------------------------------------------------

        private void PantallaMantenedorUbicacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet16.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.controlExistenciasDataSet16.producto);
            this.desHabilitar();
            this.limpiar();
        }
    }
}
