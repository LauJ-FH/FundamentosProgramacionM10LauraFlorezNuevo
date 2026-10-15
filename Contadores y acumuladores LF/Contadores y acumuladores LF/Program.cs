using System;

namespace Contadores_y_acumuladores_LF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            while (contador <=5)
            {
                acumulador = acumulador + contador;
                contador++;
            }

            Console.WriteLine($"la suma de los cinco primeros numeros es: {acumulador}");*/
            int número;
            int contador = 1;
            int acumulador = 1;

            Console.WriteLine("Ingrese el nuemro:");
            número = int .Parse(Console.ReadLine());

            while (contador <= número)
            {
                acumulador = acumulador + contador;
                contador++;
            }

            Console.WriteLine($"El factorial del número es: {acumulador}");
        }
    }
}
