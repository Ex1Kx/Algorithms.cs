using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, valor, pares, impares;
            string linea;
            x = 1;
            pares = 0;
            impares = 0;
            Console.Write("Cuantos el valor de n:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                Console.Write("Ingrese el valor " + x + ": ");
                linea = Console.ReadLine();
                valor = int.Parse(linea); ;
                if (valor % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
                x = x + 1;
            }
            Console.Write("Cantidad de pares:");
            Console.WriteLine(pares);
            Console.Write("Cantidad de impares:");
            Console.Write(impares);
            Console.ReadKey();
        }
    }
}