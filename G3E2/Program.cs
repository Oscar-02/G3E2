﻿using System;

namespace G3E2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaro las variables
            int b = 0;
            int h = 0;
            int a = 0;
            //Mensaje de bienvenida
            Console.WriteLine("Hola y bienvenido. Este programa fue diseñado para calcular el area de un triangulo.");      
            //Entrada para la base
            Console.WriteLine("Para iniciar, por favor ingrese el valor de la base del triangulo...");
            b = Convert.ToInt32(Console.ReadLine());
            //Entrada para la altura
            Console.WriteLine("Bien, ahora por favor ingrese el valor de la altura del triangulo...");
            h = Convert.ToInt32(Console.ReadLine());
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
