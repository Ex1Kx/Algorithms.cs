using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EstructuraRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string linea;
            Console.Write("Ingrese multiplicador: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 1; i <= 15; i++)
            {
                Console.Write(i + " x " + n + " = " + i * n + "\n");
            }
            Console.ReadKey();
        }
    }
}