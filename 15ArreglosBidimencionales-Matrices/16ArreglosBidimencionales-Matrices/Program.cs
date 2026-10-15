using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ArreglosBidimencionales_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimencionales o matrices}
            int[,] numeros = new int[2, 3];

            numeros[2, 1] = 10;

            //numeros[2,  1] = 10; no se puede almacenar porque el indice de la fila no existe
            //numeros[1, 3] = 15; no se puede almacenar porque el indice la columba no existe
            numeros[0, 0] = 12;
            numeros[0, 1] = 100;
            numeros[0, 2] = 56;
            numeros[1, 0] = 45;
            numeros[1, 1] = 0;
            numeros[1, 2] = 10;

            Console.WriteLine($"El valor almacenado en numeros[1,0]:{numeros[1, 0]}");
            //Recorrer para llenar
            char[,] simbolos = new char[3, 2];
            for (int i = 0; i < 3; i++)//Recorre las filas
            {
                for (int j = 0; j < 2; j++)//Recorre las columnas 
                {
                    Console.WriteLine($"Ingrese el caracter para simbolos [{i},{i}]:");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer para recuperar datos

            for (int i = 0; i < simbolos.GetLength(0);i++)
            {
                for (int j=0; j<simbolos.GetLength(1);j++)
                    
                {
                    Console.Write($"{simbolos[i, j]} |");
                }
                Console.WriteLine();
            }
            //Otra forma de declarar e inicilizar matrices

            string[,] nombres = {
                                   {"Ana","Juan","Carlos","Alvaro" },
                                   { "Pedro","Ferney","Yuli","Felix"},
                                   { "Carla","Alex","Esteban","Salome" }
                                };
        }
    }
}
