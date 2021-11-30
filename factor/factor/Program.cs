using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace factor
{
    class Program
    {
        static void Main(string[] args)
        {
            int fac = 1, x, n;
            string linea;
            x = 1;
            Console.Write("Ingrese un numero entero: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                fac = fac * x;
                x = x + 1;
            }
            Console.Write("La factorial es: " + fac);
            Console.ReadKey();
        }
    }
}
