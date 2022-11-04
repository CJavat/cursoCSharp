namespace cursoDeNet
{
    partial class codigoDelCurso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCambiarTexto = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(276, 119);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Hola Mundo";
            // 
            // btnCambiarTexto
            // 
            this.btnCambiarTexto.Location = new System.Drawing.Point(236, 145);
            this.btnCambiarTexto.Name = "btnCambiarTexto";
            this.btnCambiarTexto.Size = new System.Drawing.Size(139, 23);
            this.btnCambiarTexto.TabIndex = 1;
            this.btnCambiarTexto.Text = "Cambiar Texto";
            this.btnCambiarTexto.UseVisualStyleBackColor = true;
            this.btnCambiarTexto.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(303, 80);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(213, 83);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(84, 13);
            this.lbl_Edad.TabIndex = 3;
            this.lbl_Edad.Text = "Escribe tu edad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnCambiarTexto);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCambiarTexto;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lbl_Edad;
    }
}

