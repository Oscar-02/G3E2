using System;

namespace G3E2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PROGRAMACION ESTRUCTURADA GRUPO 07L
             * EJERCICIO 4 GUIA 3
             * 
             * OSCAR ROLANDO CAÑAS VALDIZON
             */

            //Declaro las variables
            double b, h, a;
            //Mensaje de bienvenida
            Console.WriteLine("Hola y bienvenido. Este programa fue diseñado para calcular el area de un triangulo.");      
            //Entrada para la base
            Console.WriteLine("Para iniciar, por favor ingrese el valor de la base del triangulo...");
            b = Convert.ToDouble(Console.ReadLine());
            //Entrada para la altura
            Console.WriteLine("Bien, ahora por favor ingrese el valor de la altura del triangulo...");
            h = Convert.ToDouble(Console.ReadLine());
            //Operacion
            a = (b * h) / 2;
            //Impresion de resultados
            Console.WriteLine("El area de ese triangulo es de: " + a);
            //Mensaje de salida
            Console.WriteLine("\nIngrese cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
