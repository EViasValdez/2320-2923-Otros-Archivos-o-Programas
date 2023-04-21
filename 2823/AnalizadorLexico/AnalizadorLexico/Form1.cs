using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class AnalizadorLexico : Form
    {
        List<char> Numeros = new List<char>(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
        List<char> Variables = new List<char>(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' });
        List<char> Operadores = new List<char>(new char[] { '+', '-', '*', '/' });
        List<char> Delimitadores = new List<char>(new char[] { '(', ')', '[', ']' });
        DataTable Resultados = new DataTable();
        public AnalizadorLexico()
        {
            InitializeComponent();
        }
        private void AnalizadorLexico_Load(object sender, EventArgs e)
        {
            Resultados.Columns.Add("Token", typeof(char));
            Resultados.Columns.Add("Tipo", typeof(string));
        }
        private void Analizar_Click(object sender, EventArgs e)
        {
            Resultados.Clear();

            List<char> Elementos = Expresion.Text.Replace(" ", "").ToCharArray().ToList();

            if (Elementos.Count > 0)
            {
                DataRow Fila;

                foreach (char elemento in Elementos)
                {
                    Fila = Resultados.NewRow();

                    if (Numeros.Contains(elemento))
                    {
                        Fila["Token"] = elemento;
                        Fila["Tipo"] = "Número";
                    }
                    else if (Variables.Contains(elemento.ToString().ToUpper()[0]))
                    {
                        Fila["Token"] = elemento;
                        Fila["Tipo"] = "Variable";
                    }
                    else if (Operadores.Contains(elemento))
                    {
                        Fila["Token"] = elemento;
                        Fila["Tipo"] = "Operador";
                    }
                    else if (Delimitadores.Contains(elemento))
                    {
                        Fila["Token"] = elemento;
                        Fila["Tipo"] = "Delimitador";
                    }
                    else
                    {
                        Fila["Token"] = elemento;
                        Fila["Tipo"] = "Error";
                    }

                    ResultadosTabla.Rows.Add(Fila);
                }

                ResultadosTabla.DataSource = Resultados;
                ResultadosTabla.Refresh();
            }
            else
            {
                ResultadosTabla.DataSource = null;
                ResultadosTabla.Refresh();
            }
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            Expresion.Clear();
            Resultados.Clear();
            ResultadosTabla.DataSource = null;
            ResultadosTabla.Refresh();
        }
    }
}