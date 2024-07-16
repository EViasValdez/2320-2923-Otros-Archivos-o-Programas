using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatasClases
{
    internal class Estado
    {
        public String Pregunta;
        public List<ListaEstados> listaEstados = new List<ListaEstados>();

        public Estado(String pregunta)
        {
            Pregunta = pregunta;
        }

        public void agregarEstado(String respuesta, Estado estado)
        {
            ListaEstados lista = new ListaEstados(respuesta, estado);
            listaEstados.Add(lista);
        }
    }
}
