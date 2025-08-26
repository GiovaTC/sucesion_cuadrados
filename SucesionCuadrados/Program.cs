using System;

namespace SucesionCuadrados
{
    class Program
    {
        static void Main(string[] args)
        {
            // definimos cuantos terminos mostrar
            int cantidad = 10;

            Console.WriteLine("sucesion de cuadrados:");

            for (int i = 1; i <= cantidad; i++)
            {
                int cuadrado = i * i;
                Console.Write(cuadrado + " ");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();        
        }
    }
}