using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Graficar
{
    public class FuncionPertenencia
    {
        public int alpha;
        public int beta;
        public int gamma;
        public int pi;
        public FuncionPertenencia(int alpha, int beta)
        {
            this.alpha = alpha;
            this.beta = beta;
        }
        public FuncionPertenencia(int alpha, int beta, int gamma)
        {
            this.alpha = alpha;
            this.beta = beta;
            this.gamma = gamma;
        }
        public double funcionTriangular(double x)
        {
            double y = 0;

            if (alpha <= x && x <= beta)
            {
                y = (x - alpha) / (beta - alpha);
            }
            else if (beta < x && x <= gamma)
            {
                y = (x - gamma) / (beta - gamma);
            }
            else
            {
                y = 0;
            }
            return y;
        }
        public double funcionHombro(double x)
        {
            double y = 0;

            if (x <= alpha)
            {
                y = 1;
            }
            if (alpha < x && x <= beta)
            {
                y = (x - beta) / (alpha - beta);
            }
            if (x > beta)
            {
                y = 0;
            }

            return y;
        }
        public double funcionSaturacion(double x)
        {
            double y = 0;

            if (x <= alpha)
            {
                y = 0;
            }
            if (alpha < x && x <= beta)
            {
                y = (x - beta) / (alpha - beta);
            }
            if (x > beta)
            {
                y = 1;
            }

            return y;
        }
    }
}
