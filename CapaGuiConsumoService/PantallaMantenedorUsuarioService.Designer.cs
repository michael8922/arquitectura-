
namespace CapaGuiConsumoService
{
    partial class PantallaMantenedorUsuarioService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBoxListadoUsuarios = new System.Windows.Forms.GroupBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarRut = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.dataGridViewListadoUsuario = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBoxListadoUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.comboBoxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "administrador",
            "recepcionista",
            "vendedor"});
            this.comboBoxCargo.Location = new System.Drawing.Point(179, 199);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(286, 28);
            this.comboBoxCargo.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(65, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cargo";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(179, 155);
            this.txtClave.MaxLength = 100;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(286, 27);
            this.txtClave.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(65, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(65, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(65, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Rut";
            // 
            // txtRut
            // 
            this.txtRut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(179, 68);
            this.txtRut.MaxLength = 15;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(286, 27);
            this.txtRut.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(179, 109);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 27);
            this.txtNombre.TabIndex = 28;
            // 
            // groupBoxListadoUsuarios
            // 
            this.groupBoxListadoUsuarios.Controls.Add(this.txtClave);
            this.groupBoxListadoUsuarios.Controls.Add(this.btnAnterior);
            this.groupBoxListadoUsuarios.Controls.Add(this.comboBoxCargo);
            this.groupBoxListadoUsuarios.Controls.Add(this.btnSiguiente);
            this.groupBoxListadoUsuarios.Controls.Add(this.txtNombre);
            this.groupBoxListadoUsuarios.Controls.Add(this.label4);
            this.groupBoxListadoUsuarios.Controls.Add(this.btnModificar);
            this.groupBoxListadoUsuarios.Controls.Add(this.btnEliminar);
            this.groupBoxListadoUsuarios.Controls.Add(this.btnAgregar);
            this.groupBoxListadoUsuarios.Controls.Add(this.txtRut);
            this.groupBoxListadoUsuarios.Controls.Add(this.label1);
            this.groupBoxListadoUsuarios.Controls.Add(this.label2);
            this.groupBoxListadoUsuarios.Controls.Add(this.label3);
            this.groupBoxListadoUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListadoUsuarios.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxListadoUsuarios.Location = new System.Drawing.Point(80, 29);
            this.groupBoxListadoUsuarios.Name = "groupBoxListadoUsuarios";
            this.groupBoxListadoUsuarios.Size = new System.Drawing.Size(795, 343);
            this.groupBoxListadoUsuarios.TabIndex = 29;
            this.groupBoxListadoUsuarios.TabStop = false;
            this.groupBoxListadoUsuarios.Text = "   Ingreso Usuarios   ";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAnterior.Location = new System.Drawing.Point(179, 247);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 39);
            this.btnAnterior.TabIndex = 24;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSiguiente.Location = new System.Drawing.Point(390, 247);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 39);
            this.btnSiguiente.TabIndex = 26;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModificar.Location = new System.Drawing.Point(627, 192);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 41);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminar.Location = new System.Drawing.Point(627, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 39);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregar.Location = new System.Drawing.Point(627, 125);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 42);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(183, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ingresar Rut";
            // 
            // txtBuscarRut
            // 
            this.txtBuscarRut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBuscarRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRut.Location = new System.Drawing.Point(302, 411);
            this.txtBuscarRut.MaxLength = 100;
            this.txtBuscarRut.Name = "txtBuscarRut";
            this.txtBuscarRut.Size = new System.Drawing.Size(176, 27);
            this.txtBuscarRut.TabIndex = 10;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(498, 407);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(130, 32);
            this.btnBuscarUsuario.TabIndex = 7;
            this.btnBuscarUsuario.Text = "buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMostrarTodo.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMostrarTodo.Location = new System.Drawing.Point(654, 408);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(138, 31);
            this.btnMostrarTodo.TabIndex = 8;
            this.btnMostrarTodo.Text = "mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = false;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // dataGridViewListadoUsuario
            // 
            this.dataGridViewListadoUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridViewListadoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridViewListadoUsuario.Location = new System.Drawing.Point(166, 468);
            this.dataGridViewListadoUsuario.Name = "dataGridViewListadoUsuario";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListadoUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListadoUsuario.RowHeadersWidth = 51;
            this.dataGridViewListadoUsuario.RowTemplate.Height = 24;
            this.dataGridViewListadoUsuario.Size = new System.Drawing.Size(647, 169);
            this.dataGridViewListadoUsuario.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalir.Location = new System.Drawing.Point(0, 680);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(981, 48);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PantallaMantenedorUsuarioService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(981, 728);
            this.Controls.Add(this.dataGridViewListadoUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscarRut);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.groupBoxListadoUsuarios);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaMantenedorUsuarioService";
            this.Text = "PantallaMantenedorUsuarioService";
            this.Load += new System.EventHandler(this.PantallaMantenedorUsuarioService_Load);
            this.groupBoxListadoUsuarios.ResumeLayout(false);
            this.groupBoxListadoUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBoxListadoUsuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarRut;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.DataGridView dataGridViewListadoUsuario;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
    }
}