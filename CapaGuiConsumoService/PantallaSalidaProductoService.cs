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
    public partial class PantallaSalidaProductoService : Form
    {
        public PantallaSalidaProductoService()
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


        private int posicion3;
        private int ultimo3;

        public int Posicion3 { get => posicion3; set => posicion3 = value; }
        public int Ultimo3 { get => ultimo3; set => ultimo3 = value; }

        //-----------------------------------------------------------------------------------------------------------------------------------------



        public void habilitarCliente()
        {
            this.txtRutCliente.Enabled = true;
            this.txtNombreCliente.Enabled = true;
            this.txtApellidoCliente.Enabled = true;
            this.txtTelefonoCliente.Enabled = true;
        }

        public void desHabilitarCliente()
        {
            this.txtRutCliente.Enabled = false;
            this.txtNombreCliente.Enabled = false;
            this.txtApellidoCliente.Enabled = false;
            this.txtTelefonoCliente.Enabled = false;
        }

        public void limpiarCliente()
        {
            this.txtRutCliente.Text = "";
            this.txtNombreCliente.Text = "";
            this.txtApellidoCliente.Text = "";
            this.txtTelefonoCliente.Text = "";
        }


        //------------------------------------------------------------------------------------------------------------------------------------------

        public void mostrarCliente()
        {

            ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocioCliente = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
            ServiceMantenedorCliente.Cliente auxCliente = new ServiceMantenedorCliente.Cliente();
            
            this.ultimo = auxNegocioCliente.retornarClienteService().Tables["cliente"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= ultimo)
                this.posicion = ultimo;

            auxCliente = auxNegocioCliente.retornaPosicionClienteService(this.posicion);
            this.txtRutCliente.Text = auxCliente.Rut;
            this.txtNombreCliente.Text = auxCliente.Nombre;
            this.txtApellidoCliente.Text = auxCliente.Apellido;
            this.txtTelefonoCliente.Text = Convert.ToString(auxCliente.Telefono);


        }


        //------------------------------------------------------------------------------------------------------------------------------------------

        public void habilitarSalida()
        {
            this.txtIdSalida.Enabled = true;
            this.comboBoxRutCliente.Enabled = true;
            this.comboBoxRutUsuario.Enabled = true;
            this.dateTimePickerFecha.Enabled = true;

        }

        public void desHabilitarSalida()
        {
            this.txtIdSalida.Enabled = false;
            this.comboBoxRutCliente.Enabled = false;
            this.comboBoxRutUsuario.Enabled = false;
            this.dateTimePickerFecha.Enabled = false;

        }

        public void limpiarSalida()
        {
            this.txtIdSalida.Text = "";
            this.comboBoxRutCliente.Text = "";
            this.comboBoxRutUsuario.Text = "";
            this.dateTimePickerFecha.Text = "";

        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        public void mostrarSalida()
        {

            ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient auxNegocioSalida = new ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient();
            ServiceMantenedorSalidaProducto.Salida_P auxSalida = new ServiceMantenedorSalidaProducto.Salida_P();
            
            this.Ultimo2 = auxNegocioSalida.retornarSalidaProductoService().Tables["salida_p"].Rows.Count - 1;
            if (this.Posicion2 <= 0)
                this.Posicion2 = 0;
            if (this.Posicion2 >= Ultimo2)
                this.Posicion2 = Ultimo2;

            auxSalida = auxNegocioSalida.retornaPosicionSalidaProductoService(this.posicion2);
            this.txtIdSalida.Text = auxSalida.Id_salida;
            this.comboBoxRutCliente.Text = auxSalida.Cliente_rut;
            this.comboBoxRutUsuario.Text = auxSalida.Usuario_rut;
            this.dateTimePickerFecha.Text = Convert.ToString(auxSalida.Fecha);

        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        public void desHabilitarBotonSalida()
        {
            this.btnAgregarSalida.Visible = false;
            this.btnModificarSalida.Visible = false;
            this.btnEliminarSalida.Visible = false;
            this.btnSiguienteSalida.Visible = false;
            this.btnAnteriorSalida.Visible = false;
        }

        public void habilitarBotonSalida()
        {
            this.btnAgregarSalida.Visible = true;
            this.btnModificarSalida.Visible = true;
            this.btnEliminarSalida.Visible = true;
            this.btnSiguienteSalida.Visible = true;
            this.btnAnteriorSalida.Visible = true;
        }


        //------------------------------------------------------------------------------------------------------------------------------------------


        public void habilitarDetalle()
        {
            this.txtIdDetalle.Enabled = true;
            this.txtCantidad.Enabled = true;
            this.comboBoxCodigoProducto.Enabled = true;
            this.txtValorTotal.Enabled = true;
        }

        public void desHabilitarDetalle()
        {
            this.txtIdDetalle.Enabled = false;
            this.txtCantidad.Enabled = false;
            this.comboBoxCodigoProducto.Enabled = false;
            this.txtValorTotal.Enabled = false;
        }

        public void limpiarDetalle()
        {
            this.txtIdDetalle.Text = "";
            this.comboBoxCodigoProducto.Text = "";
            this.txtCantidad.Text = "";
            this.txtValorTotal.Text = "";
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        public void mostrarDetalle()
        {
            ServiceMantenedorDetalleSalida.WebServiceMantenedorDetSalidaSoapClient auxNegocioDetalle = new ServiceMantenedorDetalleSalida.WebServiceMantenedorDetSalidaSoapClient();
            ServiceMantenedorDetalleSalida.Det_Salida auxDetalle = new ServiceMantenedorDetalleSalida.Det_Salida();
            
            this.Ultimo3 = auxNegocioDetalle.retornarDetalleSalidaProductoService(this.txtIdSalida.Text).Tables["det_salida"].Rows.Count - 1;
            if (this.Posicion3 <= 0)
                this.Posicion3 = 0;
            if (this.Posicion3 >= Ultimo3)
                this.Posicion3 = Ultimo3;

            auxDetalle = auxNegocioDetalle.retornaPosicionDetalleSalidaProductoService(this.posicion3, this.txtIdSalida.Text);
            this.txtIdDetalle.Text = auxDetalle.Id_detalle_salida;
            this.txtCantidad.Text = Convert.ToString(auxDetalle.Cantidad);
            this.comboBoxCodigoProducto.Text = auxDetalle.Producto_codigo;
            this.txtValorTotal.Text = Convert.ToString(auxDetalle.Valor_total);
        }

        //------------------------------------------------------------------------------------------------------------------------------------------

        public void desHabilitarBotonDetalle()
        {
            this.btnAgregarDetalle.Visible = false;
            this.btnEliminarDetalle.Visible = false;
            this.btnSiguienteDetalle.Visible = false;
            this.btnAnteriorDetalle.Visible = false;
            this.btnCalcular.Visible = false;

        }

        public void habilitarBotonDetalle()
        {
            this.btnAgregarDetalle.Visible = true;
            this.btnEliminarDetalle.Visible = true;
            this.btnSiguienteDetalle.Visible = true;
            this.btnAnteriorDetalle.Visible = true;
            this.btnCalcular.Visible = true;

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (this.btnAgregarCliente.Text.Equals("guardar"))
            {
                this.habilitarCliente();
                this.btnAgregarCliente.Text = "confirmar";
                this.btnEliminarDetalle.Text = "cancelar";
                this.limpiarCliente();
                this.btnEliminarCliente.Text = "cancelar";
                this.btnSiguienteCliente.Visible = false;
                this.btnAnteriorCliente.Visible = false;
                this.btnModificarCliente.Visible = false;
            }
            else
            {
                try
                {
                    ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocioCliente = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                    ServiceMantenedorCliente.Cliente auxCliente = new ServiceMantenedorCliente.Cliente();
                    
                    auxCliente.Rut = this.txtRutCliente.Text;
                    auxCliente.Nombre = this.txtNombreCliente.Text;
                    auxCliente.Apellido = this.txtApellidoCliente.Text;
                    auxCliente.Telefono = int.Parse(this.txtTelefonoCliente.Text);
                    

                    if (String.IsNullOrEmpty(auxNegocioCliente.buscarClienteService(auxCliente.Rut).Rut))
                    {
                        if (string.IsNullOrEmpty(this.txtRutCliente.Text)
                            || string.IsNullOrEmpty(this.txtNombreCliente.Text)
                            || string.IsNullOrEmpty(this.txtApellidoCliente.Text)
                            || string.IsNullOrEmpty(this.txtTelefonoCliente.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            auxNegocioCliente.insertarClienteService(auxCliente);
                            this.limpiarCliente();
                            MessageBox.Show("datos guardados correctamente", "sistema");
                            this.btnAgregarCliente.Text = "guardar";
                            this.btnEliminarCliente.Text = "eliminar";
                            this.desHabilitarCliente();
                            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet12.cliente' Puede moverla o quitarla según sea necesario.
                            this.clienteTableAdapter.Fill(this.controlExistenciasDataSet.cliente);
                            this.btnModificarCliente.Visible = true;
                            this.btnSiguienteCliente.Visible = true;
                            this.btnAnteriorCliente.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("cliente ya existe", "sistema");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al guardar" + ex.Message, "sistema");
                }
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (this.txtRutCliente.Text == "")
            {
                MessageBox.Show("campo Rut cliente vacio", "sistema");
            }
            else
            {
                if (this.btnModificarCliente.Text.Equals("modificar"))
                {
                    this.habilitarCliente();
                    this.txtRutCliente.Enabled = false;
                    this.btnAgregarCliente.Visible = false;
                    this.btnModificarCliente.Text = "confirmar";
                    this.btnEliminarCliente.Text = "cancelar";
                    this.btnAnteriorCliente.Visible = false;
                    this.btnSiguienteCliente.Visible = false;
                }
                else
                {
                    ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocioCliente = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                    ServiceMantenedorCliente.Cliente auxCliente = new ServiceMantenedorCliente.Cliente();
                    auxCliente.Rut = this.txtRutCliente.Text;
                    auxCliente.Nombre = this.txtNombreCliente.Text;
                    auxCliente.Apellido = this.txtApellidoCliente.Text;
                    auxCliente.Telefono = int.Parse(this.txtTelefonoCliente.Text);
                    auxNegocioCliente.actualizarClienteService(auxCliente);
                    this.btnModificarCliente.Text = "modificar";
                    this.desHabilitarCliente();
                    this.btnAgregarCliente.Visible = true;
                    this.btnAnteriorCliente.Visible = true;
                    this.btnSiguienteCliente.Visible = true;
                    this.btnEliminarCliente.Text = "eliminar";
                    MessageBox.Show("Ingreso actualizado", "sistema");
                }
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocioCliente = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                ServiceMantenedorCliente.Cliente auxCliente = new ServiceMantenedorCliente.Cliente();
                auxCliente.Rut = this.txtRutCliente.Text;

                ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient auxNegocioSalida = new ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient();
                ServiceMantenedorSalidaProducto.Salida_P auxSalida = new ServiceMantenedorSalidaProducto.Salida_P();
                auxSalida.Cliente_rut = this.txtRutCliente.Text;

                if (this.btnEliminarCliente.Text == "eliminar")
                {
                    if (this.txtRutCliente.Text == "")
                    {
                        MessageBox.Show(" ingrese un rut para eliminar ", "sistema");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(auxNegocioSalida.buscarSalidaPorRutClienteService(auxSalida.Cliente_rut).Cliente_rut)
                            && auxNegocioCliente.buscarClienteService(auxCliente.Rut).Rut == this.txtRutCliente.Text)
                        {
                            auxNegocioCliente.eliminarClienteService(auxCliente.Rut);
                            MessageBox.Show(" Cliente eliminado ", "sistema");
                            this.limpiarCliente();
                        }
                        else
                        {
                            MessageBox.Show("elimine todas las salidas asociadas antes de eliminar cliente", " sistema");
                        }
                    }
                }
                if (this.btnEliminarCliente.Text == "cancelar")
                {
                    this.limpiarCliente();
                    this.desHabilitarCliente();
                    this.btnEliminarCliente.Text = "eliminar";
                    this.btnAgregarCliente.Text = "guardar";
                    this.btnModificarCliente.Text = "modificar";
                    this.btnModificarCliente.Visible = true;
                    this.btnAgregarCliente.Visible = true;
                    this.btnSiguienteCliente.Visible = true;
                    this.btnAnteriorCliente.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show(" elimine todos los registros de salida asociados al cliente antes de eliminar ", "sistema");
            }
        }

        private void btnAnteriorCliente_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion - 1;
            this.mostrarCliente();
        }

        private void btnSiguienteCliente_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion + 1;
            this.mostrarCliente();
        }

        private void PantallaSalidaProductoService_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet2.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.controlExistenciasDataSet2.producto);
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet1.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.controlExistenciasDataSet1.usuario);
            // TODO: esta línea de código carga datos en la tabla 'controlExistenciasDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.controlExistenciasDataSet.cliente);
            this.desHabilitarCliente();
            this.desHabilitarSalida();
            this.desHabilitarDetalle();
            this.limpiarSalida();
            this.limpiarDetalle();
            this.limpiarCliente();
            this.desHabilitarBotonDetalle();
            this.btnVolverDetalle.Visible = false;
        }

        private void btnEliminarSalida_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient auxNegocioSalida = new ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient();
                ServiceMantenedorSalidaProducto.Salida_P auxSalida = new ServiceMantenedorSalidaProducto.Salida_P();
                ServiceMantenedorDetalleSalida.WebServiceMantenedorDetSalidaSoapClient auxNegocioDetalle = new ServiceMantenedorDetalleSalida.WebServiceMantenedorDetSalidaSoapClient();
                ServiceMantenedorDetalleSalida.Det_Salida auxDetalle = new ServiceMantenedorDetalleSalida.Det_Salida();
                auxSalida.Id_salida = this.txtIdSalida.Text;            
                auxDetalle.Salida_p_id_salida = this.txtIdSalida.Text;

                if (this.btnEliminarSalida.Text == "eliminar")
                {
                    if (this.txtIdSalida.Text == "")
                    {
                        MessageBox.Show(" seleccione un Id salida para eliminar ", "sistema");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(auxNegocioDetalle.buscarDetallePorIdSalidaService(auxDetalle.Salida_p_id_salida).Salida_p_id_salida)
                            && auxNegocioSalida.buscarSalidaProductoService(auxSalida.Id_salida).Id_salida == this.txtIdSalida.Text)
                        {
                            auxNegocioSalida.eliminarSalidaProductoService(auxSalida.Id_salida);
                            MessageBox.Show(" Salida eliminada ", "sistema");
                            this.limpiarSalida();
                        }
                        else
                        {
                            MessageBox.Show("no se puede eliminar Salida  \n" +
                           "tiene detalles asociados \n" +
                           "elimine todos los detalles asociados antes de eliminar salida", "sistema");
                        }
                    }
                }
                if (this.btnEliminarSalida.Text == "cancelar")
                {
                    this.comboBoxRutCliente.DropDownStyle = ComboBoxStyle.Simple;
                    this.comboBoxRutUsuario.DropDownStyle = ComboBoxStyle.Simple;
                    this.limpiarSalida();
                    this.desHabilitarSalida();
                    this.btnEliminarSalida.Text = "eliminar";
                    this.btnAgregarSalida.Text = "guardar";
                    this.btnModificarSalida.Text = "modificar";
                    this.btnModificarSalida.Visible = true;
                    this.btnAgregarSalida.Visible = true;
                    this.btnSiguienteSalida.Visible = true;
                    this.btnAnteriorSalida.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show(" borrar todos los registros de detalle asociados al Id Salida antes de eliminar ", "sistema");
            }
        }

        private void btnModificarSalida_Click(object sender, EventArgs e)
        {
            if (this.txtIdSalida.Text == "")
            {
                MessageBox.Show("campo Id Salida vacio", "sistema");
            }
            else
            {
                if (this.btnModificarSalida.Text.Equals("modificar"))
                {
                    this.habilitarSalida();
                    this.txtIdSalida.Enabled = false;
                    this.btnAgregarSalida.Visible = false;
                    this.btnModificarSalida.Text = "confirmar";
                    this.btnEliminarSalida.Text = "cancelar";
                    this.btnAnteriorSalida.Visible = false;
                    this.btnSiguienteSalida.Visible = false;
                }
                else
                {
                    ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient auxNegocioSalida = new ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient();
                    ServiceMantenedorSalidaProducto.Salida_P auxSalida = new ServiceMantenedorSalidaProducto.Salida_P();
                    
                    auxSalida.Id_salida = this.txtIdSalida.Text;
                    auxSalida.Cliente_rut = this.comboBoxRutCliente.SelectedValue.ToString();
                    auxSalida.Usuario_rut = this.comboBoxRutUsuario.SelectedValue.ToString();
                    auxSalida.Fecha = DateTime.Parse(this.dateTimePickerFecha.Text);
                    auxNegocioSalida.actualizarSalidaProductoService(auxSalida);
                    this.btnModificarSalida.Text = "modificar";
                    this.desHabilitarSalida();
                    this.btnAgregarSalida.Visible = true;
                    this.btnAnteriorSalida.Visible = true;
                    this.btnSiguienteSalida.Visible = true;
                    this.btnEliminarSalida.Text = "eliminar";
                    MessageBox.Show("Ingreso actualizado", "sistema");
                }
            }
        }

        private void btnAgregarSalida_Click(object sender, EventArgs e)
        {
            if (this.btnAgregarSalida.Text.Equals("guardar"))
            {
                this.habilitarSalida();
                this.btnAgregarSalida.Text = "confirmar";
                this.btnEliminarSalida.Text = "cancelar";
                this.limpiarSalida();
                this.btnEliminarSalida.Text = "cancelar";
                this.btnSiguienteSalida.Visible = false;
                this.btnAnteriorSalida.Visible = false;
                this.btnModificarSalida.Visible = false;
                this.comboBoxRutCliente.DropDownStyle = ComboBoxStyle.DropDownList;
                this.comboBoxRutUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                try
                {
                    ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient auxNegocioSalida = new ServiceMantenedorSalidaProducto.WebServiceMantenedorSalidaProductoSoapClient();
                    ServiceMantenedorSalidaProducto.Salida_P auxSalida = new ServiceMantenedorSalidaProducto.Salida_P();
                    auxSalida.Id_salida = this.txtIdSalida.Text;
                    auxSalida.Cliente_rut = this.comboBoxRutCliente.SelectedValue.ToString();
                    auxSalida.Usuario_rut = this.comboBoxRutUsuario.SelectedValue.ToString();
                    auxSalida.Fecha = DateTime.Parse(this.dateTimePickerFecha.Text);

                    if (String.IsNullOrEmpty(auxNegocioSalida.buscarSalidaProductoService(auxSalida.Id_salida).Id_salida))
                    {

                        if (string.IsNullOrEmpty(this.txtIdSalida.Text)
                            || string.IsNullOrEmpty(this.comboBoxRutCliente.Text)
                            || string.IsNullOrEmpty(this.comboBoxRutUsuario.Text)
                            || string.IsNullOrEmpty(this.dateTimePickerFecha.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            auxNegocioSalida.insertarSalidaProductoService(auxSalida);
                            this.comboBoxRutCliente.DropDownStyle = ComboBoxStyle.Simple;
                            this.comboBoxRutUsuario.DropDownStyle = ComboBoxStyle.Simple;
                            this.limpiarSalida();
                            MessageBox.Show("datos guardados correctamente", "sistema");
                            this.btnAgregarSalida.Text = "guardar";
                            this.btnEliminarSalida.Text = "eliminar";
                            this.desHabilitarSalida();
                            this.btnModificarSalida.Visible = true;
                            this.btnSiguienteSalida.Visible = true;
                            this.btnAnteriorSalida.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Salida ya existe", "sistema");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al guardar" + ex.Message, "sistema");
                }
            }
        }

        private void btnAnteriorSalida_Click(object sender, EventArgs e)
        {
            this.Posicion2 = this.Posicion2 - 1;
            this.mostrarSalida();
        }

        private void btnSiguienteSalida_Click(object sender, EventArgs e)
        {
            this.Posicion2 = this.Posicion2 + 1;
            this.mostrarSalida();
        }

        private void btnContinuarSalida_Click(object sender, EventArgs e)
        {
            if (this.txtIdSalida.Text != ""
                && this.comboBoxRutCliente.Text != ""
                && this.comboBoxRutUsuario.Text != ""
                && this.dateTimePickerFecha.Text != "")
            {
                this.desHabilitarBotonSalida();
                this.habilitarBotonDetalle();
                this.btnContinuarSalida.Visible = false;
                this.btnVolverDetalle.Visible = true;
                this.limpiarDetalle();
            }
            else
            {
                MessageBox.Show(" complete el formulario de Salida para continuar ", "sistema");
            }
        }

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
                this.btnVolverDetalle.Visible = false;
                this.txtValorTotal.Enabled = false;
            }
            else
            {
                try
                {
                    int valor_unitario_producto;
                    int stock_producto;
                    ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient auxNegocioProducto = new ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient();
                    ServiceMantenedorProducto.Producto auxProducto = auxNegocioProducto.buscarProductoService(this.comboBoxCodigoProducto.Text);
                    
                    valor_unitario_producto = auxProducto.Precio_unitario;
                    stock_producto = auxProducto.Cantidad_total;
                    ServiceMantenedorDetalleSalida.WebServiceMantenedorDetSalidaSoapClient auxNegocioDetalle = new ServiceMantenedorDetalleSalida.WebServiceMantenedorDetSalidaSoapClient();
                    ServiceMantenedorDetalleSalida.Det_Salida auxDetalle = new ServiceMantenedorDetalleSalida.Det_Salida();
                    auxDetalle.Id_detalle_salida = this.txtIdDetalle.Text;
                    auxDetalle.Cantidad = int.Parse(this.txtCantidad.Text);
                    auxDetalle.Valor_total = auxDetalle.Cantidad * valor_unitario_producto;
                    auxDetalle.Salida_p_id_salida = this.txtIdSalida.Text;
                    auxDetalle.Producto_codigo = this.comboBoxCodigoProducto.SelectedValue.ToString();

                    if (String.IsNullOrEmpty(auxNegocioDetalle.buscarDetalleSalidaProductoService(auxDetalle.Id_detalle_salida).Id_detalle_salida))
                    {

                        if (string.IsNullOrEmpty(this.txtIdDetalle.Text)
                            || string.IsNullOrEmpty(this.txtCantidad.Text)
                            || string.IsNullOrEmpty(this.comboBoxCodigoProducto.Text)
                            || string.IsNullOrEmpty(this.txtValorTotal.Text)
                            || string.IsNullOrEmpty(this.txtIdSalida.Text))
                        {
                            MessageBox.Show("complete todos los campos", "sistema");
                        }
                        else
                        {
                            if (auxDetalle.Cantidad > 0)
                            {
                                if (this.txtValorTotal.Text == Convert.ToString(auxDetalle.Valor_total))
                                {
                                    auxNegocioDetalle.insertarDetalleSalidaProductoService(auxDetalle);
                                    auxProducto.Codigo = this.comboBoxCodigoProducto.Text;
                                    auxProducto.Cantidad_total = stock_producto - auxDetalle.Cantidad;
                                    auxNegocioProducto.actualizarProductoService(auxProducto);
                                    this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.Simple;
                                    this.limpiarDetalle();
                                    MessageBox.Show("datos guardados correctamente", "sistema");
                                    this.btnAgregarDetalle.Text = "guardar";
                                    this.btnEliminarDetalle.Text = "eliminar";
                                    this.btnSiguienteDetalle.Visible = true;
                                    this.btnAnteriorDetalle.Visible = true;
                                    this.btnVolverDetalle.Visible = true;
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

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            ServiceMantenedorDetalleSalida.WebServiceMantenedorDetSalidaSoapClient auxNegocioDetalle = new ServiceMantenedorDetalleSalida.WebServiceMantenedorDetSalidaSoapClient();
            ServiceMantenedorDetalleSalida.Det_Salida auxDetalle = new ServiceMantenedorDetalleSalida.Det_Salida();
            ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient auxNegocioProducto = new ServiceMantenedorProducto.WebServiceMantenedorProductoSoapClient();
            ServiceMantenedorProducto.Producto auxProducto = auxNegocioProducto.buscarProductoService(this.comboBoxCodigoProducto.Text);
            auxDetalle.Id_detalle_salida = this.txtIdDetalle.Text;
            
            int stock_producto;
            
            
            stock_producto = auxProducto.Cantidad_total;

            if (this.btnEliminarDetalle.Text == "eliminar")
            {
                if (this.txtIdDetalle.Text == "")
                {
                    MessageBox.Show(" ingrese un Id Detalle para eliminar ", "sistema");
                }
                else
                {
                    if (String.IsNullOrEmpty(auxNegocioDetalle.buscarDetalleSalidaProductoService(auxDetalle.Id_detalle_salida).Id_detalle_salida))
                    {
                        MessageBox.Show("ingrese un ID Detalle  valido", " sistema");
                    }
                    else
                    {
                        auxProducto.Cantidad_total = stock_producto + int.Parse(this.txtCantidad.Text);
                        auxProducto.Codigo = this.comboBoxCodigoProducto.Text;
                        auxNegocioProducto.actualizarProductoService(auxProducto);
                        auxNegocioDetalle.eliminarDetalleSalidaProductoService(auxDetalle.Id_detalle_salida);
                        MessageBox.Show(" Detalle eliminado ", "sistema");
                        this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.Simple;
                        this.limpiarDetalle();
                    }
                }
            }
            if (this.btnEliminarDetalle.Text == "cancelar")
            {
                this.comboBoxCodigoProducto.DropDownStyle = ComboBoxStyle.Simple;
                this.limpiarDetalle();
                this.desHabilitarDetalle();
                this.desHabilitarSalida();
                this.btnEliminarDetalle.Text = "eliminar";
                this.btnAgregarDetalle.Text = "guardar";
                this.btnAgregarDetalle.Visible = true;
                this.btnSiguienteDetalle.Visible = true;
                this.btnAnteriorDetalle.Visible = true;
                this.btnVolverDetalle.Visible = true;
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
            this.Posicion3 = this.Posicion3 - 1;
            this.mostrarDetalle();
        }

        private void btnSiguienteDetalle_Click(object sender, EventArgs e)
        {
            this.Posicion3 = this.Posicion3 + 1;
            this.mostrarDetalle();
        }

        private void btnVolverDetalle_Click(object sender, EventArgs e)
        {
            this.habilitarBotonSalida();
            this.desHabilitarBotonDetalle();
            this.btnVolverDetalle.Visible = false;
            this.btnContinuarSalida.Visible = true;
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
