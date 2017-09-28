using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            var radio = 4;
            Circulo c = new Circulo(radio);
            Console.WriteLine("El radio del circulo es: " + radio);
            Console.WriteLine("El area es: " + c.CalcularArea());
            Console.WriteLine("El perimetro es: " + c.CalcularPerimetro());

            Console.ReadKey(true);
        }
    }
}
