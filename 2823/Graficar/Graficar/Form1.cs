using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficar
{
    public partial class Form1 : Form
    {
        FuncionPertenencia muyCerca = new FuncionPertenencia(29, 45);
        FuncionPertenencia cerca = new FuncionPertenencia(20, 45, 90);
        FuncionPertenencia normal = new FuncionPertenencia(45, 90, 130);
        FuncionPertenencia lejos = new FuncionPertenencia(98, 130, 155);
        FuncionPertenencia muyLejos = new FuncionPertenencia(130, 155);

        List<String> distancia = new List<String>();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            distancia.Add("Muy cerca");
            distancia.Add("cerca");
            distancia.Add("Normal");
            distancia.Add("Lejos");
            distancia.Add("Muy lejos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionPertenencia izquierda = new FuncionPertenencia(86, 99);
            FuncionPertenencia centro = new FuncionPertenencia(99, 90, 136);
            FuncionPertenencia derecha = new FuncionPertenencia(90, 136);

            for (double x = 0; x <= 180; x++)
            {
                double y = izquierda.funcionHombro(x);
                chart1.Series[0].Points.AddXY(x, y);
                y = centro.funcionTriangular(x);
                chart1.Series[1].Points.AddXY(x, y);
                y = derecha.funcionTriangular(x);
                chart1.Series[2].Points.AddXY(x, y);
            }
        }

        private void btnDistancia_Click(object sender, EventArgs e)
        {
            double y = 0;

            for (int x = 0; x <= 180; x++)
            {
                y = muyCerca.funcionHombro(x);
                chart1.Series[0].Points.AddXY(x, y);
                y = cerca.funcionTriangular(x);
                chart1.Series[1].Points.AddXY(x, y);
                y = normal.funcionTriangular(x);
                chart1.Series[2].Points.AddXY(x, y);
                y = lejos.funcionTriangular(x);
                chart1.Series[3].Points.AddXY(x, y);
                y = muyLejos.funcionSaturacion(x);
                chart1.Series[4].Points.AddXY(x, y);
            }
            //private void serialPort1_DataReceived(object sander, System.IO.Ports.SerialDataReceivedEventArgs e)
            //{
            //    SerialPort puerto = (SerialPort) sender;

            //    String dataLeida = puerto.ReadLine().Tria();
            //    double x = double.Parse(dataLeida);

            //    List<double> y = new List<double>();

            //    y.Add(muyCerca.funcion(x));
            //    y.Add(cerca.funcionTriangular(x));
            //    y.Add(normal.funcionTriangular(x));
            //    y.Add(lejos.funcionTriangular(x));
            //    y.Add(muyLejos.funcionTriangular(x));
            //}
        }
    }
}
