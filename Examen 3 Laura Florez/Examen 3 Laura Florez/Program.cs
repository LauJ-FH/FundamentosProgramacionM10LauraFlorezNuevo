using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3_Laura_Florez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double suma = 0;
            double promedio;
            double mayor = 0;
            double menor = 0;
            int aprobados = 0;

            for (int i = 1; i <= 18; i++)
            {
                Console.Write("Ingrese la nota del estudiante:");
                nota = double.Parse(Console.ReadLine());

                suma = suma + nota;

                if (nota > mayor)
                {
                    mayor = nota;
                }

                if (nota < menor)
                {
                    menor = nota;
                }

                if (nota >= 6.0)
                {
                    aprobados++;
                }
            }

            promedio = suma /= 18;

            Console.WriteLine("Reporte del curso:");

            Console.WriteLine($"Promedio general:{promedio}");

            Console.WriteLine($"La nota mas alta obtenida fue: {mayor}" );

            Console.WriteLine($"La nota mas baja obtenida fue: {menor}");

            Console.WriteLine($"La cantidad de estudiantes que aprobaron fue:{aprobados}");

            Console.ReadKey();

        }
    }
}
