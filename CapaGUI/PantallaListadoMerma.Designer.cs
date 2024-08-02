
namespace CapaGUI
{
    partial class PantallaListadoMerma
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
            this.txtIdMerma = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.dataGridViewListadoMerma = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoMerma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Merma";
            // 
            // txtIdMerma
            // 
            this.txtIdMerma.Location = new System.Drawing.Point(294, 63);
            this.txtIdMerma.Name = "txtIdMerma";
            this.txtIdMerma.Size = new System.Drawing.Size(183, 22);
            this.txtIdMerma.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(498, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(627, 66);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(119, 23);
            this.btnMostrarTodo.TabIndex = 3;
            this.btnMostrarTodo.Text = "mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // dataGridViewListadoMerma
            // 
            this.dataGridViewListadoMerma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoMerma.Location = new System.Drawing.Point(60, 158);
            this.dataGridViewListadoMerma.Name = "dataGridViewListadoMerma";
            this.dataGridViewListadoMerma.RowHeadersWidth = 51;
            this.dataGridViewListadoMerma.RowTemplate.Height = 24;
            this.dataGridViewListadoMerma.Size = new System.Drawing.Size(802, 302);
            this.dataGridViewListadoMerma.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(779, 544);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PantallaListadoMerma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 608);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridViewListadoMerma);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdMerma);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaListadoMerma";
            this.Text = "PantallaListadoMerma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoMerma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMerma;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.DataGridView dataGridViewListadoMerma;
        private System.Windows.Forms.Button btnSalir;
    }
}