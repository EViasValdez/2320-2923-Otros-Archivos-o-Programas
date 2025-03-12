using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatasClases
{
    internal class ListaEstados
    {
        public Estado EstadoSig;
        public String Respuesta;

        public ListaEstados(String respuesta, Estado estado)
        {
            Respuesta = respuesta;
            EstadoSig = estado;
        }
    }
}