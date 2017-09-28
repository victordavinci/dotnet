using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2
{
    class Circulo : IFigura
    {
        double radio = 0;

        public Circulo(double r)
        {
            this.radio = r;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalcularPerimetro()
        {
            return Math.PI * radio * 2;
        }
    }
}
