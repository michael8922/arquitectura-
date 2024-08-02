
namespace CapaGUI
{
    partial class PantallaIngresoProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIdIngreso = new System.Windows.Forms.TextBox();
            this.txtIdDetalleIngreso = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAnteriorDetalle = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSiguienteDetalle = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet1 = new CapaGUI.ControlExistenciasDataSet1();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet5 = new CapaGUI.ControlExistenciasDataSet5();
            this.usuarioTableAdapter = new CapaGUI.ControlExistenciasDataSet1TableAdapters.usuarioTableAdapter();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet2 = new CapaGUI.ControlExistenciasDataSet2();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet6 = new CapaGUI.ControlExistenciasDataSet6();
            this.proveedorTableAdapter = new CapaGUI.ControlExistenciasDataSet2TableAdapters.proveedorTableAdapter();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet3 = new CapaGUI.ControlExistenciasDataSet3();
            this.sucursalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet7 = new CapaGUI.ControlExistenciasDataSet7();
            this.sucursalTableAdapter = new CapaGUI.ControlExistenciasDataSet3TableAdapters.sucursalTableAdapter();
            this.comboBoxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet4 = new CapaGUI.ControlExistenciasDataSet4();
            this.productoTableAdapter = new CapaGUI.ControlExistenciasDataSet4TableAdapters.productoTableAdapter();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.usuarioTableAdapter1 = new CapaGUI.ControlExistenciasDataSet5TableAdapters.usuarioTableAdapter();
            this.proveedorTableAdapter1 = new CapaGUI.ControlExistenciasDataSet6TableAdapters.proveedorTableAdapter();
            this.sucursalTableAdapter1 = new CapaGUI.ControlExistenciasDataSet7TableAdapters.sucursalTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelIdUsuario = new System.Windows.Forms.Label();
            this.labelIdProveedor = new System.Windows.Forms.Label();
            this.labelIdSucursal = new System.Windows.Forms.Label();
            this.btnSiguienteIngreso = new System.Windows.Forms.Button();
            this.btnAnteriorIngreso = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.groupBoxDetalle = new System.Windows.Forms.GroupBox();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnGuardarDetalle = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdIngreso
            // 
            this.txtIdIngreso.Location = new System.Drawing.Point(242, 111);
            this.txtIdIngreso.Name = "txtIdIngreso";
            this.txtIdIngreso.Size = new System.Drawing.Size(229, 22);
            this.txtIdIngreso.TabIndex = 0;
            // 
            // txtIdDetalleIngreso
            // 
            this.txtIdDetalleIngreso.Location = new System.Drawing.Point(157, 54);
            this.txtIdDetalleIngreso.Name = "txtIdDetalleIngreso";
            this.txtIdDetalleIngreso.Size = new System.Drawing.Size(291, 22);
            this.txtIdDetalleIngreso.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(157, 89);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(291, 22);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(157, 150);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(170, 22);
            this.txtValorTotal.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(818, 545);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnteriorDetalle
            // 
            this.btnAnteriorDetalle.Location = new System.Drawing.Point(153, 194);
            this.btnAnteriorDetalle.Name = "btnAnteriorDetalle";
            this.btnAnteriorDetalle.Size = new System.Drawing.Size(57, 23);
            this.btnAnteriorDetalle.TabIndex = 10;
            this.btnAnteriorDetalle.Text = "<";
            this.btnAnteriorDetalle.UseVisualStyleBackColor = true;
            this.btnAnteriorDetalle.Click += new System.EventHandler(this.btnAnteriorDetalle_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(42, 181);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 48);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSiguienteDetalle
            // 
            this.btnSiguienteDetalle.Location = new System.Drawing.Point(275, 194);
            this.btnSiguienteDetalle.Name = "btnSiguienteDetalle";
            this.btnSiguienteDetalle.Size = new System.Drawing.Size(52, 23);
            this.btnSiguienteDetalle.TabIndex = 12;
            this.btnSiguienteDetalle.Text = ">";
            this.btnSiguienteDetalle.UseVisualStyleBackColor = true;
            this.btnSiguienteDetalle.Click += new System.EventHandler(this.btnSiguienteDetalle_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(333, 149);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(42, 127);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 48);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(42, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 48);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "valor total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Codigo Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID Detalle Ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha ";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.DataSource = this.usuarioBindingSource1;
            this.comboBoxUsuario.DisplayMember = "nombre";
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(242, 150);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(229, 24);
            this.comboBoxUsuario.TabIndex = 29;
            this.comboBoxUsuario.ValueMember = "rut";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.controlExistenciasDataSet1;
            // 
            // controlExistenciasDataSet1
            // 
            this.controlExistenciasDataSet1.DataSetName = "ControlExistenciasDataSet1";
            this.controlExistenciasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.controlExistenciasDataSet5;
            // 
            // controlExistenciasDataSet5
            // 
            this.controlExistenciasDataSet5.DataSetName = "ControlExistenciasDataSet5";
            this.controlExistenciasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.DataSource = this.proveedorBindingSource1;
            this.comboBoxProveedor.DisplayMember = "nombre_proveedor";
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(242, 190);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(229, 24);
            this.comboBoxProveedor.TabIndex = 30;
            this.comboBoxProveedor.ValueMember = "rol";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.controlExistenciasDataSet2;
            // 
            // controlExistenciasDataSet2
            // 
            this.controlExistenciasDataSet2.DataSetName = "ControlExistenciasDataSet2";
            this.controlExistenciasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "proveedor";
            this.proveedorBindingSource1.DataSource = this.controlExistenciasDataSet6;
            // 
            // controlExistenciasDataSet6
            // 
            this.controlExistenciasDataSet6.DataSetName = "ControlExistenciasDataSet6";
            this.controlExistenciasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataMember = "sucursal";
            this.sucursalBindingSource.DataSource = this.controlExistenciasDataSet3;
            // 
            // controlExistenciasDataSet3
            // 
            this.controlExistenciasDataSet3.DataSetName = "ControlExistenciasDataSet3";
            this.controlExistenciasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sucursalBindingSource1
            // 
            this.sucursalBindingSource1.DataMember = "sucursal";
            this.sucursalBindingSource1.DataSource = this.controlExistenciasDataSet7;
            // 
            // controlExistenciasDataSet7
            // 
            this.controlExistenciasDataSet7.DataSetName = "ControlExistenciasDataSet7";
            this.controlExistenciasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sucursalTableAdapter
            // 
            this.sucursalTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxCodigoProducto
            // 
            this.comboBoxCodigoProducto.DataSource = this.productoBindingSource;
            this.comboBoxCodigoProducto.DisplayMember = "codigo";
            this.comboBoxCodigoProducto.FormattingEnabled = true;
            this.comboBoxCodigoProducto.Location = new System.Drawing.Point(157, 117);
            this.comboBoxCodigoProducto.Name = "comboBoxCodigoProducto";
            this.comboBoxCodigoProducto.Size = new System.Drawing.Size(291, 24);
            this.comboBoxCodigoProducto.TabIndex = 32;
            this.comboBoxCodigoProducto.ValueMember = "codigo";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.controlExistenciasDataSet4;
            // 
            // controlExistenciasDataSet4
            // 
            this.controlExistenciasDataSet4.DataSetName = "ControlExistenciasDataSet4";
            this.controlExistenciasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(584, 39);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(113, 22);
            this.dateTimePickerFecha.TabIndex = 33;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter1
            // 
            this.proveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // sucursalTableAdapter1
            // 
            this.sucursalTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelIdUsuario);
            this.groupBox1.Controls.Add(this.labelIdProveedor);
            this.groupBox1.Controls.Add(this.labelIdSucursal);
            this.groupBox1.Controls.Add(this.btnSiguienteIngreso);
            this.groupBox1.Controls.Add(this.btnAnteriorIngreso);
            this.groupBox1.Controls.Add(this.btnContinuar);
            this.groupBox1.Controls.Add(this.txtIdIngreso);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.comboBoxUsuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.comboBoxProveedor);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(46, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 292);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Productos";
            // 
            // labelIdUsuario
            // 
            this.labelIdUsuario.AutoSize = true;
            this.labelIdUsuario.Location = new System.Drawing.Point(493, 152);
            this.labelIdUsuario.Name = "labelIdUsuario";
            this.labelIdUsuario.Size = new System.Drawing.Size(0, 17);
            this.labelIdUsuario.TabIndex = 38;
            this.labelIdUsuario.Visible = false;
            // 
            // labelIdProveedor
            // 
            this.labelIdProveedor.AutoSize = true;
            this.labelIdProveedor.Location = new System.Drawing.Point(493, 193);
            this.labelIdProveedor.Name = "labelIdProveedor";
            this.labelIdProveedor.Size = new System.Drawing.Size(0, 17);
            this.labelIdProveedor.TabIndex = 37;
            this.labelIdProveedor.Visible = false;
            // 
            // labelIdSucursal
            // 
            this.labelIdSucursal.AutoSize = true;
            this.labelIdSucursal.Location = new System.Drawing.Point(493, 233);
            this.labelIdSucursal.Name = "labelIdSucursal";
            this.labelIdSucursal.Size = new System.Drawing.Size(0, 17);
            this.labelIdSucursal.TabIndex = 36;
            this.labelIdSucursal.Visible = false;
            // 
            // btnSiguienteIngreso
            // 
            this.btnSiguienteIngreso.Location = new System.Drawing.Point(396, 256);
            this.btnSiguienteIngreso.Name = "btnSiguienteIngreso";
            this.btnSiguienteIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteIngreso.TabIndex = 34;
            this.btnSiguienteIngreso.Text = ">";
            this.btnSiguienteIngreso.UseVisualStyleBackColor = true;
            this.btnSiguienteIngreso.Click += new System.EventHandler(this.btnSiguienteIngreso_Click);
            // 
            // btnAnteriorIngreso
            // 
            this.btnAnteriorIngreso.Location = new System.Drawing.Point(242, 256);
            this.btnAnteriorIngreso.Name = "btnAnteriorIngreso";
            this.btnAnteriorIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorIngreso.TabIndex = 35;
            this.btnAnteriorIngreso.Text = "<";
            this.btnAnteriorIngreso.UseVisualStyleBackColor = true;
            this.btnAnteriorIngreso.Click += new System.EventHandler(this.btnAnteriorIngreso_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(654, 248);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(124, 31);
            this.btnContinuar.TabIndex = 34;
            this.btnContinuar.Text = "continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // groupBoxDetalle
            // 
            this.groupBoxDetalle.Controls.Add(this.btnEliminarDetalle);
            this.groupBoxDetalle.Controls.Add(this.btnGuardarDetalle);
            this.groupBoxDetalle.Controls.Add(this.btnVolver);
            this.groupBoxDetalle.Controls.Add(this.txtValorTotal);
            this.groupBoxDetalle.Controls.Add(this.label3);
            this.groupBoxDetalle.Controls.Add(this.btnCalcular);
            this.groupBoxDetalle.Controls.Add(this.label5);
            this.groupBoxDetalle.Controls.Add(this.btnSiguienteDetalle);
            this.groupBoxDetalle.Controls.Add(this.label4);
            this.groupBoxDetalle.Controls.Add(this.btnAnteriorDetalle);
            this.groupBoxDetalle.Controls.Add(this.label2);
            this.groupBoxDetalle.Controls.Add(this.comboBoxCodigoProducto);
            this.groupBoxDetalle.Controls.Add(this.txtCantidad);
            this.groupBoxDetalle.Controls.Add(this.txtIdDetalleIngreso);
            this.groupBoxDetalle.Location = new System.Drawing.Point(46, 351);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Size = new System.Drawing.Size(766, 234);
            this.groupBoxDetalle.TabIndex = 35;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "Detalle";
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Location = new System.Drawing.Point(521, 54);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(92, 38);
            this.btnEliminarDetalle.TabIndex = 36;
            this.btnEliminarDetalle.Text = "eliminar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnGuardarDetalle
            // 
            this.btnGuardarDetalle.Location = new System.Drawing.Point(619, 54);
            this.btnGuardarDetalle.Name = "btnGuardarDetalle";
            this.btnGuardarDetalle.Size = new System.Drawing.Size(90, 38);
            this.btnGuardarDetalle.TabIndex = 34;
            this.btnGuardarDetalle.Text = "guardar";
            this.btnGuardarDetalle.UseVisualStyleBackColor = true;
            this.btnGuardarDetalle.Click += new System.EventHandler(this.btnGuardarDetalle_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(654, 194);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 23);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // PantallaIngresoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 608);
            this.Controls.Add(this.groupBoxDetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaIngresoProducto";
            this.Text = "PantallaIngresoProducto";
            this.Load += new System.EventHandler(this.PantallaIngresoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDetalle.ResumeLayout(false);
            this.groupBoxDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdIngreso;
        private System.Windows.Forms.TextBox txtIdDetalleIngreso;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAnteriorDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSiguienteDetalle;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private ControlExistenciasDataSet1 controlExistenciasDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ControlExistenciasDataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private ControlExistenciasDataSet2 controlExistenciasDataSet2;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private ControlExistenciasDataSet2TableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private ControlExistenciasDataSet3 controlExistenciasDataSet3;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private ControlExistenciasDataSet3TableAdapters.sucursalTableAdapter sucursalTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCodigoProducto;
        private ControlExistenciasDataSet4 controlExistenciasDataSet4;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private ControlExistenciasDataSet4TableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private ControlExistenciasDataSet5 controlExistenciasDataSet5;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private ControlExistenciasDataSet5TableAdapters.usuarioTableAdapter usuarioTableAdapter1;
        private ControlExistenciasDataSet6 controlExistenciasDataSet6;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private ControlExistenciasDataSet6TableAdapters.proveedorTableAdapter proveedorTableAdapter1;
        private ControlExistenciasDataSet7 controlExistenciasDataSet7;
        private System.Windows.Forms.BindingSource sucursalBindingSource1;
        private ControlExistenciasDataSet7TableAdapters.sucursalTableAdapter sucursalTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox groupBoxDetalle;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSiguienteIngreso;
        private System.Windows.Forms.Button btnAnteriorIngreso;
        private System.Windows.Forms.Label labelIdProveedor;
        private System.Windows.Forms.Label labelIdSucursal;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnGuardarDetalle;
        private System.Windows.Forms.Label labelIdUsuario;
    }
}