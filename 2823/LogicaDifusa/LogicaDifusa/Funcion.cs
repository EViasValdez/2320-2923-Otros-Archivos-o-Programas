using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDifusa
{
    class Funcion
    {
        private double alfa;
        private double beta;
        private double gamma;
        private double pi;

        public Funcion(double alfa, double beta)
        {
            this.alfa = alfa;
            this.beta = beta;
        }
        public Funcion(double alfa, double beta, double gamma)
        {
            this.alfa = alfa;
            this.beta = beta;
            this.gamma = gamma;
        }
        public Funcion(double alfa, double beta, double gamma, double pi)
        {
            this.alfa = alfa;
            this.beta = beta;
            this.gamma = gamma;
            this.pi = pi;
        }
        public double calcularFuncionSaturacion(double x)
        {
            double y = 0;

            if (x <= alfa)
            {
                y = 0;
            }
            if (x > alfa && x < beta)
            {
                y = (x - alfa) / (beta - alfa);
            }
            if (x >= beta)
            {
                y = 1;
            }

            return y;
        }
        public double calcularFuncionHombro(double x)
        {
            double y = 0;

            if (x <= alfa)
            {
                y = 1;
            }
            if (x > alfa && x < beta)
            {
                y = 1 - (x - alfa) / (beta - alfa);
            }
            if (x >= beta)
            {
                y = 0;
            }

            return y;
        }
        public double calcularFuncionTriangular(double x)
        {
            double y = 0;

            if (x <= alfa)
            {
                y = 1;
            }
            if (x > alfa && x < beta)
            {
                y = 1 - (x - alfa) / (beta - alfa);
            }
            if (x >= beta && x < gamma)
            {
                y = 1 - (x - beta) / (gamma - beta);
            }
            if (x >= beta)
            {
                y = 0;
            }

            return y;
        }
        public double calcularFuncionPI(double x)
        {
            double y = 0;

            if (x <= alfa)
            {
                y = 0;
            }
            if (x > alfa && x < beta)
            {
                y = (x - alfa) / (beta - alfa);
            }
            if (x >= beta && x <= gamma)
            {
                y = 1;
            }
            if (x > gamma && x < pi)
            {
                y = 1 - (x - gamma) / (pi - gamma);
            }
            if (x >= pi)
            {
                y = 0;
            }

            return y;
        }
    }
}