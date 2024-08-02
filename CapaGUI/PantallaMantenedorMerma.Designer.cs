
namespace CapaGUI
{
    partial class PantallaMantenedorMerma
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
            this.txtIdMerma = new System.Windows.Forms.TextBox();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet19 = new CapaGUI.ControlExistenciasDataSet19();
            this.comboBoxRutUsuario = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet14 = new CapaGUI.ControlExistenciasDataSet14();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.btnSiguienteMerma = new System.Windows.Forms.Button();
            this.btnAgregarMerma = new System.Windows.Forms.Button();
            this.btnModificarMerma = new System.Windows.Forms.Button();
            this.btnEliminarMerma = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnAnteriorMerma = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoSolicitud = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet15 = new CapaGUI.ControlExistenciasDataSet15();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAnteriorDetalle = new System.Windows.Forms.Button();
            this.btnSiguienteDetalle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.usuarioTableAdapter = new CapaGUI.ControlExistenciasDataSet14TableAdapters.usuarioTableAdapter();
            this.productoTableAdapter = new CapaGUI.ControlExistenciasDataSet15TableAdapters.productoTableAdapter();
            this.sucursalTableAdapter = new CapaGUI.ControlExistenciasDataSet19TableAdapters.sucursalTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet14)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdMerma
            // 
            this.txtIdMerma.Location = new System.Drawing.Point(244, 52);
            this.txtIdMerma.Name = "txtIdMerma";
            this.txtIdMerma.Size = new System.Drawing.Size(241, 22);
            this.txtIdMerma.TabIndex = 0;
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Location = new System.Drawing.Point(180, 68);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(279, 22);
            this.txtIdDetalle.TabIndex = 1;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(180, 155);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(181, 22);
            this.txtValorTotal.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(180, 124);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(279, 22);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(244, 111);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(241, 22);
            this.txtMotivo.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRutUsuario);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.btnSiguienteMerma);
            this.groupBox1.Controls.Add(this.btnAgregarMerma);
            this.groupBox1.Controls.Add(this.btnModificarMerma);
            this.groupBox1.Controls.Add(this.btnEliminarMerma);
            this.groupBox1.Controls.Add(this.btnContinuar);
            this.groupBox1.Controls.Add(this.btnAnteriorMerma);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdMerma);
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Controls.Add(this.txtTipoSolicitud);
            this.groupBox1.Location = new System.Drawing.Point(81, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 257);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Mermas";
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataMember = "sucursal";
            this.sucursalBindingSource.DataSource = this.controlExistenciasDataSet19;
            // 
            // controlExistenciasDataSet19
            // 
            this.controlExistenciasDataSet19.DataSetName = "ControlExistenciasDataSet19";
            this.controlExistenciasDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxRutUsuario
            // 
            this.comboBoxRutUsuario.DataSource = this.usuarioBindingSource;
            this.comboBoxRutUsuario.DisplayMember = "rut";
            this.comboBoxRutUsuario.FormattingEnabled = true;
            this.comboBoxRutUsuario.Location = new System.Drawing.Point(244, 142);
            this.comboBoxRutUsuario.Name = "comboBoxRutUsuario";
            this.comboBoxRutUsuario.Size = new System.Drawing.Size(241, 24);
            this.comboBoxRutUsuario.TabIndex = 22;
            this.comboBoxRutUsuario.ValueMember = "rut";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.controlExistenciasDataSet14;
            // 
            // controlExistenciasDataSet14
            // 
            this.controlExistenciasDataSet14.DataSetName = "ControlExistenciasDataSet14";
            this.controlExistenciasDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(609, 21);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(127, 22);
            this.dateTimePickerFecha.TabIndex = 21;
            // 
            // btnSiguienteMerma
            // 
            this.btnSiguienteMerma.Location = new System.Drawing.Point(410, 213);
            this.btnSiguienteMerma.Name = "btnSiguienteMerma";
            this.btnSiguienteMerma.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteMerma.TabIndex = 20;
            this.btnSiguienteMerma.Text = ">";
            this.btnSiguienteMerma.UseVisualStyleBackColor = true;
            this.btnSiguienteMerma.Click += new System.EventHandler(this.btnSiguienteMerma_Click);
            // 
            // btnAgregarMerma
            // 
            this.btnAgregarMerma.Location = new System.Drawing.Point(553, 59);
            this.btnAgregarMerma.Name = "btnAgregarMerma";
            this.btnAgregarMerma.Size = new System.Drawing.Size(75, 39);
            this.btnAgregarMerma.TabIndex = 19;
            this.btnAgregarMerma.Text = "guardar";
            this.btnAgregarMerma.UseVisualStyleBackColor = true;
            this.btnAgregarMerma.Click += new System.EventHandler(this.btnAgregarMerma_Click);
            // 
            // btnModificarMerma
            // 
            this.btnModificarMerma.Location = new System.Drawing.Point(553, 104);
            this.btnModificarMerma.Name = "btnModificarMerma";
            this.btnModificarMerma.Size = new System.Drawing.Size(75, 41);
            this.btnModificarMerma.TabIndex = 18;
            this.btnModificarMerma.Text = "modificar";
            this.btnModificarMerma.UseVisualStyleBackColor = true;
            this.btnModificarMerma.Click += new System.EventHandler(this.btnModificarMerma_Click);
            // 
            // btnEliminarMerma
            // 
            this.btnEliminarMerma.Location = new System.Drawing.Point(553, 151);
            this.btnEliminarMerma.Name = "btnEliminarMerma";
            this.btnEliminarMerma.Size = new System.Drawing.Size(75, 37);
            this.btnEliminarMerma.TabIndex = 17;
            this.btnEliminarMerma.Text = "eliminar";
            this.btnEliminarMerma.UseVisualStyleBackColor = true;
            this.btnEliminarMerma.Click += new System.EventHandler(this.btnEliminarMerma_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(553, 194);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 42);
            this.btnContinuar.TabIndex = 16;
            this.btnContinuar.Text = "continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnAnteriorMerma
            // 
            this.btnAnteriorMerma.Location = new System.Drawing.Point(244, 213);
            this.btnAnteriorMerma.Name = "btnAnteriorMerma";
            this.btnAnteriorMerma.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorMerma.TabIndex = 15;
            this.btnAnteriorMerma.Text = "<";
            this.btnAnteriorMerma.UseVisualStyleBackColor = true;
            this.btnAnteriorMerma.Click += new System.EventHandler(this.btnAnteriorMerma_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "rut solicitante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "tipo solicitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "motivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "id merma";
            // 
            // txtTipoSolicitud
            // 
            this.txtTipoSolicitud.Location = new System.Drawing.Point(244, 81);
            this.txtTipoSolicitud.Name = "txtTipoSolicitud";
            this.txtTipoSolicitud.Size = new System.Drawing.Size(241, 22);
            this.txtTipoSolicitud.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxCodigoProducto);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.btnEliminarDetalle);
            this.groupBox2.Controls.Add(this.btnAgregarDetalle);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.btnAnteriorDetalle);
            this.groupBox2.Controls.Add(this.btnSiguienteDetalle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIdDetalle);
            this.groupBox2.Controls.Add(this.txtValorTotal);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Location = new System.Drawing.Point(81, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 240);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // comboBoxCodigoProducto
            // 
            this.comboBoxCodigoProducto.DataSource = this.productoBindingSource;
            this.comboBoxCodigoProducto.DisplayMember = "codigo";
            this.comboBoxCodigoProducto.FormattingEnabled = true;
            this.comboBoxCodigoProducto.Location = new System.Drawing.Point(180, 96);
            this.comboBoxCodigoProducto.Name = "comboBoxCodigoProducto";
            this.comboBoxCodigoProducto.Size = new System.Drawing.Size(279, 24);
            this.comboBoxCodigoProducto.TabIndex = 26;
            this.comboBoxCodigoProducto.ValueMember = "codigo";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.controlExistenciasDataSet15;
            // 
            // controlExistenciasDataSet15
            // 
            this.controlExistenciasDataSet15.DataSetName = "ControlExistenciasDataSet15";
            this.controlExistenciasDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(367, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 23);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Location = new System.Drawing.Point(495, 45);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(75, 33);
            this.btnEliminarDetalle.TabIndex = 24;
            this.btnEliminarDetalle.Text = "eliminar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(586, 45);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarDetalle.TabIndex = 23;
            this.btnAgregarDetalle.Text = "guardar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(586, 206);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAnteriorDetalle
            // 
            this.btnAnteriorDetalle.Location = new System.Drawing.Point(180, 185);
            this.btnAnteriorDetalle.Name = "btnAnteriorDetalle";
            this.btnAnteriorDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorDetalle.TabIndex = 21;
            this.btnAnteriorDetalle.Text = "<";
            this.btnAnteriorDetalle.UseVisualStyleBackColor = true;
            this.btnAnteriorDetalle.Click += new System.EventHandler(this.btnAnteriorDetalle_Click);
            // 
            // btnSiguienteDetalle
            // 
            this.btnSiguienteDetalle.Location = new System.Drawing.Point(286, 185);
            this.btnSiguienteDetalle.Name = "btnSiguienteDetalle";
            this.btnSiguienteDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteDetalle.TabIndex = 20;
            this.btnSiguienteDetalle.Text = ">";
            this.btnSiguienteDetalle.UseVisualStyleBackColor = true;
            this.btnSiguienteDetalle.Click += new System.EventHandler(this.btnSiguienteDetalle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "id detalle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "codigo producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "valor total";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(832, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // sucursalTableAdapter
            // 
            this.sucursalTableAdapter.ClearBeforeFill = true;
            // 
            // PantallaMantenedorMerma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 608);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaMantenedorMerma";
            this.Text = "PantallaMantenedorMerma";
            this.Load += new System.EventHandler(this.PantallaMantenedorMerma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet14)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdMerma;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button btnSiguienteMerma;
        private System.Windows.Forms.Button btnAgregarMerma;
        private System.Windows.Forms.Button btnModificarMerma;
        private System.Windows.Forms.Button btnEliminarMerma;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnAnteriorMerma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxCodigoProducto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAnteriorDetalle;
        private System.Windows.Forms.Button btnSiguienteDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTipoSolicitud;
        private System.Windows.Forms.ComboBox comboBoxRutUsuario;
        private ControlExistenciasDataSet14 controlExistenciasDataSet14;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ControlExistenciasDataSet14TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private ControlExistenciasDataSet15 controlExistenciasDataSet15;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private ControlExistenciasDataSet15TableAdapters.productoTableAdapter productoTableAdapter;
        private ControlExistenciasDataSet19 controlExistenciasDataSet19;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private ControlExistenciasDataSet19TableAdapters.sucursalTableAdapter sucursalTableAdapter;
    }
}