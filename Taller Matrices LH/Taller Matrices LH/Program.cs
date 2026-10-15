using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Matrices_LH
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            //pantalla la suma de los elementos de cada columna.

            
            int filas = 10;
            int columnas = 20;
            int[,] matriz = new int[filas, columnas];

            
            Random aleatorio = new Random();

            
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = aleatorio.Next(1, 10);
                }
            }

            
            Console.WriteLine("=== MATRIZ GENERADA (10 Filas x 20 Columnas) ===");
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    
                    Console.Write(matriz[f, c]);
                }
                Console.WriteLine(); 
            }

            Console.WriteLine("=== SUMA DE LOS ELEMENTOS DE CADA COLUMNA ===");
            
            for (int c = 0; c < columnas; c++)
            {
                int sumaColumna = 0; 

                for (int f = 0; f < filas; f++)
                {
                    sumaColumna += matriz[f, c];
                }

               
                Console.WriteLine($"Columna {c + 1:D2} -> Suma total: {sumaColumna}");
            }

            
            Console.WriteLine("Presione cualquier tecla para salir...");
            

        }
    }
}
