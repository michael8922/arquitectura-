using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDTO;
using CapaNegocio;

namespace CapaGUI
{
    public partial class PantallaMantenedorProducto : Form
    {
        public PantallaMantenedorProducto()
        {
            InitializeComponent();

        }

        private int posicion;
        private int ultimo;



        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }


        private int posicion2;
        private int ultimo2;


        public int Posicion2 { get => posicion2; set => posicion2 = value; }
        public int Ultimo2 { get => ultimo2; set => ultimo2 = value; }


    ///------------------------------------------------------------------------------------------------------------------------------------------------
   
           

        public void mostrarMarca()
        {
            
            NegocioMarca auxNegocioMarca = new NegocioMarca();
            Marca auxMarca = new Marca();
            this.ultimo2 = auxNegocioMarca.retornarMarca().Tables["marca"].Rows.Count - 1;
            if (this.posicion2 <= 0)
                this.posicion2 = 0;
            if (this.posicion2 >= ultimo2)
                this.posicion2 = ultimo2;

            auxMarca = auxNegocioMarca.retornaPosicionMarca(this.posicion2);
            this.txtIdMarca.Text = auxMarca.Id_marca;
            this.txtNombreMarca.Text = auxMarca.Nombre;
        }

        //------------------------------------------------------------------------------------------------------------------------------------

        public void mostrarProducto()
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            Producto auxProducto = new Producto();
            this.ultimo = auxNegocioProducto.retornarProducto(this.txtIdMarca.Text).Tables["producto"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= ultimo)
                this.posicion = ultimo;

            auxProducto = auxNegocioProducto.retornaPosicionProducto(this.posicion,this.txtIdMarca.Text);
            this.txtCodigo.Text = auxProducto.Codigo;
            this.txtDescripcion.Text = auxProducto.Descripcion;
            this.txtCantidadTotal.Text = Convert.ToString(auxProducto.Cantidad_total);
            this.txtPrecio.Text = Convert.ToString(auxProducto.Precio_unitario);
            
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------

