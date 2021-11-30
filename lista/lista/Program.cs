using System;

namespace lista
{
    class program
    {
        Console.WriteLine("Tamaño de la lista: ");
            int tamaño_lista2 = Convert.ToInt32(Console.ReadLine());
        int[] lista;
        lista = new int[tamaño_lista2 + 1];


            private pedir_numero(lista);
        static void pedir_numero(Array lista)
        {
            Console.WriteLine("Ingresa un numero: ");
            int multiplo = Convert.ToInt32(Console.ReadLine());

            int i;
            for (i = 1; i < lista.Length; i++)
            {
                resultado(multiplo, i);
                static void resultado(int multiplo, int i)
                {

                    Console.WriteLine(multiplo + " * " + i + " = " + (multiplo * i) + '\n');
                }
            }
        }
    }
}