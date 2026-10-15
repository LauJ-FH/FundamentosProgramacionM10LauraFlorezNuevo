using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumuladores_y_contadores_2_LH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int acumulador = 0;
            int numero = 0;

            Console.WriteLine("Ingrese el numero a sumar");
            numero=int.Parse.(Console.ReadLine());

            while (numero>=0) 
            {
                acumulador += numero;
                Console.WriteLine("Ingrese el numero a sumar");
                numero=int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma de los numeros ingresados es: {acumulador}");*/

            /*int acumulador = 0;
            int numero = 0;

            Console.WriteLine("Ingrese el numero entero:");
            numero=int.Parse(Console.ReadLine());

            while (numero > 0)
            {
                acumulador += numero;
                Console.WriteLine("Ingrese un numero al azar:");
                numero= int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La cantidad de numeros ingresados son: {acumulador}");*/

            /*int cantidadNumeros = 0;
            int numero = 0;
            int contador = 0;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;

            Console.WriteLine("Ingrese la cantidad de numeros a evaluar");
            cantidadNumeros=int.Parse(Console.ReadLine());

            while(contador<cantidadNumeros)
            {
                contador++;
                Console.WriteLine("Ingrese el numero a evaluar");
                numero=int.Parse(Console.ReadLine());
                if (numero>0)
                {
                    contadorPositivos++;
                }
                else
                {
                    if (numero<0)
                    {
                        contadorNegativos++;
                    }
                    else
                    {
                        contadorCeros++;
                    }
                }
            }
            Console.WriteLine($"Cantidad de positivos: {contadorPositivos} Cantidad de negativos {contadorNegativos} Cantidad de ceros {contadorCeros}");*/

            int rango = 0;
            int contador = 1;
            int contadorPares = 0;

            Console.WriteLine("Ingrese el rango de numeros que quiere evaluar");
            rango=int.Parse(Console.ReadLine());

            while (contador<=rango)
            {
                if(contador % 2 == 0) 
                {
                    contadorPares++;
                    Console.WriteLine($"{contador} - ");
                }
                contador++;
            }
            Console.WriteLine($"La cantidad de numeros impares en el rango de 1 al {rango} es {contadorPares}");
        }
    }
}
