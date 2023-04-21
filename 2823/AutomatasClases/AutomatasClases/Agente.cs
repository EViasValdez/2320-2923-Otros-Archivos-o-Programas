using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatasClases
{
    internal class Agente
    {
        public List<Estado> estados = new List<Estado>();

        public void crearEstado(String pregunta)
        {
            Estado estado = new Estado(pregunta);
            estados.Add(estado);
        }
    }
}
