using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            string linea;
            Console.Write("Ingrese la primera nota:");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);
            Console.Write("Ingrese la segunda nota:");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);
            Console.Write("Ingrese la tercera nota:");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);
            int promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio > 10)
            {
                Console.Write("Aprobado");
            }
            else
            {
                if (promedio > 7)
                {
                    Console.Write("Desaprobado");
                }
                else
                {
                    Console.Write("Reprobado");
                }
            }
            Console.ReadKey();
        }
    }
}