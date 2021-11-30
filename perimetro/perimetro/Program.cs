using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace perimetro
{
    class program
    {
        private int lado;
        public void Inicializar()
        {
            Console.Write("Ingrese valor del lado:");
            string linea;
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }
        public void ImprimirPerimetro()
        {
            int perimetro;
            perimetro = lado * 4;
            Console.WriteLine("El perímetro es:" + perimetro);
        }
        public void ImprimirSuperficie()
        {
            int superficie;
            superficie = lado * lado;
            Console.WriteLine("La superficie es:" + superficie);
        }
        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.Inicializar();
            cuadrado1.ImprimirPerimetro();
            al método ImprimirPerimetro();
            cuadrado1.ImprimirSuperficie();
            al método ImprimirSuperficie();
            Console.ReadKey();
        }
    }
}
