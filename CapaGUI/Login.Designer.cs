
namespace CapaGUI
{
    partial class Login
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
            this.txtRutUsuario = new System.Windows.Forms.TextBox();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "clave";
            // 
            // txtRutUsuario
            // 
            this.txtRutUsuario.Location = new System.Drawing.Point(276, 100);
            this.txtRutUsuario.Name = "txtRutUsuario";
            this.txtRutUsuario.Size = new System.Drawing.Size(186, 22);
            this.txtRutUsuario.TabIndex = 2;
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(276, 166);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(186, 22);
            this.txtClaveUsuario.TabIndex = 3;
            this.txtClaveUsuario.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(417, 288);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(86, 36);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 368);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtClaveUsuario);
            this.Controls.Add(this.txtRutUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutUsuario;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.Button btnIngresar;
    }
}