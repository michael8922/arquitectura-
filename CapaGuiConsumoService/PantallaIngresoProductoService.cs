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
    public partial class PantallaIngresoProductoService : Form
    {
        public PantallaIngresoProductoService()
        {
            InitializeComponent();
        }

        private void PantallaIngresoProductoService_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet5.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.controlExistenciasDataSet5.producto);
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet4.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.controlExistenciasDataSet4.proveedor);
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet3.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.controlExistenciasDataSet3.usuario);
            this.desHabilitarIngreso();
            this.desHabilitarDetalle();
            this.txtValorTotal.Enabled = false;
            this.limpiarIngreso();
            this.limpiarDetalle();
            this.desHabilidarBotonDetalle();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------

        private int posicion;
        private int ultimo;



        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        private int posicion2;
        private int ultimo2;


        public int Posicion2 { get => posicion2; set => posicion2 = value; }
        public int Ultimo2 { get => ultimo2; set => ultimo2 = value; }







        public void habilitarIngreso()
        {
            this.txtIdIngreso.Enabled = true;
            this.dateTimePickerFecha.Enabled = true;
            this.comboBoxUsuario.Enabled = true;
            this.comboBoxProveedor.Enabled = true;



        }

        public void habilitarDetalle()
        {
            this.txtIdDetalleIngreso.Enabled = true;
            this.txtCantidad.Enabled = true;
            this.comboBoxCodigoProducto.Enabled = true;
        }

        public void desHabilitarIngreso()
        {
            this.txtIdIngreso.Enabled = false;
            this.dateTimePickerFecha.Enabled = false;
            this.comboBoxUsuario.Enabled = false;
            this.comboBoxProveedor.Enabled = false;



        }

        public void desHabilitarDetalle()
        {
            this.txtIdDetalleIngreso.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.comboBoxCodigoProducto.Enabled = false;

        }

        public void limpiarIngreso()
        {
            this.txtIdIngreso.Text = "";
            this.dateTimePickerFecha.Text = "";
            this.comboBoxUsuario.Text = "";
            this.comboBoxProveedor.Text = "";


        }

        public void limpiarDetalle()
        {
            this.txtIdDetalleIngreso.Text = "";
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
            this.btnGuardarDetalle.Visible = false;
            this.btnEliminarDetalle.Visible = false;
        }

        public void habilidarBotonDetalle()
        {
            this.btnAnteriorDetalle.Visible = true;
            this.btnSiguienteDetalle.Visible = true;
            this.btnCalcular.Visible = true;
            this.btnVolver.Visible = true;
            this.btnGuardarDetalle.Visible = true;
            this.btnEliminarDetalle.Visible = true;
        }

        public void desHabilitarBotonIngreso()
        {
            this.btnAgregar.Visible = false;
            this.btnEliminar.Visible = false;
            this.btnModificar.Visible = false;
            this.btnAnteriorIngreso.Visible = false;
            this.btnSiguienteIngreso.Visible = false;
            this.btnContinuar.Visible = false;
        }

        public void habilitarBotonIngreso()
        {
            this.btnAgregar.Visible = true;
            this.btnEliminar.Visible = true;
            this.btnModificar.Visible = true;
            this.btnAnteriorIngreso.Visible = true;
            this.btnSiguienteIngreso.Visible = true;
            this.btnContinuar.Visible = true;
        }


        //-----------------------------------------------------------------------------------------------------------------

        public void cargarComboBoxIngreso()
        {
            ServiceMantenedorUsuario.WebServiceMantenedorUsuarioSoapClient auxNegocioUsuario = new ServiceMantenedorUsuario.WebServiceMantenedorUsuarioSoapClient();
            ServiceMantenedorUsuario.Usuario auxUsuario = auxNegocioUsuario.buscarUsuarioService(this.labelIdUsuario.Text);
            ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient auxNegocioProveedor = new ServiceMantenedorProveedor.WebServiceMantenedorProveedorSoapClient();
            ServiceMantenedorProveedor.Proveedor auxProveedor = auxNegocioProveedor.buscarProveedorService(this.labelIdProveedor.Text);
            
            

            this.comboBoxUsuario.Text = auxUsuario.Nombre;
            this.comboBoxProveedor.Text = auxProveedor.Nombre_proveedor;

        }

        //-------------------------------------------------------------------------------------------------------------------


        public void mostrarIngreso()
        {
            ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient auxNegocioIngreso = new ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient();
            ServiceMantenedorIngresoProducto.Ingreso_P auxIngreso = new ServiceMantenedorIngresoProducto.Ingreso_P();
            


            this.ultimo = auxNegocioIngreso.listarIngresoProductoService().Tables["ingreso_p"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= ultimo)
                this.posicion = ultimo;

            auxIngreso = auxNegocioIngreso.retornaPosicionIngresoProductoService(this.posicion);
            this.txtIdIngreso.Text = auxIngreso.Id_ingreso;
            this.dateTimePickerFecha.Text = Convert.ToString(auxIngreso.Fecha);
            this.labelIdUsuario.Text = auxIngreso.Usuario_rut;
            this.labelIdProveedor.Text = auxIngreso.Proveedor_rol;


        }

        //----------------------------------------------------------------------------------------------------------------------------------------
        public void mostrarDetalle()
        {
            ServiceMantenedorDetalleIngreso.WebServiceMantenedorDetIngresoSoapClient auxNegocioDetalle = new ServiceMantenedorDetalleIngreso.WebServiceMantenedorDetIngresoSoapClient();
            ServiceMantenedorDetalleIngreso.Det_Ingreso auxDetalle = new ServiceMantenedorDetalleIngreso.Det_Ingreso();
            


            this.Ultimo2 = auxNegocioDetalle.retornarDetalleIngresoProductoService(this.txtIdIngreso.Text).Tables["det_ingreso"].Rows.Count - 1;
            if (this.Posicion2 <= 0)
                this.Posicion2 = 0;
            if (this.Posicion2 >= Ultimo2)
                this.Posicion2 = Ultimo2;

            auxDetalle = auxNegocioDetalle.retornaPosicionDetalleIngresoProductoService(this.Posicion2, this.txtIdIngreso.Text);
            this.txtIdDetalleIngreso.Text = auxDetalle.Id_detalle_ingreso;
            this.txtCantidad.Text = Convert.ToString(auxDetalle.Cantidad);
            this.comboBoxCodigoProducto.Text = auxDetalle.Producto_codigo;
            this.txtValorTotal.Text = Convert.ToString(auxDetalle.Valor_total);



        }

        //------------------------------------------------------------------------------------------------------------------------------------------


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.btnAgregar.Text.Equals("guardar"))
            {
                this.habilitarIngreso();
                this.btnAgregar.Text = "confirmar";
                this.btnEliminar.Text = "cancelar";
                this.limpiarIngreso();
                this.comboBoxUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
                this.comboBoxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;

                this.btnSiguienteIngreso.Visible = false;
                this.btnAnteriorIngreso.Visible = false;
                this.btnContinuar.Visible = false;

                this.btnModificar.Visible = false;
            }
            else
            {
                try
                {
                    ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient auxNegocioIngreso = new ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient();
                    ServiceMantenedorIngresoProducto.Ingreso_P auxIngresoProducto = new ServiceMantenedorIngresoProducto.Ingreso_P();
                    
                    auxIngresoProducto.Id_ingreso = this.txtIdIngreso.Text;
                    auxIngresoProducto.Fecha = DateTime.Parse(this.dateTimePickerFecha.Text);
                    auxIngresoProducto.Usuario_rut = this.comboBoxUsuario.SelectedValue.ToString();
                    auxIngresoProducto.Proveedor_rol = this.comboBoxProveedor.SelectedValue.ToString();
                    

                    if (String.IsNullOrEmpty(auxNegocioIngreso.buscarIngresoProductoService(auxIngresoProducto.Id_ingreso).Id_ingreso))
                    {

                        if (string.IsNullOrEmpty(this.txtIdIngreso.Text) ||
                            string.IsNullOrEmpty(this.dateTimePickerFecha.Text) ||
                            string.IsNullOrEmpty(this.comboBoxUsuario.Text) ||
                            string.IsNullOrEmpty(this.comboBoxProveedor.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            auxNegocioIngreso.insertarIngresoProductoService(auxIngresoProducto);
                            this.comboBoxUsuario.DropDownStyle = ComboBoxStyle.Simple;
                            this.comboBoxProveedor.DropDownStyle = ComboBoxStyle.Simple;
                            this.limpiarIngreso();

                            MessageBox.Show("datos guardados correctamente", "sistema");
                            this.btnAgregar.Text = "guardar";
                            this.btnEliminar.Text = "eliminar";
                            this.desHabilitarIngreso();

                            this.btnModificar.Visible = true;
                            this.btnSiguienteIngreso.Visible = true;
                            this.btnAnteriorIngreso.Visible = true;
                            this.btnContinuar.Visible = true;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtIdIngreso.Text == "")
            {
                MessageBox.Show("campo ID ingreso vacio", "sistema");
            }
            else
            {
                if (this.btnModificar.Text.Equals("modificar"))
                {
                    this.txtIdIngreso.Enabled = false;
                    this.dateTimePickerFecha.Enabled = true;
                    this.comboBoxUsuario.Enabled = true;
                    this.comboBoxProveedor.Enabled = true;

                    this.btnAgregar.Visible = false;
                    this.btnModificar.Text = "confirmar";
                    this.btnEliminar.Text = "cancelar";
                    this.btnAnteriorIngreso.Visible = false;
                    this.btnSiguienteIngreso.Visible = false;
                    this.btnContinuar.Visible = false;
                    this.comboBoxUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.comboBoxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;

                }
                else
                {
                    ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient auxNegocioIngreso = new ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient();
                    ServiceMantenedorIngresoProducto.Ingreso_P auxIngreso = new ServiceMantenedorIngresoProducto.Ingreso_P();
                    
                    auxIngreso.Id_ingreso = this.txtIdIngreso.Text;
                    auxIngreso.Fecha = DateTime.Parse(this.dateTimePickerFecha.Text);
                    auxIngreso.Usuario_rut = this.comboBoxUsuario.SelectedValue.ToString();
                    auxIngreso.Proveedor_rol = this.comboBoxProveedor.SelectedValue.ToString();

                    auxNegocioIngreso.actualizarIngresoProductoService(auxIngreso);
                    this.btnModificar.Text = "modificar";
                    this.desHabilitarIngreso();
                    this.btnAgregar.Visible = true;
                    this.btnAnteriorIngreso.Visible = true;
                    this.btnSiguienteIngreso.Visible = true;
                    this.btnEliminar.Text = "eliminar";
                    MessageBox.Show("Ingreso actualizado", "sistema");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient auxNegocioIngreso = new ServiceMantenedorIngresoProducto.WebServiceMantenedorIngresoProductoSoapClient();
                ServiceMantenedorIngresoProducto.Ingreso_P auxIngreso = new ServiceMantenedorIngresoProducto.Ingreso_P();
                
                auxIngreso.Id_ingreso = this.txtIdIngreso.Text;
                ServiceMantenedorDetalleIngreso.WebServiceMantenedorDetIngresoSoapClient auxNegocioDetalle = new ServiceMantenedorDetalleIngreso.WebServiceMantenedorDetIngresoSoapClient();
                ServiceMantenedorDetalleIngreso.Det_Ingreso auxDetalle = new ServiceMantenedorDetalleIngreso.Det_Ingreso();
                
                auxDetalle.Ingreso_p_id_ingreso = this.txtIdIngreso.Text;

                if (this.btnEliminar.Text == "eliminar")
                {
                    if (this.txtIdIngreso.Text == "")
                    {
                        MessageBox.Show(" ingrese un rut para eliminar ", "sistema");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(auxNegocioDetalle.buscarDetallePorIdIngresoService(auxDetalle.Ingreso_p_id_ingreso).Ingreso_p_id_ingreso)
                            && auxNegocioIngreso.buscarIngresoProductoService(auxIngreso.Id_ingreso).Id_ingreso == this.txtIdIngreso.Text)
                        {
                            auxNegocioIngreso.eliminarIngresoProductoService(auxIngreso.Id_ingreso);
                            MessageBox.Show(" ingreso eliminado ", "sistema");
                            this.comboBoxUsuario.DropDownStyle = ComboBoxStyle.Simple;
                            this.comboBoxProveedor.DropDownStyle = ComboBoxStyle.Simple;
                            this.limpiarIngreso();
                        }
                        else
                        {
                            MessageBox.Show("elimine todos los detalles asociados antes de eliminar el ingreso", " sistema");
                        }
                    }
                }
                if (this.btnEliminar.Text == "cancelar")
                {
                    this.comboBoxUsuario.DropDownStyle = ComboBoxStyle.Simple;
                    this.comboBoxProveedor.DropDownStyle = ComboBoxStyle.Simple;

                    this.limpiarIngreso();
                    this.desHabilitarIngreso();
                    this.btnEliminar.Text = "eliminar";
                    this.btnAgregar.Text = "guardar";
                    this.btnModificar.Text = "modificar";
                    this.btnModificar.Visible = true;
                    this.btnAgregar.Visible = true;
                    this.btnSiguienteIngreso.Visible = true;
                    this.btnAnteriorIngreso.Visible = true;
                    this.btnContinuar.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show(" elimine todos los detalles asociados antes de eliminar in ingreso ", "sistema");
            }
        }

        private void btnAnteriorIngreso_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion - 1;
            this.mostrarIngreso();
            this.cargarComboBoxIngreso();
        }

        private void btnSiguienteIngreso_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion + 1;
            this.mostrarIngreso();
            this.cargarComboBoxIngreso();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (this.txtIdIngreso.Text != ""
                && this.comboBoxUsuario.Text != ""
                && this.comboBoxProveedor.Text != ""
                && this.dateTimePickerFecha.Text != "")
            {
                this.desHabilitarIngreso();
                this.desHabilitarBotonIngreso();
                this.habilidarBotonDetalle();
            }
            else
            {
                MessageBox.Show(" complete el formulario de ingreso para continuar ", "sistema");
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            ServiceMantenedorDetalleIngreso.WebServiceMantenedorDetIngresoSoapClient auxNegocioDetalle = new ServiceMantenedorDetalleIngreso.WebServiceMantenedorDetIngresoSoapClient();
            ServiceMantenedorDetalleIngreso.Det_Ingreso auxDetalle = new ServiceMantenedorDetalleIngreso.Det_Ingreso();
            ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient auxNegocioProducto = new ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient();
            ServiceMantenedorProducto.Producto auxProducto = auxNegocioProducto.buscarProductoService(this.comboBoxCodigoProducto.Text);
            auxDetalle.Id_detalle_ingreso = this.txtIdDetalleIngreso.Text;
            

            int stock_producto;           
            stock_producto = auxProducto.Cantidad_total;


            if (this.btnEliminarDetalle.Text == "eliminar")
            {
                if (this.txtIdDetalleIngreso.Text == "")
                {
                    MessageBox.Show(" ingrese un Id Detalle para eliminar ", "sistema");
                }
                else
                {
                    if (String.IsNullOrEmpty(auxNegocioDetalle.buscarDetalleIngresoProductoService(auxDetalle.Id_detalle_ingreso).Id_detalle_ingreso))
                    {
                        MessageBox.Show("ingrese un ID Detalle  valido", " sistema");
                    }

                    else
                    {
                        auxProducto.Cantidad_total = stock_producto - int.Parse(this.txtCantidad.Text);
                        auxProducto.Codigo = this.comboBoxCodigoProducto.Text;
                        auxNegocioProducto.actualizarProductoService(auxProducto);

                        auxNegocioDetalle.eliminarDetalleIngresoProductoService(auxDetalle.Id_detalle_ingreso);
                        MessageBox.Show(" Detalle eliminado ", "sistema");
                        this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.Simple;
                        this.limpiarDetalle();
                    }
                }
            }
            if (this.btnEliminarDetalle.Text == "cancelar")
            {
                this.desHabilitarDetalle();
                this.btnEliminarDetalle.Text = "eliminar";
                this.btnGuardarDetalle.Text = "guardar";

                this.btnGuardarDetalle.Visible = true;
                this.btnSiguienteDetalle.Visible = true;
                this.btnAnteriorDetalle.Visible = true;
                this.btnVolver.Visible = true;
            }
        }

        private void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            if (this.btnGuardarDetalle.Text.Equals("guardar"))
            {

                this.btnGuardarDetalle.Text = "confirmar";
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
                    ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient auxNegocioProducto = new ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient();
                    ServiceMantenedorProducto.Producto auxProducto = auxNegocioProducto.buscarProductoService(this.comboBoxCodigoProducto.Text);
                    ServiceMantenedorDetalleIngreso.WebServiceMantenedorDetIngresoSoapClient auxNegocioDetalle = new ServiceMantenedorDetalleIngreso.WebServiceMantenedorDetIngresoSoapClient();
                    ServiceMantenedorDetalleIngreso.Det_Ingreso auxDetalle = new ServiceMantenedorDetalleIngreso.Det_Ingreso();
                    int valor_unitario_producto;
                    int stock_producto;
                    
                    valor_unitario_producto = auxProducto.Precio_unitario;
                    stock_producto = auxProducto.Cantidad_total;
                    
                    auxDetalle.Id_detalle_ingreso = this.txtIdDetalleIngreso.Text;
                    auxDetalle.Cantidad = int.Parse(this.txtCantidad.Text);
                    auxDetalle.Valor_total = auxDetalle.Cantidad * valor_unitario_producto;
                    auxDetalle.Ingreso_p_id_ingreso = this.txtIdIngreso.Text;
                    auxDetalle.Producto_codigo = this.comboBoxCodigoProducto.SelectedValue.ToString();


                    if (String.IsNullOrEmpty(auxNegocioDetalle.buscarDetalleIngresoProductoService(auxDetalle.Id_detalle_ingreso).Id_detalle_ingreso))
                    {

                        if (string.IsNullOrEmpty(this.txtIdDetalleIngreso.Text)
                            || string.IsNullOrEmpty(this.txtCantidad.Text)
                            || string.IsNullOrEmpty(this.comboBoxCodigoProducto.Text)
                            || string.IsNullOrEmpty(this.txtValorTotal.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            if (auxDetalle.Cantidad > 0)
                            {
                                if (this.txtValorTotal.Text == Convert.ToString(auxDetalle.Valor_total))
                                {
                                    auxNegocioDetalle.insertarDetalleIngresoProductoService(auxDetalle);
                                    auxProducto.Codigo = this.comboBoxCodigoProducto.Text;
                                    auxProducto.Cantidad_total = stock_producto + auxDetalle.Cantidad;
                                    auxNegocioProducto.actualizarProductoService(auxProducto);
                                    this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.Simple;
                                    this.limpiarDetalle();
                                    MessageBox.Show("datos guardados correctamente", "sistema");
                                    this.btnGuardarDetalle.Text = "guardar";
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtCantidad.Text != "" && this.comboBoxCodigoProducto.Text != "")
            {
                int valor;
                int cantidad;
                ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient auxNegocioProducto = new ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient();
                ServiceMantenedorProducto.Producto auxProducto = auxNegocioProducto.buscarProductoService(this.comboBoxCodigoProducto.Text);
                
                valor = auxProducto.Precio_unitario;
                cantidad = int.Parse(this.txtCantidad.Text);
                this.txtValorTotal.Text = Convert.ToString(valor * cantidad);
            }
            else
            {
                MessageBox.Show("complete los campos cantidad y codigo", "sistema");
            }
        }

        private void btnAnteriorDetalle_Click(object sender, EventArgs e)
        {
            this.Posicion2 = this.Posicion2 - 1;
            this.mostrarDetalle();
        }

        private void btnSiguienteDetalle_Click(object sender, EventArgs e)
        {
            this.Posicion2 = this.Posicion2 + 1;
            this.mostrarDetalle();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.habilitarBotonIngreso();
            this.desHabilidarBotonDetalle();
            this.limpiarDetalle();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
