
namespace RepasoColecciones
{
    partial class PantallaIngresoCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btoguardar = new System.Windows.Forms.Button();
            this.btnlistar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "nombre";
            // 
            // txtrut
            // 
            this.txtrut.Location = new System.Drawing.Point(319, 90);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(238, 22);
            this.txtrut.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(319, 156);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(238, 22);
            this.txtnombre.TabIndex = 3;
            // 
            // btoguardar
            // 
            this.btoguardar.Location = new System.Drawing.Point(194, 266);
            this.btoguardar.Name = "btoguardar";
            this.btoguardar.Size = new System.Drawing.Size(75, 32);
            this.btoguardar.TabIndex = 4;
            this.btoguardar.Text = "guardar";
            this.btoguardar.UseVisualStyleBackColor = true;
            this.btoguardar.Click += new System.EventHandler(this.btoguardar_Click);
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(386, 266);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(75, 32);
            this.btnlistar.TabIndex = 5;
            this.btnlistar.Text = "listar";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(570, 266);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 32);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // PantallaIngresoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.btoguardar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtrut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaIngresoCliente";
            this.Text = "PantallaIngresoCliente";
            this.Load += new System.EventHandler(this.PantallaIngresoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btoguardar;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button btnsalir;
    }
}