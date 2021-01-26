using System;

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
            Console.WriteLine("Por favor ingrese el valor de la base del triangulo");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bien, ahora por favor ingrese el valor de la altura del triangulo");
            h = Convert.ToInt32(Console.ReadLine());
            a = (b * h) / 2;
            Console.WriteLine("El area de ese triangulo es de: " + a);
            Console.WriteLine("\nIngrese cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
