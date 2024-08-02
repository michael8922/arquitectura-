
namespace CapaGUI
{
    partial class PantallaMantenedorUsuario
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.txtBuscarRut = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewListadoUsuario = new System.Windows.Forms.DataGridView();
            this.groupBoxListadoUsuarios = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.controlExistenciasDataSet = new CapaGUI.ControlExistenciasDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new CapaGUI.ControlExistenciasDataSetTableAdapters.usuarioTableAdapter();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoUsuario)).BeginInit();
            this.groupBoxListadoUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(649, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(618, 109);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 42);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(618, 172);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 41);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(173, 292);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(618, 231);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 39);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(384, 292);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(384, 41);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(109, 23);
            this.btnBuscarUsuario.TabIndex = 7;
            this.btnBuscarUsuario.Text = "buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(499, 41);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(138, 23);
            this.btnMostrarTodo.TabIndex = 8;
            this.btnMostrarTodo.Text = "mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // txtBuscarRut
            // 
            this.txtBuscarRut.Location = new System.Drawing.Point(188, 42);
            this.txtBuscarRut.Name = "txtBuscarRut";
            this.txtBuscarRut.Size = new System.Drawing.Size(176, 22);
            this.txtBuscarRut.TabIndex = 10;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(173, 109);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(286, 22);
            this.txtRut.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // dataGridViewListadoUsuario
            // 
            this.dataGridViewListadoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoUsuario.Location = new System.Drawing.Point(127, 82);
            this.dataGridViewListadoUsuario.Name = "dataGridViewListadoUsuario";
            this.dataGridViewListadoUsuario.RowHeadersWidth = 51;
            this.dataGridViewListadoUsuario.RowTemplate.Height = 24;
            this.dataGridViewListadoUsuario.Size = new System.Drawing.Size(589, 148);
            this.dataGridViewListadoUsuario.TabIndex = 13;
            // 
            // groupBoxListadoUsuarios
            // 
            this.groupBoxListadoUsuarios.Controls.Add(this.label5);
            this.groupBoxListadoUsuarios.Controls.Add(this.txtBuscarRut);
            this.groupBoxListadoUsuarios.Controls.Add(this.btnBuscarUsuario);
            this.groupBoxListadoUsuarios.Controls.Add(this.btnMostrarTodo);
            this.groupBoxListadoUsuarios.Controls.Add(this.dataGridViewListadoUsuario);
            this.groupBoxListadoUsuarios.Location = new System.Drawing.Point(46, 337);
            this.groupBoxListadoUsuarios.Name = "groupBoxListadoUsuarios";
            this.groupBoxListadoUsuarios.Size = new System.Drawing.Size(840, 245);
            this.groupBoxListadoUsuarios.TabIndex = 14;
            this.groupBoxListadoUsuarios.TabStop = false;
            this.groupBoxListadoUsuarios.Text = "Buscar Usuarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ingresar Rut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(173, 192);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(286, 22);
            this.txtClave.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cargo";
            // 
            // controlExistenciasDataSet
            // 
            this.controlExistenciasDataSet.DataSetName = "ControlExistenciasDataSet";
            this.controlExistenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.controlExistenciasDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "administrador",
            "recepcionista",
            "vendedor"});
            this.comboBoxCargo.Location = new System.Drawing.Point(173, 231);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(286, 24);
            this.comboBoxCargo.TabIndex = 20;
            // 
            // PantallaMantenedorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 689);
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.groupBoxListadoUsuarios);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaMantenedorUsuario";
            this.Text = "PantallaMantenedorUsuario";
            this.Load += new System.EventHandler(this.PantallaMantenedorUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoUsuario)).EndInit();
            this.groupBoxListadoUsuarios.ResumeLayout(false);
            this.groupBoxListadoUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlExistenciasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.TextBox txtBuscarRut;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dataGridViewListadoUsuario;
        private System.Windows.Forms.GroupBox groupBoxListadoUsuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label4;
        private ControlExistenciasDataSet controlExistenciasDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ControlExistenciasDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCargo;
    }
}