
namespace RepasoColecciones
{
    partial class PantallaListadoCliente
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
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.ItemHeight = 16;
            this.listBoxCliente.Location = new System.Drawing.Point(208, 71);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(316, 148);
            this.listBoxCliente.TabIndex = 0;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(208, 284);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(431, 284);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // PantallaListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.listBoxCliente);
            this.Name = "PantallaListadoCliente";
            this.Text = "PantallaListadoCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCliente;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnsalir;
    }
}