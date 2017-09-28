using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2
{
    class Triangulo : IFigura
    {
        double b;
        double h;
        public Triangulo (double bas, double altura)
        {
            this.b = bas;
            this.h = altura;
        }
        double IFigura.CalcularArea()
        {
            return b * h / 2;
        }

        double IFigura.CalcularPerimetro()
        {
            //triangulo equilatero
            return 3 * b;
        }
    }
}
