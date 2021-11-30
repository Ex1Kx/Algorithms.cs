using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = " ";
            int where = 15;
            for (int a = 2; a <= where; a++)
            {
                if ((a % 2) == 1)
                {
                    int men = a - 1 / 2;
                    cadena = cadena + men + " ";
                }
                else
                {
                    int men = a + 2;
                    cadena = cadena + men + " ";
                }
            }
            Console.WriteLine(cadena);
        }
    }
}
