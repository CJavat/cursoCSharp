namespace cursoDeNet
{
    partial class calculadoraDelIDMC
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMostrarResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(29, 26);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(76, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Dame tu peso:";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(111, 23);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 20);
            this.txbPeso.TabIndex = 1;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(29, 61);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(80, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Dame tu Altura:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular IMC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(111, 58);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(51, 93);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblMostrarResultado
            // 
            this.lblMostrarResultado.AutoSize = true;
            this.lblMostrarResultado.Location = new System.Drawing.Point(116, 92);
            this.lblMostrarResultado.Name = "lblMostrarResultado";
            this.lblMostrarResultado.Size = new System.Drawing.Size(16, 13);
            this.lblMostrarResultado.TabIndex = 6;
            this.lblMostrarResultado.Text = "0.";
            // 
            // calculadoraDelIDMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 183);
            this.Controls.Add(this.lblMostrarResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.lblPeso);
            this.Name = "calculadoraDelIDMC";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblMostrarResultado;
    }
}