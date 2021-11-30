using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.Write("Ingrese un numero:");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num == 0)
            {
                Console.Write("El numero es cero");
            }
            else
            {
                if (num > 0)
                {
                    Console.Write("El numero es positivo");
                }
                else
                {
                    Console.Write("El numero es negativo negativo");
                }
            }
            Console.ReadKey();
        }
    }
}