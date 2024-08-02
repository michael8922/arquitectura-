
namespace CapaGuiConsumoService
{
    partial class PantallaMantenedorMermaService
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSiguienteDetalle = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnAnteriorDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBoxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet7 = new CapaGuiConsumoService.ControlExistenciasDataSet7();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSiguienteMerma = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAnteriorMerma = new System.Windows.Forms.Button();
            this.btnAgregarMerma = new System.Windows.Forms.Button();
            this.btnModificarMerma = new System.Windows.Forms.Button();
            this.btnEliminarMerma = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxRutUsuario = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlExistenciasDataSet6 = new CapaGuiConsumoService.ControlExistenciasDataSet6();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMerma = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtTipoSolicitud = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.usuarioTableAdapter = new CapaGuiConsumoService.ControlExistenciasDataSet6TableAdapters.usuarioTableAdapter();
            this.productoTableAdapter = new CapaGuiConsumoService.ControlExistenciasDataSet7TableAdapters.productoTableAdapter();
            this.groupBox2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalir.Location = new System.Drawing.Point(0, 661);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(981, 67);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.comboBoxCodigoProducto);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIdDetalle);
            this.groupBox2.Controls.Add(this.txtValorTotal);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(54, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 254);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(603, 23);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(152, 228);
            this.panel7.TabIndex = 27;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.btnAgregarDetalle);
            this.panel10.Controls.Add(this.btnEliminarDetalle);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 36);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(152, 150);
            this.panel10.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnSiguienteDetalle);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(78, 100);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(74, 50);
            this.panel12.TabIndex = 26;
            // 
            // btnSiguienteDetalle
            // 
            this.btnSiguienteDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSiguienteDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiguienteDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteDetalle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSiguienteDetalle.Location = new System.Drawing.Point(0, 0);
            this.btnSiguienteDetalle.Name = "btnSiguienteDetalle";
            this.btnSiguienteDetalle.Size = new System.Drawing.Size(74, 50);
            this.btnSiguienteDetalle.TabIndex = 20;
            this.btnSiguienteDetalle.Text = ">";
            this.btnSiguienteDetalle.UseVisualStyleBackColor = false;
            this.btnSiguienteDetalle.Click += new System.EventHandler(this.btnSiguienteDetalle_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnAnteriorDetalle);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 100);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(78, 50);
            this.panel11.TabIndex = 25;
            // 
            // btnAnteriorDetalle
            // 
            this.btnAnteriorDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAnteriorDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnteriorDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorDetalle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAnteriorDetalle.Location = new System.Drawing.Point(0, 0);
            this.btnAnteriorDetalle.Name = "btnAnteriorDetalle";
            this.btnAnteriorDetalle.Size = new System.Drawing.Size(78, 50);
            this.btnAnteriorDetalle.TabIndex = 21;
            this.btnAnteriorDetalle.Text = "<";
            this.btnAnteriorDetalle.UseVisualStyleBackColor = false;
            this.btnAnteriorDetalle.Click += new System.EventHandler(this.btnAnteriorDetalle_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAgregarDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(0, 50);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(152, 50);
            this.btnAgregarDetalle.TabIndex = 23;
            this.btnAgregarDetalle.Text = "guardar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnEliminarDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarDetalle.FlatAppearance.BorderSize = 0;
            this.btnEliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetalle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(0, 0);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(152, 50);
            this.btnEliminarDetalle.TabIndex = 24;
            this.btnEliminarDetalle.Text = "eliminar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = false;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 186);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(152, 42);
            this.panel9.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(152, 36);
            this.panel8.TabIndex = 0;
            // 
            // comboBoxCodigoProducto
            // 
            this.comboBoxCodigoProducto.DataSource = this.productoBindingSource;
            this.comboBoxCodigoProducto.DisplayMember = "codigo";
            this.comboBoxCodigoProducto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxCodigoProducto.FormattingEnabled = true;
            this.comboBoxCodigoProducto.Location = new System.Drawing.Point(244, 116);
            this.comboBoxCodigoProducto.Name = "comboBoxCodigoProducto";
            this.comboBoxCodigoProducto.Size = new System.Drawing.Size(279, 28);
            this.comboBoxCodigoProducto.TabIndex = 26;
            this.comboBoxCodigoProducto.ValueMember = "codigo";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.controlExistenciasDataSet7;
            // 
            // controlExistenciasDataSet7
            // 
            this.controlExistenciasDataSet7.DataSetName = "ControlExistenciasDataSet7";
            this.controlExistenciasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalcular.Location = new System.Drawing.Point(431, 192);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 36);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "id detalle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "codigo producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "valor total";
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIdDetalle.Location = new System.Drawing.Point(244, 79);
            this.txtIdDetalle.MaxLength = 100;
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(279, 27);
            this.txtIdDetalle.TabIndex = 1;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtValorTotal.Location = new System.Drawing.Point(244, 192);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(181, 27);
            this.txtValorTotal.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCantidad.Location = new System.Drawing.Point(244, 154);
            this.txtCantidad.MaxLength = 9;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(279, 27);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolver.Location = new System.Drawing.Point(844, 366);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 97);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.comboBoxRutUsuario);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdMerma);
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Controls.Add(this.txtTipoSolicitud);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(54, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 263);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Mermas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(603, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 237);
            this.panel1.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnAgregarMerma);
            this.panel4.Controls.Add(this.btnModificarMerma);
            this.panel4.Controls.Add(this.btnEliminarMerma);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 188);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSiguienteMerma);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(78, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(77, 38);
            this.panel6.TabIndex = 21;
            // 
            // btnSiguienteMerma
            // 
            this.btnSiguienteMerma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSiguienteMerma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiguienteMerma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteMerma.Location = new System.Drawing.Point(0, 0);
            this.btnSiguienteMerma.Name = "btnSiguienteMerma";
            this.btnSiguienteMerma.Size = new System.Drawing.Size(77, 38);
            this.btnSiguienteMerma.TabIndex = 20;
            this.btnSiguienteMerma.Text = ">";
            this.btnSiguienteMerma.UseVisualStyleBackColor = false;
            this.btnSiguienteMerma.Click += new System.EventHandler(this.btnSiguienteMerma_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAnteriorMerma);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(78, 38);
            this.panel5.TabIndex = 20;
            // 
            // btnAnteriorMerma
            // 
            this.btnAnteriorMerma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAnteriorMerma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnteriorMerma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorMerma.Location = new System.Drawing.Point(0, 0);
            this.btnAnteriorMerma.Name = "btnAnteriorMerma";
            this.btnAnteriorMerma.Size = new System.Drawing.Size(78, 38);
            this.btnAnteriorMerma.TabIndex = 15;
            this.btnAnteriorMerma.Text = "<";
            this.btnAnteriorMerma.UseVisualStyleBackColor = false;
            this.btnAnteriorMerma.Click += new System.EventHandler(this.btnAnteriorMerma_Click);
            // 
            // btnAgregarMerma
            // 
            this.btnAgregarMerma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAgregarMerma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarMerma.FlatAppearance.BorderSize = 0;
            this.btnAgregarMerma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMerma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMerma.Location = new System.Drawing.Point(0, 100);
            this.btnAgregarMerma.Name = "btnAgregarMerma";
            this.btnAgregarMerma.Size = new System.Drawing.Size(152, 50);
            this.btnAgregarMerma.TabIndex = 19;
            this.btnAgregarMerma.Text = "guardar";
            this.btnAgregarMerma.UseVisualStyleBackColor = false;
            this.btnAgregarMerma.Click += new System.EventHandler(this.btnAgregarMerma_Click);
            // 
            // btnModificarMerma
            // 
            this.btnModificarMerma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnModificarMerma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarMerma.FlatAppearance.BorderSize = 0;
            this.btnModificarMerma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMerma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMerma.Location = new System.Drawing.Point(0, 50);
            this.btnModificarMerma.Name = "btnModificarMerma";
            this.btnModificarMerma.Size = new System.Drawing.Size(152, 50);
            this.btnModificarMerma.TabIndex = 18;
            this.btnModificarMerma.Text = "modificar";
            this.btnModificarMerma.UseVisualStyleBackColor = false;
            this.btnModificarMerma.Click += new System.EventHandler(this.btnModificarMerma_Click);
            // 
            // btnEliminarMerma
            // 
            this.btnEliminarMerma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnEliminarMerma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarMerma.FlatAppearance.BorderSize = 0;
            this.btnEliminarMerma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMerma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMerma.Location = new System.Drawing.Point(0, 0);
            this.btnEliminarMerma.Name = "btnEliminarMerma";
            this.btnEliminarMerma.Size = new System.Drawing.Size(152, 50);
            this.btnEliminarMerma.TabIndex = 17;
            this.btnEliminarMerma.Text = "eliminar";
            this.btnEliminarMerma.UseVisualStyleBackColor = false;
            this.btnEliminarMerma.Click += new System.EventHandler(this.btnEliminarMerma_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 22);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 27);
            this.panel2.TabIndex = 0;
            // 
            // comboBoxRutUsuario
            // 
            this.comboBoxRutUsuario.DataSource = this.usuarioBindingSource;
            this.comboBoxRutUsuario.DisplayMember = "rut";
            this.comboBoxRutUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxRutUsuario.FormattingEnabled = true;
            this.comboBoxRutUsuario.Location = new System.Drawing.Point(244, 162);
            this.comboBoxRutUsuario.Name = "comboBoxRutUsuario";
            this.comboBoxRutUsuario.Size = new System.Drawing.Size(279, 28);
            this.comboBoxRutUsuario.TabIndex = 22;
            this.comboBoxRutUsuario.ValueMember = "rut";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.controlExistenciasDataSet6;
            // 
            // controlExistenciasDataSet6
            // 
            this.controlExistenciasDataSet6.DataSetName = "ControlExistenciasDataSet6";
            this.controlExistenciasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(244, 204);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(279, 27);
            this.dateTimePickerFecha.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "rut solicitante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "tipo solicitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "motivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "id merma";
            // 
            // txtIdMerma
            // 
            this.txtIdMerma.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIdMerma.Location = new System.Drawing.Point(244, 42);
            this.txtIdMerma.MaxLength = 100;
            this.txtIdMerma.Name = "txtIdMerma";
            this.txtIdMerma.Size = new System.Drawing.Size(279, 27);
            this.txtIdMerma.TabIndex = 0;
            // 
            // txtMotivo
            // 
            this.txtMotivo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMotivo.Location = new System.Drawing.Point(244, 123);
            this.txtMotivo.MaxLength = 200;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(279, 27);
            this.txtMotivo.TabIndex = 6;
            // 
            // txtTipoSolicitud
            // 
            this.txtTipoSolicitud.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTipoSolicitud.Location = new System.Drawing.Point(244, 81);
            this.txtTipoSolicitud.MaxLength = 100;
            this.txtTipoSolicitud.Name = "txtTipoSolicitud";
            this.txtTipoSolicitud.Size = new System.Drawing.Size(279, 27);
            this.txtTipoSolicitud.TabIndex = 7;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnContinuar.Location = new System.Drawing.Point(844, 157);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(107, 107);
            this.btnContinuar.TabIndex = 16;
            this.btnContinuar.Text = "continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // PantallaMantenedorMermaService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(981, 728);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnVolver);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaMantenedorMermaService";
            this.Text = "PantallaMantenedorMermaService";
            this.Load += new System.EventHandler(this.PantallaMantenedorMermaService_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
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
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRutUsuario;
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
        private System.Windows.Forms.TextBox txtIdMerma;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtTipoSolicitud;
        private ControlExistenciasDataSet6 controlExistenciasDataSet6;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ControlExistenciasDataSet6TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private ControlExistenciasDataSet7 controlExistenciasDataSet7;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private ControlExistenciasDataSet7TableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
    }
}