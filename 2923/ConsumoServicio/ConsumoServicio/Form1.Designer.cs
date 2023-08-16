namespace ConsumoServicio
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
            this.GrupoElementos = new System.Windows.Forms.GroupBox();
            this.BT_Conexion = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Salon = new System.Windows.Forms.TextBox();
            this.TB_Carrera = new System.Windows.Forms.TextBox();
            this.TB_Genero = new System.Windows.Forms.TextBox();
            this.TB_NumeroS = new System.Windows.Forms.TextBox();
            this.TB_Matricula = new System.Windows.Forms.TextBox();
            this.TB_FechaNacimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Eliminar = new System.Windows.Forms.Button();
            this.BT_Editar = new System.Windows.Forms.Button();
            this.BT_Guardar = new System.Windows.Forms.Button();
            this.TB_AM = new System.Windows.Forms.TextBox();
            this.TB_AP = new System.Windows.Forms.TextBox();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Id = new System.Windows.Forms.TextBox();
            this.DGV_TablaInformacion = new System.Windows.Forms.DataGridView();
            this.GrupoElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoElementos
            // 
            this.GrupoElementos.Controls.Add(this.BT_Conexion);
            this.GrupoElementos.Controls.Add(this.label10);
            this.GrupoElementos.Controls.Add(this.label9);
            this.GrupoElementos.Controls.Add(this.label8);
            this.GrupoElementos.Controls.Add(this.label7);
            this.GrupoElementos.Controls.Add(this.label6);
            this.GrupoElementos.Controls.Add(this.label5);
            this.GrupoElementos.Controls.Add(this.TB_Salon);
            this.GrupoElementos.Controls.Add(this.TB_Carrera);
            this.GrupoElementos.Controls.Add(this.TB_Genero);
            this.GrupoElementos.Controls.Add(this.TB_NumeroS);
            this.GrupoElementos.Controls.Add(this.TB_Matricula);
            this.GrupoElementos.Controls.Add(this.TB_FechaNacimiento);
            this.GrupoElementos.Controls.Add(this.label4);
            this.GrupoElementos.Controls.Add(this.label3);
            this.GrupoElementos.Controls.Add(this.label2);
            this.GrupoElementos.Controls.Add(this.label1);
            this.GrupoElementos.Controls.Add(this.BT_Eliminar);
            this.GrupoElementos.Controls.Add(this.BT_Editar);
            this.GrupoElementos.Controls.Add(this.BT_Guardar);
            this.GrupoElementos.Controls.Add(this.TB_AM);
            this.GrupoElementos.Controls.Add(this.TB_AP);
            this.GrupoElementos.Controls.Add(this.TB_Nombre);
            this.GrupoElementos.Controls.Add(this.TB_Id);
            this.GrupoElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoElementos.Location = new System.Drawing.Point(12, 12);
            this.GrupoElementos.Name = "GrupoElementos";
            this.GrupoElementos.Size = new System.Drawing.Size(471, 653);
            this.GrupoElementos.TabIndex = 0;
            this.GrupoElementos.TabStop = false;
            this.GrupoElementos.Text = "Datos";
            // 
            // BT_Conexion
            // 
            this.BT_Conexion.Location = new System.Drawing.Point(40, 560);
            this.BT_Conexion.Name = "BT_Conexion";
            this.BT_Conexion.Size = new System.Drawing.Size(392, 47);
            this.BT_Conexion.TabIndex = 23;
            this.BT_Conexion.Text = "Probar conexion";
            this.BT_Conexion.UseVisualStyleBackColor = true;
            this.BT_Conexion.Click += new System.EventHandler(this.BT_Conexion_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Salon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Carrera";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Numero social";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Matricula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // TB_Salon
            // 
            this.TB_Salon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Salon.Location = new System.Drawing.Point(221, 442);
            this.TB_Salon.Name = "TB_Salon";
            this.TB_Salon.Size = new System.Drawing.Size(197, 27);
            this.TB_Salon.TabIndex = 16;
            // 
            // TB_Carrera
            // 
            this.TB_Carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Carrera.Location = new System.Drawing.Point(221, 399);
            this.TB_Carrera.Name = "TB_Carrera";
            this.TB_Carrera.Size = new System.Drawing.Size(197, 27);
            this.TB_Carrera.TabIndex = 15;
            // 
            // TB_Genero
            // 
            this.TB_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Genero.Location = new System.Drawing.Point(221, 360);
            this.TB_Genero.Name = "TB_Genero";
            this.TB_Genero.Size = new System.Drawing.Size(197, 27);
            this.TB_Genero.TabIndex = 14;
            // 
            // TB_NumeroS
            // 
            this.TB_NumeroS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NumeroS.Location = new System.Drawing.Point(221, 317);
            this.TB_NumeroS.Name = "TB_NumeroS";
            this.TB_NumeroS.Size = new System.Drawing.Size(197, 27);
            this.TB_NumeroS.TabIndex = 13;
            // 
            // TB_Matricula
            // 
            this.TB_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Matricula.Location = new System.Drawing.Point(221, 273);
            this.TB_Matricula.Name = "TB_Matricula";
            this.TB_Matricula.Size = new System.Drawing.Size(197, 27);
            this.TB_Matricula.TabIndex = 12;
            // 
            // TB_FechaNacimiento
            // 
            this.TB_FechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FechaNacimiento.Location = new System.Drawing.Point(221, 231);
            this.TB_FechaNacimiento.Name = "TB_FechaNacimiento";
            this.TB_FechaNacimiento.Size = new System.Drawing.Size(197, 27);
            this.TB_FechaNacimiento.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // BT_Eliminar
            // 
            this.BT_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Eliminar.Location = new System.Drawing.Point(314, 505);
            this.BT_Eliminar.Name = "BT_Eliminar";
            this.BT_Eliminar.Size = new System.Drawing.Size(118, 40);
            this.BT_Eliminar.TabIndex = 6;
            this.BT_Eliminar.Text = "Eliminar";
            this.BT_Eliminar.UseVisualStyleBackColor = true;
            this.BT_Eliminar.Click += new System.EventHandler(this.BT_Eliminar_Click);
            // 
            // BT_Editar
            // 
            this.BT_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Editar.Location = new System.Drawing.Point(176, 505);
            this.BT_Editar.Name = "BT_Editar";
            this.BT_Editar.Size = new System.Drawing.Size(118, 40);
            this.BT_Editar.TabIndex = 5;
            this.BT_Editar.Text = "Editar";
            this.BT_Editar.UseVisualStyleBackColor = true;
            this.BT_Editar.Click += new System.EventHandler(this.BT_Editar_Click);
            // 
            // BT_Guardar
            // 
            this.BT_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Guardar.Location = new System.Drawing.Point(40, 505);
            this.BT_Guardar.Name = "BT_Guardar";
            this.BT_Guardar.Size = new System.Drawing.Size(118, 40);
            this.BT_Guardar.TabIndex = 4;
            this.BT_Guardar.Text = "Guardar";
            this.BT_Guardar.UseVisualStyleBackColor = true;
            this.BT_Guardar.Click += new System.EventHandler(this.BT_Guardar_Click);
            // 
            // TB_AM
            // 
            this.TB_AM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_AM.Location = new System.Drawing.Point(221, 184);
            this.TB_AM.Name = "TB_AM";
            this.TB_AM.Size = new System.Drawing.Size(197, 27);
            this.TB_AM.TabIndex = 3;
            // 
            // TB_AP
            // 
            this.TB_AP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_AP.Location = new System.Drawing.Point(221, 140);
            this.TB_AP.Name = "TB_AP";
            this.TB_AP.Size = new System.Drawing.Size(197, 27);
            this.TB_AP.TabIndex = 2;
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.Location = new System.Drawing.Point(221, 95);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(197, 27);
            this.TB_Nombre.TabIndex = 1;
            // 
            // TB_Id
            // 
            this.TB_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Id.Location = new System.Drawing.Point(221, 49);
            this.TB_Id.Name = "TB_Id";
            this.TB_Id.Size = new System.Drawing.Size(197, 27);
            this.TB_Id.TabIndex = 0;
            // 
            // DGV_TablaInformacion
            // 
            this.DGV_TablaInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TablaInformacion.Location = new System.Drawing.Point(489, 24);
            this.DGV_TablaInformacion.Name = "DGV_TablaInformacion";
            this.DGV_TablaInformacion.RowHeadersWidth = 51;
            this.DGV_TablaInformacion.RowTemplate.Height = 24;
            this.DGV_TablaInformacion.Size = new System.Drawing.Size(442, 637);
            this.DGV_TablaInformacion.TabIndex = 1;
            this.DGV_TablaInformacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_TablaInformacion_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 673);
            this.Controls.Add(this.DGV_TablaInformacion);
            this.Controls.Add(this.GrupoElementos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrupoElementos.ResumeLayout(false);
            this.GrupoElementos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaInformacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoElementos;
        private System.Windows.Forms.TextBox TB_AM;
        private System.Windows.Forms.TextBox TB_AP;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Eliminar;
        private System.Windows.Forms.Button BT_Editar;
        private System.Windows.Forms.Button BT_Guardar;
        private System.Windows.Forms.TextBox TB_Genero;
        private System.Windows.Forms.TextBox TB_NumeroS;
        private System.Windows.Forms.TextBox TB_Matricula;
        private System.Windows.Forms.TextBox TB_FechaNacimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Salon;
        private System.Windows.Forms.TextBox TB_Carrera;
        private System.Windows.Forms.Button BT_Conexion;
        private System.Windows.Forms.DataGridView DGV_TablaInformacion;
    }
}

