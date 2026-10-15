using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosUnidimencionalesLH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales - Vectores
            int[] numeros=new int[5];
            numeros[0] = 15;
            numeros[1] = 102;
            numeros[2] = 54;
            numeros[3] = 26;
            numeros[4] = 5;
            //numeros[5] = 11; no se puede porque la posicion 6 con indice 5 no existe
            Console.WriteLine($"El numero almacenado en la posiscion con indice 3 es: {numeros[3]}");
            //Otras formas de declarar e inicializar vectores
            char[] simbolos = new char[] {'?','/','o','5' };
            bool[] valoresVerdad = { true, false, true, false, true, true, };
            //Recorrer para llenar de datos el vector
            string[] nombres = new string[7];
            for (int i = 0;i<7;i++) 
            {
                Console.WriteLine($"Ingrese el nombre para la P {i+1}:I{i}:");
                nombres[i] = Console.ReadLine();
            }
            Console.Clear();
            //Recorrer para recuperar datos almacenados
            for (int i = 0;i<nombres.Length;i++)
            {
                Console.Write($" {nombres[i]}");
            }
        }
    }
}
