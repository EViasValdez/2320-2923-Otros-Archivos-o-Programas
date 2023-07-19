using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDifusa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Saturacion_Click(object sender, EventArgs e)
        {
            Funcion funcion = new Funcion(80, 100);

            double y = 0;
            for (int x = -20; x <= 120; x++) {
                y = funcion.calcularFuncionSaturacion(x);
                chart1.Series[0].Points.AddXY(x, y);
                lstY.Items.Add(y);
            }
        }

        private void Hombro_Click(object sender, EventArgs e)
        {
            Funcion funcion = new Funcion(40, 90);

            double y = 0;
            for (int x = 1; x <= 180; x++)
            {
                y = funcion.calcularFuncionHombro(x);
                chart1.Series[1].Points.AddXY(x, y);
                lstY.Items.Add(y);
            }
        }

        private void Triangular_Click(object sender, EventArgs e)
        {
            Funcion funcion = new Funcion(40, 6, 7);

            double y = 0;
            for (int x = -20; x <= 120; x++)
            {
                y = funcion.calcularFuncionTriangular(x);
                chart1.Series[2].Points.AddXY(x, y);
                lstY.Items.Add(y);
            }
        }

        private void PI_Click(object sender, EventArgs e)
        {
            Funcion funcion = new Funcion(4, 5, 7, 8);

            double y = 0;
            for (int x = -20; x <= 120; x++)
            {
                y = funcion.calcularFuncionPI(x);
                chart1.Series[3].Points.AddXY(x, y);
                lstY.Items.Add(y);
            }
        }
    }
}