        public void limpiarProducto()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtCantidadTotal.Text = "";
            this.txtPrecio.Text = "";
        }

        public void limpiarMarca()
        {
            this.txtIdMarca.Text = "";
            this.txtNombreMarca.Text = "";
        }

        public void deshabilitarProducto()
        {
            this.txtCodigo.Enabled = false;
            this.txtDescripcion.Enabled = false;
            this.txtCantidadTotal.Enabled = false;
            this.txtPrecio.Enabled = false;
        }

        public void habilitarProducto()
        {
            this.txtCodigo.Enabled = true;
            this.txtDescripcion.Enabled = true;
            this.txtCantidadTotal.Enabled = true;
            this.txtPrecio.Enabled = true;
        }

        public void habilitarMarca()
        {
            this.txtIdMarca.Enabled = true;
            this.txtNombreMarca.Enabled = true;
        }

        public void desHabilitarMarca()
        {
            this.txtIdMarca.Enabled = false;
            this.txtNombreMarca.Enabled = false;
        }    
        
        public void desHabilitarBotonMarca()
        {
            this.btnAgregarMarca.Visible = false;
            this.btnModificarMarca.Visible = false;
            this.btnEliminarMarca.Visible = false;
            this.btnSiguiente.Visible = false;
            this.btnAnterior.Visible = false;
        }

        public void habilitarBotonMarca()
        {
            this.btnAgregarMarca.Visible = true;
            this.btnModificarMarca.Visible = true;
            this.btnEliminarMarca.Visible = true;
            this.btnSiguiente.Visible = true;
            this.btnAnterior.Visible = true;
        }

        public void desHabilitarBotonProducto()
        {
            this.btnGuardarProducto.Visible = false;
            this.btnModificarProducto.Visible = false;
            this.btnEliminarProducto.Visible = false;
            this.btnAnteriorProducto.Visible = false;
            this.btnSiguienteProducto.Visible = false;
        }

        public void habilitarBotonProducto()
        {
            this.btnGuardarProducto.Visible = true;
            this.btnModificarProducto.Visible = true;
            this.btnEliminarProducto.Visible = true;
            this.btnAnteriorProducto.Visible = true;
            this.btnSiguienteProducto.Visible = true;
        }

        //---------------------------------------------------------------------------------------------------------------------------

        private void PantallaMantenedorProducto_Load(object sender, EventArgs e)
        {

            this.desHabilitarBotonProducto();
            this.btnVolver.Visible = false;
            this.mostrarMarca();
            this.limpiarProducto();
            this.deshabilitarProducto();
            this.desHabilitarMarca();
            this.btnGuardarProducto.Text = "nuevo";
            this.btnAgregarMarca.Text = "nuevo";
            this.btnModificarMarca.Text = "actualizar";
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.btnSalir.Text == "cancelar")
            {
                this.deshabilitarProducto();
                this.limpiarProducto();
                this.btnGuardarProducto.Text = "nuevo";
                this.btnSalir.Text = "salir";
                this.btnModificarProducto.Text = "modificar";
                this.btnModificarProducto.Visible = true;
                this.btnEliminarProducto.Visible = true;
                this.btnAnteriorProducto.Visible = true;
                this.btnSiguienteProducto.Visible = true;
                this.btnGuardarProducto.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
               

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (this.btnGuardarProducto.Text.Equals("nuevo"))
            {
                this.habilitarProducto();
                this.btnGuardarProducto.Text = "guardar";
                this.btnSalir.Text = "cancelar";
                this.limpiarProducto();
                this.btnModificarProducto.Visible = false;
                this.btnEliminarProducto.Visible = false;
                this.btnAnteriorProducto.Visible = false;
                this.btnSiguienteProducto.Visible = false;
                this.btnAgregarMarca.Visible = false;
                this.btnModificarMarca.Visible = false;
                this.btnEliminarMarca.Visible = false;
                this.txtIdMarca.Enabled = false;
                this.txtNombreMarca.Enabled = false;
            }
            else
            {
                try
                {
                    Producto auxProducto = new Producto();
                    auxProducto.Codigo = this.txtCodigo.Text;
                    auxProducto.Descripcion = this.txtDescripcion.Text;
                    auxProducto.Precio_unitario = int.Parse(this.txtPrecio.Text);
                    auxProducto.Cantidad_total = int.Parse(this.txtCantidadTotal.Text);
                    auxProducto.Marca_id_marca = this.txtIdMarca.Text;
                    NegocioProducto auxNegocioProducto = new NegocioProducto();

                    if (String.IsNullOrEmpty(auxNegocioProducto.buscarProducto(auxProducto.Codigo).Codigo))
                    {

                        if (string.IsNullOrEmpty(this.txtCodigo.Text) 
                            || string.IsNullOrEmpty(this.txtDescripcion.Text)
                            || string.IsNullOrEmpty(this.txtPrecio.Text)
                            || string.IsNullOrEmpty(this.txtCantidadTotal.Text)
                            || string.IsNullOrEmpty(this.txtIdMarca.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            auxNegocioProducto.insertarProducto(auxProducto);
                            this.limpiarProducto();
                            MessageBox.Show("datos guardados correctamente", "sistema");
                            this.btnGuardarProducto.Text = "nuevo";
                            this.deshabilitarProducto();
                            this.btnModificarProducto.Visible = true;
                            this.btnEliminarProducto.Visible = true;
                            this.btnAnteriorProducto.Visible = true;
                            this.btnSiguienteProducto.Visible = true;
                            this.btnSalir.Text = "salir";
                            this.btnEliminarMarca.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("transaccion ya existe", "sistema");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al guardar" + ex.Message, "sistema");
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            if (this.btnAgregarMarca.Text.Equals("nuevo"))
            {
                this.habilitarMarca();
                this.btnAgregarMarca.Text = "guardar";
                this.btnEliminarMarca.Text = "cancelar";
                this.limpiarMarca();
                this.deshabilitarProducto();              
                this.btnModificarMarca.Visible = false;
            }
            else
            {
                try
                {
                    Marca auxMarca = new Marca();
                    auxMarca.Id_marca = this.txtIdMarca.Text;
                    auxMarca.Nombre = this.txtNombreMarca.Text;
                    NegocioMarca auxNegocioMarca = new NegocioMarca();

                    if (String.IsNullOrEmpty(auxNegocioMarca.buscarMarca(auxMarca.Id_marca).Id_marca))
                    {
                        if (string.IsNullOrEmpty(this.txtIdMarca.Text) || string.IsNullOrEmpty(this.txtNombreMarca.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            auxNegocioMarca.insertarMarca(auxMarca);
                            this.limpiarProducto();
                            MessageBox.Show("datos guardados correctamente", "sistema");
                            this.btnAgregarMarca.Text = "nuevo";
                            this.btnEliminarMarca.Text = "eliminar";
                            this.desHabilitarMarca();                          
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

        //-------------------------------------------------------------------------------------------------------------------------------------------
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.posicion2 = this.posicion2 - 1;
            this.mostrarMarca();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.posicion2 = this.posicion2 + 1;
            this.mostrarMarca();
        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        private void btnAnteriorProducto_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion - 1;
            this.mostrarProducto();

            
        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        private void btnSiguienteProducto_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion + 1;
            this.mostrarProducto();            
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            if (this.txtIdMarca.Text == "" )
            {
                MessageBox.Show("ingrese id marca", "sistema");
            }
            else
            {
                if (this.btnModificarMarca.Text.Equals("actualizar"))
                {
                    this.txtIdMarca.Enabled = false;
                    this.txtNombreMarca.Enabled = true;
                    this.btnAgregarMarca.Visible = false;
                    this.btnModificarMarca.Text = "modificar";
                    this.btnEliminarMarca.Text = "cancelar";
                }
                else
                {
                    NegocioMarca auxNegocioMarca = new NegocioMarca();
                    Marca auxMarca = new Marca();
                    auxMarca.Id_marca = this.txtIdMarca.Text;
                    auxMarca.Nombre = this.txtNombreMarca.Text;
                    auxNegocioMarca.actualizarMarca(auxMarca);
                    this.btnModificarMarca.Text = "actualizar";
                    this.desHabilitarMarca();
                    this.btnEliminarProducto.Text = "eliminar";
                    MessageBox.Show("producto actualizado", "sistema");
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {

           if(this.txtCodigo.Text == "")
            {
                MessageBox.Show("elige un producto para modificar", "sistema");
            }
            else
            {
                if (this.btnModificarProducto.Text.Equals("modificar"))
                {
                    this.txtDescripcion.Enabled = true;
                    this.txtCantidadTotal.Enabled = true;
                    this.txtPrecio.Enabled = true;
                    this.btnModificarProducto.Text = "confirmar";
                    this.btnSalir.Text = "cancelar";
                    this.btnGuardarProducto.Visible = false;
                    this.btnEliminarProducto.Visible = false;
                    this.btnAgregarMarca.Visible = false;
                    this.btnModificarMarca.Visible = false;
                    this.btnEliminarMarca.Visible = false;
                }
                else
                {
                    NegocioProducto auxNegocioProducto = new NegocioProducto();
                    Producto auxProducto = new Producto();
                    auxProducto.Codigo = this.txtCodigo.Text;
                    auxProducto.Descripcion = this.txtDescripcion.Text;
                    auxProducto.Cantidad_total = int.Parse(this.txtCantidadTotal.Text);
                    auxProducto.Precio_unitario = int.Parse(this.txtPrecio.Text);
                    auxProducto.Marca_id_marca = this.txtIdMarca.Text;

                    if (this.txtCodigo.Text == "" 
                        || this.txtDescripcion.Text == "" 
                        || this.txtCantidadTotal.Text == ""
                        || this.txtPrecio.Text == "" 
                        || this.txtIdMarca.Text == "")
                    {
                        MessageBox.Show("complete todos los campos", "sistema");
                    }
                    else
                    {
                        auxNegocioProducto.actualizarProducto(auxProducto);
                        this.btnModificarProducto.Text = "modificar";
                        this.deshabilitarProducto();
                        this.habilitarBotonProducto();
                        this.limpiarProducto();
                        this.btnSalir.Text = "salir";
                        MessageBox.Show("producto actualizado", "sistema");
                    }
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------
        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            Marca auxMarca = new Marca();
            auxMarca.Id_marca = this.txtIdMarca.Text;
            NegocioMarca auxNegocioMarca = new NegocioMarca();
            Producto auxProducto = new Producto();
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            auxProducto.Marca_id_marca = this.txtIdMarca.Text;

            if (this.btnEliminarMarca.Text == "eliminar")
            {
                if (this.txtIdMarca.Text == "" && this.txtNombreMarca.Text == "")
                {
                    MessageBox.Show(" ingrese una marca para eliminar ", "sistema");
                }
                else
                {
                    if (String.IsNullOrEmpty(auxNegocioProducto.buscarIdMarcaProducto(auxProducto.Marca_id_marca).Marca_id_marca)
                        && auxNegocioMarca.buscarMarca(auxMarca.Id_marca).Id_marca == this.txtIdMarca.Text)
                    {
                        auxNegocioMarca.eliminarMarca(auxMarca.Id_marca);
                        MessageBox.Show(" marca eliminada ", "sistema");
                        this.limpiarMarca();
                    }
                    else
                    {
                        MessageBox.Show("no se puede eliminar marca  \n" +
                            "tiene productos asociados \n" +
                            "elimine todos los productos asociados antes de eliminar marca", "sistema");
                    }
                }              
            }
            if (this.btnEliminarMarca.Text == "cancelar")
            {
                this.txtIdMarca.Enabled = false;
                this.txtNombreMarca.Enabled = false;
                this.btnEliminarMarca.Text = "eliminar";
                this.btnAgregarMarca.Text = "nuevo";
                this.btnModificarMarca.Text = "actualizar";
                this.btnModificarMarca.Visible = true;
                this.btnAgregarMarca.Visible = true;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto auxProducto = new Producto();
            auxProducto.Codigo = this.txtCodigo.Text;
            NegocioProducto auxNegocioProducto = new NegocioProducto();

            if (this.txtCodigo.Text == "")
            {
                MessageBox.Show("ingrese un producto para eliminar", "sistema");
            }
            else
            {
                auxNegocioProducto.eliminarProducto(this.txtCodigo.Text);
                this.limpiarProducto();
                MessageBox.Show("producto eliminado", "sistema");
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (this.txtIdMarca.Text != "" && this.txtNombreMarca.Text != "" )
            {
                this.desHabilitarMarca();
                this.desHabilitarBotonMarca();
                this.habilitarBotonProducto();
                this.btnVolver.Visible = true;
                this.btnContinuar.Visible = false;
            }
            else
            {
                MessageBox.Show(" complete el formulario de ingreso para continuar ", "sistema");
            }

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.desHabilitarBotonProducto();
            this.limpiarProducto();
            this.habilitarBotonMarca();
            this.btnVolver.Visible = false;
            this.btnContinuar.Visible = true;
            this.deshabilitarProducto();
            
        }
    }
}
