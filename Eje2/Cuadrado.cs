using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2
{
    class Cuadrado : IFigura
    {
        double lado = 0;
        public Cuadrado(double l) {
            this.lado = l;
        }
        public double CalcularArea()
        {
            return Math.Pow(lado, 2)/2;
        }

        public double CalcularPerimetro()
        {
            return lado *4;
        }
    }
}
