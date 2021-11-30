using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.Write("Ingrese un numero positivo: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num < 10)
            {
                Console.Write("El numero tiene un dígito");
            }
            else
            {
                if (num < 100)
                {
                    Console.Write("El numero tiene dos dígitos");
                }
                else
                {
                    if (num < 1000)
                    {
                        Console.Write("el numero tiene tres dígitos");
                    }
                    else
                    {
                        Console.Write("El numero tiene mas de tres digitos");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}