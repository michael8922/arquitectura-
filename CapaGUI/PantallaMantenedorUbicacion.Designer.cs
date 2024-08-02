
namespace CapaGUI
{
    partial class PantallaMantenedorUbicacion
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
            this.txtIdUbicacion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombreUbicacion = new System.Windows.Forms.TextBox();
            this.comboBoxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet16 = new CapaGUI.ControlExistenciasDataSet16();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListadoUbicacion = new System.Windows.Forms.DataGridView();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.productoTableAdapter = new CapaGUI.ControlExistenciasDataSet16TableAdapters.productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet16)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoUbicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdUbicacion
            // 
            this.txtIdUbicacion.Location = new System.Drawing.Point(203, 60);
            this.txtIdUbicacion.Name = "txtIdUbicacion";
            this.txtIdUbicacion.Size = new System.Drawing.Size(262, 22);
            this.txtIdUbicacion.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(203, 146);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(262, 22);
            this.txtCantidad.TabIndex = 1;
            // 
            // txtNombreUbicacion
            // 
            this.txtNombreUbicacion.Location = new System.Drawing.Point(203, 88);
            this.txtNombreUbicacion.Name = "txtNombreUbicacion";
            this.txtNombreUbicacion.Size = new System.Drawing.Size(262, 22);
            this.txtNombreUbicacion.TabIndex = 3;
            // 
            // comboBoxCodigoProducto
            // 
            this.comboBoxCodigoProducto.DataSource = this.productoBindingSource;
            this.comboBoxCodigoProducto.DisplayMember = "codigo";
            this.comboBoxCodigoProducto.FormattingEnabled = true;
            this.comboBoxCodigoProducto.Location = new System.Drawing.Point(203, 116);
            this.comboBoxCodigoProducto.Name = "comboBoxCodigoProducto";
            this.comboBoxCodigoProducto.Size = new System.Drawing.Size(262, 24);
            this.comboBoxCodigoProducto.TabIndex = 4;
            this.comboBoxCodigoProducto.ValueMember = "codigo";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.controlExistenciasDataSet16;
            // 
            // controlExistenciasDataSet16
            // 
            this.controlExistenciasDataSet16.DataSetName = "ControlExistenciasDataSet16";
            this.controlExistenciasDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(826, 488);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(709, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 44);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(628, 163);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 44);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(540, 163);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 44);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(390, 174);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(203, 174);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(590, 21);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(118, 22);
            this.dateTimePickerFecha.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.txtIdUbicacion);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtNombreUbicacion);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.comboBoxCodigoProducto);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(47, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 221);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de ubicaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nombre Ubicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Codigo Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "IdUbicacion";
            // 
            // dataGridViewListadoUbicacion
            // 
            this.dataGridViewListadoUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoUbicacion.Location = new System.Drawing.Point(67, 324);
            this.dataGridViewListadoUbicacion.Name = "dataGridViewListadoUbicacion";
            this.dataGridViewListadoUbicacion.RowHeadersWidth = 51;
            this.dataGridViewListadoUbicacion.RowTemplate.Height = 24;
            this.dataGridViewListadoUbicacion.Size = new System.Drawing.Size(736, 187);
            this.dataGridViewListadoUbicacion.TabIndex = 13;
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(250, 279);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(237, 22);
            this.txtBuscarCodigo.TabIndex = 14;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(637, 279);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(118, 23);
            this.btnMostrarTodo.TabIndex = 17;
            this.btnMostrarTodo.Text = "mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(503, 279);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "codigo producto";
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // PantallaMantenedorUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 689);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarCodigo);
            this.Controls.Add(this.dataGridViewListadoUbicacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaMantenedorUbicacion";
            this.Text = "PantallaMantenedorUbicacion";
            this.Load += new System.EventHandler(this.PantallaMantenedorUbicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet16)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoUbicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdUbicacion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombreUbicacion;
        private System.Windows.Forms.ComboBox comboBoxCodigoProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListadoUbicacion;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private ControlExistenciasDataSet16 controlExistenciasDataSet16;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private ControlExistenciasDataSet16TableAdapters.productoTableAdapter productoTableAdapter;
    }
}