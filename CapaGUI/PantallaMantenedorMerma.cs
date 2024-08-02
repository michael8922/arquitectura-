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
    public partial class PantallaMantenedorMerma : Form
    {
        public PantallaMantenedorMerma()
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void habilitarMerma()
        {
            this.txtIdMerma.Enabled = true;
            this.txtTipoSolicitud.Enabled = true;
            this.txtMotivo.Enabled = true;
            this.comboBoxRutUsuario.Enabled = true;
            this.dateTimePickerFecha.Enabled = true;     
        }

        public void habilitarDetalle()
        {
            this.txtIdDetalle.Enabled = true;
            this.txtCantidad.Enabled = true;
            this.comboBoxCodigoProducto.Enabled = true;
        }

        public void desHabilitarMerma()
        {
            this.txtIdMerma.Enabled = false;
            this.txtTipoSolicitud.Enabled = false;
            this.txtMotivo.Enabled = false;
            this.comboBoxRutUsuario.Enabled = false;
            this.dateTimePickerFecha.Enabled = false;       
        }

        public void desHabilitarDetalle()
        {
            this.txtIdDetalle.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.comboBoxCodigoProducto.Enabled = false;

        }

        public void limpiarMerma()
        {
            this.txtIdMerma.Text = "";
            this.txtTipoSolicitud.Text = "";
            this.txtMotivo.Text = "";
            this.comboBoxRutUsuario.Text = "";
            this.dateTimePickerFecha.Text = "";
        }

        public void limpiarDetalle()
        {
            this.txtIdDetalle.Text = "";
            this.txtCantidad.Text = "";
            this.comboBoxCodigoProducto.Text = "";
            this.txtValorTotal.Text = "";
        }

        public void desHabilidarBotonDetalle()
        {
            this.btnAnteriorDetalle.Visible = false;
            this.btnSiguienteDetalle.Visible = false;
            this.btnCalcular.Visible = false;
            this.btnVolver.Visible = false;
            this.btnAgregarDetalle.Visible = false;
            this.btnEliminarDetalle.Visible = false;
        }

        public void habilidarBotonDetalle()
        {
            this.btnAnteriorDetalle.Visible = true;
            this.btnSiguienteDetalle.Visible = true;
            this.btnCalcular.Visible = true;
            this.btnVolver.Visible = true;
            this.btnAgregarDetalle.Visible = true;
            this.btnEliminarDetalle.Visible = true;
        }

        public void desHabilitarBotonMerma()
        {
            this.btnAgregarMerma.Visible = false;
            this.btnEliminarMerma.Visible = false;
            this.btnModificarMerma.Visible = false;
            this.btnAnteriorMerma.Visible = false;
            this.btnSiguienteMerma.Visible = false;
            this.btnContinuar.Visible = false;
        }

        public void habilitarBotonMerma()
        {
            this.btnAgregarMerma.Visible = true;
            this.btnEliminarMerma.Visible = true;
            this.btnModificarMerma.Visible = true;
            this.btnAnteriorMerma.Visible = true;
            this.btnSiguienteMerma.Visible = true;
            this.btnContinuar.Visible = true;
        }

        //--------------------------------------------------------------------------------------------------------------
       
        public void mostrarMerma()
        {
            NegocioMerma auxNegocioMerma = new NegocioMerma();
            Merma auxMerma = new Merma();


            this.ultimo = auxNegocioMerma.retornarMerma().Tables["merma"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= ultimo)
                this.posicion = ultimo;

            auxMerma = auxNegocioMerma.retornaPosicionMerma(this.posicion);
            this.txtIdMerma.Text = auxMerma.Id_merma;
            this.dateTimePickerFecha.Text = Convert.ToString(auxMerma.Fecha);
            this.txtTipoSolicitud.Text = auxMerma.Tipo_solicitud;
            this.txtMotivo.Text = auxMerma.Motivo;
            this.comboBoxRutUsuario.Text = auxMerma.Usuario_rut;          
        }

        //-------------------------------------------------------------------------------------------------------------------------------------

        public void mostrarDetalle()
        {
            Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
            Det_Merma auxDetalle = new Det_Merma();


            this.Ultimo2 = auxNegocioDetalle.retornarDetalleMerma(this.txtIdMerma.Text).Tables["det_merma"].Rows.Count - 1;
            if (this.Posicion2 <= 0)
                this.Posicion2 = 0;
            if (this.Posicion2 >= Ultimo2)
                this.Posicion2 = Ultimo2;

            auxDetalle = auxNegocioDetalle.retornaPosicionDetalleMerma(this.Posicion2, this.txtIdMerma.Text);
            this.txtIdDetalle.Text = auxDetalle.Id_det_merma;
            this.txtCantidad.Text = Convert.ToString(auxDetalle.Cantidad);
            this.comboBoxCodigoProducto.Text = auxDetalle.Producto_codigo;
            this.txtValorTotal.Text = Convert.ToString(auxDetalle.Valor_total);



        }


        ///-----------------------------------------------------------------------------------------------------------------------------------

        private void btnAgregarMerma_Click(object sender, EventArgs e)
        {
            if (this.btnAgregarMerma.Text.Equals("guardar"))
            {
                this.habilitarMerma();
                this.btnAgregarMerma.Text = "confirmar";
                this.btnEliminarMerma.Text = "cancelar";
                this.limpiarMerma();
                this.comboBoxRutUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
                
                this.btnSiguienteMerma.Visible = false;
                this.btnAnteriorMerma.Visible = false;
                this.btnContinuar.Visible = false;
                this.btnModificarMerma.Visible = false;
            }
            else
            {
                try
                {
                    Merma auxMerma = new Merma();
                    auxMerma.Id_merma = this.txtIdMerma.Text;
                    auxMerma.Fecha = DateTime.Parse(this.dateTimePickerFecha.Text);
                    auxMerma.Tipo_solicitud = this.txtTipoSolicitud.Text;
                    auxMerma.Motivo = this.txtMotivo.Text;
                    auxMerma.Usuario_rut = this.comboBoxRutUsuario.SelectedValue.ToString();
                    NegocioMerma auxNegocioMerma = new NegocioMerma();

                    if (String.IsNullOrEmpty(auxNegocioMerma.buscarMerma(auxMerma.Id_merma).Id_merma))
                    {

                        if (string.IsNullOrEmpty(this.txtIdMerma.Text) 
                            || string.IsNullOrEmpty(this.txtTipoSolicitud.Text) 
                            || string.IsNullOrEmpty(this.txtMotivo.Text) 
                            || string.IsNullOrEmpty(this.comboBoxRutUsuario.Text)
                            || string.IsNullOrEmpty(this.dateTimePickerFecha.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            auxNegocioMerma.insertarMerma(auxMerma);                            ;
                            this.comboBoxRutUsuario.DropDownStyle = ComboBoxStyle.Simple;                            
                            this.limpiarMerma();

                            MessageBox.Show("datos guardados correctamente", "sistema");
                            this.btnAgregarMerma.Text = "guardar";
                            this.btnEliminarMerma.Text = "eliminar";
                            this.desHabilitarMerma();

                            this.btnModificarMerma.Visible = true;
                            this.btnSiguienteMerma.Visible = true;
                            this.btnAnteriorMerma.Visible = true;
                            this.btnContinuar.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Merma ya existe", "sistema");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al guardar" + ex.Message, "sistema");
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------

        private void btnModificarMerma_Click(object sender, EventArgs e)
        {
            if (this.txtIdMerma.Text == "")
            {
                MessageBox.Show("campo ID Merma vacio", "sistema");
            }
            else
            {
                if (this.btnModificarMerma.Text.Equals("modificar"))
                {
                    this.habilitarMerma();
                    this.txtIdMerma.Enabled = false;                                       
                    this.btnAgregarMerma.Visible = false;
                    this.btnModificarMerma.Text = "confirmar";
                    this.btnEliminarMerma.Text = "cancelar";
                    this.btnAnteriorMerma.Visible = false;
                    this.btnSiguienteMerma.Visible = false;
                    this.btnContinuar.Visible = false;
                    this.comboBoxRutUsuario.DropDownStyle = ComboBoxStyle.DropDownList;                  
                }
                else
                {
                    NegocioMerma auxNegocioMerma = new NegocioMerma();
                    Merma auxMerma = new Merma();
                    auxMerma.Id_merma = this.txtIdMerma.Text;
                    auxMerma.Fecha = DateTime.Parse(this.dateTimePickerFecha.Text);
                    auxMerma.Tipo_solicitud = this.txtTipoSolicitud.Text;
                    auxMerma.Motivo = this.txtMotivo.Text;
                    auxMerma.Usuario_rut = this.comboBoxRutUsuario.SelectedValue.ToString();                 
                    auxNegocioMerma.actualizarMerma(auxMerma);
                    this.btnModificarMerma.Text = "modificar";
                    this.desHabilitarMerma();
                    this.btnAgregarMerma.Visible = true;
                    this.btnAnteriorMerma.Visible = true;
                    this.btnSiguienteMerma.Visible = true;
                    this.btnEliminarMerma.Text = "eliminar";
                    MessageBox.Show("Merma actualizada", "sistema");
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------

        private void btnEliminarMerma_Click(object sender, EventArgs e)
        {
            try
            {
                Merma auxMerma = new Merma();
                auxMerma.Id_merma = this.txtIdMerma.Text;
                NegocioMerma auxNegocioMerma = new NegocioMerma();
                Det_Merma auxDetalle = new Det_Merma();
                Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
                auxDetalle.Merma_id_merma = this.txtIdMerma.Text;


                if (this.btnEliminarMerma.Text == "eliminar")
                {
                    if (this.txtIdMerma.Text == "")
                    {
                        MessageBox.Show(" ingrese un Id Merma para eliminar ", "sistema");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(auxNegocioDetalle.buscarDetallePorIdMerma(auxDetalle.Merma_id_merma).Merma_id_merma) 
                            && auxNegocioMerma.buscarMerma(auxMerma.Id_merma).Id_merma == this.txtIdMerma.Text)
                        {
                            auxNegocioMerma.eliminarMerma(auxMerma.Id_merma);
                            MessageBox.Show(" ingreso eliminado ", "sistema");
                            this.comboBoxRutUsuario.DropDownStyle = ComboBoxStyle.Simple;
                            this.limpiarMerma();
                        }
                        else
                        {
                            MessageBox.Show("elimine todos los detalles asociados antes de eliminar Merma", " sistema");
                        }
                    }
                }
                if (this.btnEliminarMerma.Text == "cancelar")
                {
                    this.comboBoxRutUsuario.DropDownStyle = ComboBoxStyle.Simple;                    
                    this.limpiarMerma();
                    this.desHabilitarMerma();
                    this.btnEliminarMerma.Text = "eliminar";
                    this.btnAgregarMerma.Text = "guardar";
                    this.btnModificarMerma.Text = "modificar";
                    this.btnModificarMerma.Visible = true;
                    this.btnAgregarMerma.Visible = true;
                    this.btnSiguienteMerma.Visible = true;
                    this.btnAnteriorMerma.Visible = true;
                    this.btnContinuar.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show(" error de sistema ", "sistema");
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (this.txtIdMerma.Text != "" 
                && this.txtTipoSolicitud.Text != "" 
                && this.txtMotivo.Text != "" 
                && this.comboBoxRutUsuario.Text != "" 
                && this.dateTimePickerFecha.Text != "")
            {
                this.desHabilitarMerma();
                this.desHabilitarBotonMerma();
                this.habilidarBotonDetalle();
            }
            else
            {
                MessageBox.Show(" complete el formulario de ingreso para continuar ", "sistema");
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------

        private void PantallaMantenedorMerma_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet15.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.controlExistenciasDataSet15.producto);
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet14.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.controlExistenciasDataSet14.usuario);
            this.desHabilitarMerma();
            this.desHabilitarDetalle();
            this.txtValorTotal.Enabled = false;
            this.limpiarMerma();
            this.limpiarDetalle();
            this.desHabilidarBotonDetalle();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnAnteriorMerma_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion - 1;
            this.mostrarMerma();
            
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSiguienteMerma_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion + 1;
            this.mostrarMerma();
            
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (this.btnAgregarDetalle.Text.Equals("guardar"))
            {

                this.btnAgregarDetalle.Text = "confirmar";
                this.btnEliminarDetalle.Text = "cancelar";
                this.limpiarDetalle();
                this.habilitarDetalle();
                this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
                this.btnSiguienteDetalle.Visible = false;
                this.btnAnteriorDetalle.Visible = false;
                this.btnVolver.Visible = false;
            }
            else
            {
                try
                {
                    int valor_unitario_producto;
                    int stock_producto;
                    NegocioProducto auxNegocioProducto = new NegocioProducto();
                    Producto auxProducto = auxNegocioProducto.buscarProducto(this.comboBoxCodigoProducto.Text);
                    valor_unitario_producto = auxProducto.Precio_unitario;
                    stock_producto = auxProducto.Cantidad_total;
                    Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
                    Det_Merma auxDetalle = new Det_Merma();
                    auxDetalle.Id_det_merma = this.txtIdDetalle.Text;
                    auxDetalle.Cantidad = int.Parse(this.txtCantidad.Text);
                    auxDetalle.Valor_total = auxDetalle.Cantidad * valor_unitario_producto;
                    auxDetalle.Merma_id_merma = this.txtIdMerma.Text;
                    auxDetalle.Producto_codigo = this.comboBoxCodigoProducto.SelectedValue.ToString();


                    if (String.IsNullOrEmpty(auxNegocioDetalle.buscarDetalleMerma(auxDetalle.Id_det_merma).Id_det_merma))
                    {

                        if (string.IsNullOrEmpty(this.txtIdDetalle.Text)
                            || string.IsNullOrEmpty(this.txtCantidad.Text)
                            || string.IsNullOrEmpty(this.comboBoxCodigoProducto.Text)
                            || string.IsNullOrEmpty(this.txtValorTotal.Text) 
                            || string.IsNullOrEmpty(this.txtIdMerma.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            if (auxDetalle.Cantidad > 0)
                            {
                                if (this.txtValorTotal.Text == Convert.ToString(auxDetalle.Valor_total))
                                {
                                    auxNegocioDetalle.insertarDetalleMerma(auxDetalle);
                                    auxProducto.Codigo = this.comboBoxCodigoProducto.Text;
                                    auxProducto.Cantidad_total = stock_producto - auxDetalle.Cantidad;
                                    auxNegocioProducto.actualizarProducto(auxProducto);
                                    this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.Simple;
                                    this.limpiarDetalle();
                                    MessageBox.Show("datos guardados correctamente", "sistema");
                                    this.btnAgregarDetalle.Text = "guardar";
                                    this.btnEliminarDetalle.Text = "eliminar";
                                    this.btnSiguienteDetalle.Visible = true;
                                    this.btnAnteriorDetalle.Visible = true;
                                    this.btnVolver.Visible = true;
                                    this.desHabilitarDetalle();
                                }
                                else
                                {
                                    MessageBox.Show("presione nuevamente el boton calcular", "sistema");
                                }
                            }
                            else
                            {
                                MessageBox.Show("ingrese una cantidad mayor a cero", "sistema");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("ingreso ya existe", "sistema");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al guardar" + ex.Message, "sistema");
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            Det_Merma auxDetalle = new Det_Merma();
            auxDetalle.Id_det_merma= this.txtIdDetalle.Text;
            Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();

            int stock_producto;
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            Producto auxProducto = auxNegocioProducto.buscarProducto(this.comboBoxCodigoProducto.Text);
            stock_producto = auxProducto.Cantidad_total;


            if (this.btnEliminarDetalle.Text == "eliminar")
            {
                if (this.txtIdDetalle.Text == "")
                {
                    MessageBox.Show(" ingrese un Id Detalle para eliminar ", "sistema");
                }
                else
                {
                    if (String.IsNullOrEmpty(auxNegocioDetalle.buscarDetalleMerma(auxDetalle.Id_det_merma).Id_det_merma))
                    {
                        MessageBox.Show("ingrese un ID Detalle  valido", " sistema");
                    }
                    else
                    {
                        auxProducto.Cantidad_total = stock_producto + int.Parse(this.txtCantidad.Text);
                        auxProducto.Codigo = this.comboBoxCodigoProducto.Text;
                        auxNegocioProducto.actualizarProducto(auxProducto);
                        auxNegocioDetalle.eliminarDetalleMerma(auxDetalle.Id_det_merma);
                        MessageBox.Show(" Detalle eliminado ", "sistema");
                        this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.Simple;
                        this.limpiarDetalle();
                    }
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtCantidad.Text != "" && this.comboBoxCodigoProducto.Text != "")
            {
                int valor;
                int cantidad;
                NegocioProducto auxNegocioProducto = new NegocioProducto();
                Producto auxProducto = auxNegocioProducto.buscarProducto(this.comboBoxCodigoProducto.Text);
                valor = auxProducto.Precio_unitario;
                cantidad = int.Parse(this.txtCantidad.Text);
                this.txtValorTotal.Text = Convert.ToString(valor * cantidad);
            }
            else
            {
                MessageBox.Show("complete los campos cantidad y codigo", "sistema");
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnAnteriorDetalle_Click(object sender, EventArgs e)
        {
            this.posicion2 = this.posicion2 - 1;
            this.mostrarDetalle();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnSiguienteDetalle_Click(object sender, EventArgs e)
        {
            this.posicion2 = this.posicion2 + 1;
            this.mostrarDetalle();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.habilitarBotonMerma();
            this.desHabilidarBotonDetalle();
            this.limpiarDetalle();
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
