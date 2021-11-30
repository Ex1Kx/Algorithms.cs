using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            string divisors = "";
            Console.Write("Ingresa Un Numero: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    divisors += i.ToString() + "+";
                }
            }
            divisors = divisors.Remove(divisors.Length - 1, 1);
            Console.WriteLine(divisors + " = " + sum);
            if (sum == number)
            {
                Console.WriteLine("El Numero " + number + " Es Perfecto");
            }
            else
                Console.WriteLine("El Numero " + number + " No Es Perfecto");

            Console.ReadKey();
        }
    }
}