
namespace CapaGUI
{
    partial class PantallaListadoIngresoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListadoIngreso = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtIdIngreso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Ingreso";
            // 
            // dataGridViewListadoIngreso
            // 
            this.dataGridViewListadoIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoIngreso.Location = new System.Drawing.Point(38, 190);
            this.dataGridViewListadoIngreso.Name = "dataGridViewListadoIngreso";
            this.dataGridViewListadoIngreso.RowHeadersWidth = 51;
            this.dataGridViewListadoIngreso.RowTemplate.Height = 24;
            this.dataGridViewListadoIngreso.Size = new System.Drawing.Size(863, 275);
            this.dataGridViewListadoIngreso.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(494, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(627, 123);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(150, 23);
            this.btnMostrarTodo.TabIndex = 3;
            this.btnMostrarTodo.Text = "mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(749, 534);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtIdIngreso
            // 
            this.txtIdIngreso.Location = new System.Drawing.Point(347, 124);
            this.txtIdIngreso.Name = "txtIdIngreso";
            this.txtIdIngreso.Size = new System.Drawing.Size(141, 22);
            this.txtIdIngreso.TabIndex = 5;
            // 
            // PantallaListadoIngresoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 608);
            this.Controls.Add(this.txtIdIngreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridViewListadoIngreso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaListadoIngresoProducto";
            this.Text = "PantallaListadoIngresoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListadoIngreso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdIngreso;
    }
}