using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pares
{
    class program
    {
        Console.WriteLine("ejercicio 9:  Calcular la suma de los primeros N números pares.");
            int sumar2 = 0;
            for (int e = 2; e <= 10; e += 2)
            {
                Console.WriteLine(e);
                sumar2 = sumar2 + e;
            }
    Console.WriteLine("La suma de los numeros pares es: " + sumar2 + '\n');
    }
}