using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutomatasClases
{
    public partial class Form1 : Form
    {
        int numeroEstados = 0;
        String[] preguntas;
        String[] respuestas;
        Agente agente = new Agente();
        Estado Actual;

        List<string> ataque = new List<string>() {"Llamarada", "Ascuas", "Hidrobomba", "Burbujas", "Rayo Solar", "Drenadoras", "Otra vez"};

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"../",
                Filter = "Archivo de estado de estados (*.ia)|*.ia|All files (*.*)|*.*"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader leer = new StreamReader(openFileDialog1.FileName);
                    preguntas = leer.ReadLine().Split(',');
                    numeroEstados = preguntas.Length;
                    respuestas = leer.ReadLine().Split(',');

                    for (int j = 0; j < numeroEstados; j++)
                    {
                        agente.crearEstado(preguntas[j]);
                    }
                    leer.ReadLine();
                    for (int i = 0; i < numeroEstados; i++)
                    {
                        String[] transiciones = leer.ReadLine().Split('\t');
                        if (transiciones[0] != "")
                        {
                            for (int x = 0; x < transiciones.Length; x++)
                            {
                                String numeroEstado = transiciones[x];
                                if (numeroEstado != "null")
                                {
                                    int estado = Convert.ToInt32(numeroEstado);
                                    String transicion = respuestas[x].ToString();
                                    agente.estados[i].agregarEstado(transicion, agente.estados[estado]);
                                }
                            }
                        }
                    }
                    // limpiar();
                    proceso(agente.estados[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void proceso(Estado estado)
        {
            Actual = estado;
            lblTitle.Text = Actual.Pregunta;
            List<Control> eliminar = new List<Control>();

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    eliminar.Add(control);
                }
            }

            foreach (Control control in eliminar)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }

            int posX = 58;
            int posY = 269;
            int index = 0;

            foreach (ListaEstados elemento in Actual.listaEstados)
            {
                PictureBox pictureBox = new PictureBox();

                pictureBox.Image = Image.FromFile(@"..\..\img\" + elemento.Respuesta + ".png");
                pictureBox.Location = new Point(posX, posY);

                if (ataque.Contains(elemento.Respuesta))
                {
                    pictureBox.Size = new Size(200, 100);
                    posX += 220;
                    if (posX + 120 > this.ClientSize.Width)
                    {
                        posX = 10;
                        posY += 150;
                    }
                }
                else
                {
                    pictureBox.Size = new Size(120, 120);
                    posX += 150;
                    if (posX + 150 > this.ClientSize.Width)
                    {
                        posX = 10;
                        posY += 150;
                    }
                }

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Click += new EventHandler(PictureBox_Click);
                pictureBox.Tag = index;
                this.Controls.Add(pictureBox);

                index++;
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int index = (int)pictureBox.Tag;
            proceso(Actual.listaEstados[index].EstadoSig);
            //mensaje();
        }

        // private void mensaje()
        // {
        //     PictureBox pictureBox = new PictureBox();
        //     pictureBox.Location = new Point(40, 269);
        //     pictureBox.Size = new Size(150, 120);
        //     pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        //     pictureBox.BackColor = Color.Transparent;

        //     if (lblTitle.Text == "Ganaste")
        //     {
        //         pictureBox.Image = Image.FromFile(@"..\..\img\Ganaste.png");
        //     }
        //     else if (lblTitle.Text == "Perdiste")
        //     {
        //         pictureBox.Image = Image.FromFile(@"..\..\img\Perdiste.png");
        //     }
        //     else if (lblTitle.Text == "Empataste")
        //     {
        //         pictureBox.Image = Image.FromFile(@"..\..\img\Empataste.png");
        //     }
        // }

        // private void limpiar()
        // {
        //     List<Control> eliminar = new List<Control>();
        //     foreach (Control control in this.Controls)
        //     {
        //         if (control is pictureBox)
        //         {
        //             eliminar.Add(control);
        //         }
        //     }
        //     foreach (Control control in eliminar)
        //     {
        //         this.Controls.Remove(control);
        //         control.Dispose();
        //     }
        // }
    }
}
