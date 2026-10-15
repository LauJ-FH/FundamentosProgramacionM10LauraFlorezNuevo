using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_vectores_LH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
            //encuentre y muestre el valor máximo y mínimo de los números ingresados. 

            int[] vector = new int[15];

            Console.WriteLine("Llenar vector de 15 numeros enteros");

            
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Ingrese el número para la posición [{i + 1}]: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            int maximo = vector[0];
            int minimo = vector[0];

           
            for (int i = 1; i < vector.Length; i++)
            {
                
                if (vector[i] > maximo)
                {
                    maximo = vector[i];
                }

               
                if (vector[i] < minimo)
                {
                    minimo = vector[i];
                }
            }

            
            Console.WriteLine("Resultados");
            Console.WriteLine($"El valor MÁXIMO ingresado es: {maximo}");
            Console.WriteLine($"El valor MÍNIMO ingresado es: {minimo}");

            Console.WriteLine("Presione cualquier tecla para salir...");

            //Escribir un algoritmo que permita:
            //a.Crear dos vectores del mismo tamaño. 
            //b.Llenarlos con números.
            //c.Comparar posición por posición.
            //d.Indicar cuántos elementos son iguales. 

            
            Console.WriteLine("Comparacion de vectores");
            Console.Write("Ingrese el tamaño que tendrán los vectores: ");
            int tamano = Convert.ToInt32(Console.ReadLine());

            
            int[] vector1 = new int[tamano];
            int[] vector2 = new int[tamano];

            
            Console.WriteLine("Llenando el Vector 1");
            for (int i = 0; i < tamano; i++)
            {
                Console.Write($"Vector 1 - Posición [{i + 1}]: ");
                vector1[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            Console.WriteLine("Llenando el Vector 2");
            for (int i = 0; i < tamano; i++)
            {
                Console.Write($"Vector 2 - Posición [{i + 1}]: ");
                vector2[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            int elementosIguales = 0;

            
            Console.WriteLine("Detalle de la Comparación");
            for (int i = 0; i < tamano; i++)
            {
                if (vector1[i] == vector2[i])
                {
                    Console.WriteLine($"Posición [{i + 1}]: Ambos tienen el número {vector1[i]} -> (IGUAL)");
                    elementosIguales++; 
                }
                else
                {
                    Console.WriteLine($"Posición [{i + 1}]: Vector1={vector1[i]} | Vector2={vector2[i]} -> (DIFERENTE)");
                }
            }

            
            
            Console.WriteLine($"RESULTADO: Se encontraron {elementosIguales} elementos iguales en la misma posición.");
            

            
            Console.WriteLine("Presione cualquier tecla para salir...");
            
        }
    }
}
