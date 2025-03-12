namespace LogicaDifusa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Saturacion = new System.Windows.Forms.Button();
            this.Hombro = new System.Windows.Forms.Button();
            this.Triangular = new System.Windows.Forms.Button();
            this.PI = new System.Windows.Forms.Button();
            this.lstY = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(165, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Green,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Gold,
        System.Drawing.Color.Silver};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(552, 326);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Saturacion
            // 
            this.Saturacion.Location = new System.Drawing.Point(9, 12);
            this.Saturacion.Name = "Saturacion";
            this.Saturacion.Size = new System.Drawing.Size(150, 39);
            this.Saturacion.TabIndex = 1;
            this.Saturacion.Text = "Saturacion";
            this.Saturacion.UseVisualStyleBackColor = true;
            this.Saturacion.Click += new System.EventHandler(this.Saturacion_Click);
            // 
            // Hombro
            // 
            this.Hombro.Location = new System.Drawing.Point(9, 67);
            this.Hombro.Name = "Hombro";
            this.Hombro.Size = new System.Drawing.Size(150, 44);
            this.Hombro.TabIndex = 2;
            this.Hombro.Text = "Hombro";
            this.Hombro.UseVisualStyleBackColor = true;
            this.Hombro.Click += new System.EventHandler(this.Hombro_Click);
            // 
            // Triangular
            // 
            this.Triangular.Location = new System.Drawing.Point(9, 117);
            this.Triangular.Name = "Triangular";
            this.Triangular.Size = new System.Drawing.Size(150, 42);
            this.Triangular.TabIndex = 3;
            this.Triangular.Text = "Triangular";
            this.Triangular.UseVisualStyleBackColor = true;
            this.Triangular.Click += new System.EventHandler(this.Triangular_Click);
            // 
            // PI
            // 
            this.PI.Location = new System.Drawing.Point(9, 165);
            this.PI.Name = "PI";
            this.PI.Size = new System.Drawing.Size(150, 42);
            this.PI.TabIndex = 4;
            this.PI.Text = "PI";
            this.PI.UseVisualStyleBackColor = true;
            this.PI.Click += new System.EventHandler(this.PI_Click);
            // 
            // lstY
            // 
            this.lstY.FormattingEnabled = true;
            this.lstY.ItemHeight = 16;
            this.lstY.Location = new System.Drawing.Point(9, 223);
            this.lstY.Name = "lstY";
            this.lstY.Size = new System.Drawing.Size(150, 164);
            this.lstY.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.lstY);
            this.Controls.Add(this.PI);
            this.Controls.Add(this.Triangular);
            this.Controls.Add(this.Hombro);
            this.Controls.Add(this.Saturacion);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Saturacion;
        private System.Windows.Forms.Button Hombro;
        private System.Windows.Forms.Button Triangular;
        private System.Windows.Forms.Button PI;
        private System.Windows.Forms.ListBox lstY;
    }
}