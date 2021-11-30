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
            int x, suma, valor, promedio;
            string linea;
            x = 1;
            suma = 0;
            while (x <= 8)
            {
                Console.Write("Ingrese valor " + x + ":");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma = suma + valor;
                x = x + 1;
            }
            promedio = suma / 8;
            Console.Write("La suma  es:");
            Console.WriteLine(suma);
            Console.Write("El promedio es:");
            Console.Write(promedio);
            Console.ReadKey();
        }
    }
}