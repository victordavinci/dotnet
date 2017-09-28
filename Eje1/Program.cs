 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribi tu nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Escribi tu apellido: ");
            var apellido = Console.ReadLine();

            Console.WriteLine(apellido + ", " + nombre);

            Console.Write("Edad: ");

            var edad = uint.Parse(Console.ReadLine().Trim());
            if (edad > 17)
            {
                Console.WriteLine("Mayor de Edad");
            }
            else
            {
                Console.WriteLine("Menor de Edad");
            }

            Console.Write("Ingrese numero: ");
            var numero = int.Parse(Console.ReadLine());
            var suma = 0;
            for (var i = 0; i < numero;  i++)
            {
                suma += i;
            }
            Console.WriteLine("Ingreso: " + numero + " la suma de los anteriores es: " + suma);

            Console.Write("Ingrese 1° Numero: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese 2° Numero: ");
            var num2 = int.Parse(Console.ReadLine());
            var mcd = -1;
            for (var i = num1 < num2 ? num1 : num2; i > 0; i--)
            {
                if (num1 % i == 0 && num2 % i == 0) {
                    mcd = i;
                    break;
                }
            }
            Console.WriteLine("El MCD es: " + mcd);

            var acum = 0;
            var r = -1;
            var contador = -1;
            do
            {
                Console.Write("Ingrese numero: ");
                r = int.Parse(Console.ReadLine());
                acum += r;
                contador++;
            } while (r != 0);
            Console.WriteLine("El promedio de los numeros es: " + acum / (double) contador);

            Console.ReadKey(true);
        }
    }
}
