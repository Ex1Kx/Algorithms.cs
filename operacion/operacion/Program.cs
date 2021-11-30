using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PruebaClase
{
    class Operaciones
    {
        private int valor1, valor2;
        // Método Inicializar()
        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese primer numero:");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);
            Console.Write("Ingrese segundo numero:");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }
        // Método Sumar()
        public void Sumar()
        {
            int suma;
            suma = valor1 + valor2;
            Console.WriteLine("La suma es:" + suma);
        }
        //Método Restar()
        public void Restar()
        {
            int resta;
            resta = valor1 ‐ valor2;
            Console.WriteLine("La resta es:" + resta);
        }
        // Método Multiplicar()
        public void Multiplicar()
        {
            int multiplicacion;
            multiplicacion = valor1 * valor2;
            Console.WriteLine("La multiplicación es:" + multiplicacion);
        }
        //Método Dividir()
        public void Dividir()
        {
            int division;
            division = valor1 / valor2;
            Console.WriteLine("La división es:" + division);
        }