namespace EjemploPerceptronMultiCapa
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnEntrenar = new System.Windows.Forms.Button();
            this.btnReconocer = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrenar.
            // 
            this.btnEntrenar.Location = new System.Drawing.Point(51, 33);
            this.btnEntrenar.Name = "btnEntrenar";
            this.btnEntrenar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrenar.TabIndex = 0;
            this.btnEntrenar.Text = "Entrenar";
            this.btnEntrenar.UseVisualStyleBackColor = true;
            this.btnEntrenar.Click += new System.EventHandler(this.BtnEntrenar_Click);
            // 
            // btnReconocer.
            // 
            this.btnReconocer.Location = new System.Drawing.Point(51, 92);
            this.btnReconocer.Name = "btnReconocer";
            this.btnReconocer.Size = new System.Drawing.Size(75, 23);
            this.btnReconocer.TabIndex = 1;
            this.btnReconocer.Text = "Reconocer";
            this.btnReconocer.UseVisualStyleBackColor = true;
            this.btnReconocer.Click += new System.EventHandler(this.BtnReconocer_Click);
            // 
            // serialPort1.
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // label1.
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "10";
            // 
            // label2.
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1";
            // 
            // Form1.
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 225);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReconocer);
            this.Controls.Add(this.btnEntrenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrenar;
        private System.Windows.Forms.Button btnReconocer;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}