using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAupt.uptRNA;

namespace EjemploPerceptronMultiCapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            serialPort1.Open();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort puerto = (SerialPort)sender;
            PerceptronMultiCapa rna = new PerceptronMultiCapa(@"distancia.ppm");
            string datoLeidoDistancia = puerto.ReadLine().Trim();
            double xDistancia = double.Parse(datoLeidoDistancia);
            double[] x = { xDistancia };
            rna.reconocer(x);

            double[,] y = rna.y;
            label1.Text = y[0, 0].ToString();
            label2.Text = xDistancia.ToString();
            string data = label1.Text;
            serialPort1.Write(data);

        }

            private void BtnEntrenar_Click(object sender, EventArgs e)
        {
            PerceptronMultiCapa rna = new PerceptronMultiCapa(@"distancia.pml");
            rna.entrenar();
        }

        private void BtnReconocer_Click(object sender, EventArgs e)
        {
            PerceptronMultiCapa rna = new PerceptronMultiCapa(@"distancia.ppm");

            double[] x = { 92 };
            rna.reconocer(x);

            double[,] y = rna.y;
        }
    }
}
