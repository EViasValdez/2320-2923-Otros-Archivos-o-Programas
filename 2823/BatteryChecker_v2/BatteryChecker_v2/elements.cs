using IAupt.uptRNA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryChecker_v2
{
    public class elements
    {
        public string texto="";
        public bool check;
        public void training()
        {
          PerceptronMultiCapa rna = new PerceptronMultiCapa(@"InstructivoPerceptronMulticapa.pml");
          rna.entrenar();
        }
        public void recognize(int b)
        {
          PerceptronMultiCapa rna = new PerceptronMultiCapa(@"InstructivoPerceptronMulticapa.ppm");

           double[] x = { b };
           rna.reconocer(x);

           double[,] y = rna.y;

            switch (y[0, 0])
            {
                default:
                    texto = "no hay datos";
                    break;
                case 1:
                    texto = "Muy baja";
                    break;
                case 2:
                    texto = "Baja";
                    break;
                case 3:
                    texto = "Media";
                    break;
                case 4:
                    texto = "Alta";
                    break;
                case 5:
                    texto = "Muy alta";
                    break;
            }
        }
        public void checker(bool element)
        {

        }
        public bool checking(bool element) 
        {
            
            return this.check;
        }
    }
}