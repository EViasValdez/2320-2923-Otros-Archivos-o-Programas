namespace AnalizadorLexico
{
    partial class AnalizadorLexico
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
            this.label1 = new System.Windows.Forms.Label();
            this.ResultadosTabla = new System.Windows.Forms.DataGridView();
            this.Analizar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Expresion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una expresión regular";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultadosTabla
            // 
            this.ResultadosTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadosTabla.Location = new System.Drawing.Point(112, 157);
            this.ResultadosTabla.Name = "ResultadosTabla";
            this.ResultadosTabla.RowHeadersWidth = 51;
            this.ResultadosTabla.RowTemplate.Height = 24;
            this.ResultadosTabla.Size = new System.Drawing.Size(404, 263);
            this.ResultadosTabla.TabIndex = 5;
            // 
            // Analizar
            // 
            this.Analizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Analizar.Location = new System.Drawing.Point(34, 448);
            this.Analizar.Name = "Analizar";
            this.Analizar.Size = new System.Drawing.Size(157, 42);
            this.Analizar.TabIndex = 2;
            this.Analizar.Text = "Analizar";
            this.Analizar.UseVisualStyleBackColor = true;
            this.Analizar.Click += new System.EventHandler(this.Analizar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(433, 448);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(149, 42);
            this.Limpiar.TabIndex = 3;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Expresion
            // 
            this.Expresion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expresion.Location = new System.Drawing.Point(214, 92);
            this.Expresion.Name = "Expresion";
            this.Expresion.Size = new System.Drawing.Size(213, 32);
            this.Expresion.TabIndex = 4;
            this.Expresion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AnalizadorLexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 502);
            this.Controls.Add(this.Expresion);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Analizar);
            this.Controls.Add(this.ResultadosTabla);
            this.Controls.Add(this.label1);
            this.Name = "AnalizadorLexico";
            this.Text = "Analizador léxico";
            this.Load += new System.EventHandler(this.AnalizadorLexico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ResultadosTabla;
        private System.Windows.Forms.Button Analizar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.TextBox Expresion;
    }
}