using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloDoWhileLH
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//int contador = 1;
			//int acumulador = 0;

			//do
			//{
			//	acumulador += contador;
			//	contador++;
			//} while (contador<=5);

			//Console.WriteLine($"La suma de los cinco primeros numeros es: {acumulador}");

			//int contador = 1;
			//int acumulador = 10;

			//do
			//{
			//	acumulador += contador;
			//	contador++;
			//} while (contador <= 10);

			//Console.WriteLine($"La tabla de multiplicar es: {acumulador}");

			int contador = 1;
			int contador2 = 1;
			int contadorDivisiones = 0;

			do
			{
				do
				{
					if(contador%contador2==0)
					{
						contadorDivisiones++;
					}

					contador2++;
				} while (contador2<=contador);
				contador2 = 1;

				if (contadorDivisiones==2)
				{
					Console.WriteLine(contador);
				}
				//Console.WriteLine(contador);
				contadorDivisiones = 0;
				contador++;
			} while (contador <= 100);


        }

		
    }
}
