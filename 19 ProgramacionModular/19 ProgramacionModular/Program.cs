using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            
            RealizarOperaciones(CapturarOpcion());
        }
        static float Division()

        {
            float Division = 0;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                Division += numero;
                Console.WriteLine("Quiere seguir dividiendo: s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return Division;
        }

        static float Resta()
        {
            float Resta = 0;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                Resta += numero;
                Console.WriteLine("Quiere seguir restando: s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return Resta;
        }

        static float Multiplicacion()

        {
            float multiplicacion = 0;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                multiplicacion += numero;
                Console.WriteLine("Quiere seguir multiplicando: s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicacion;
        }

        static float Suma() 
        {
            float suma = 0;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un numero");
                numero=float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Quiere seguir sumando: s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta=='s');
            return suma;
        }

        static void RealizarOperaciones(int opcion) 
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"la SUMA de los numeros ingresados es:{Suma()}");
                    break;
                case 2:
                    Console.WriteLine($"la RESTA de los numeros ingresados es.{Resta()}");
                    break;
                case 3:
                    Console.WriteLine($"la MULTIPLICACION de los numeros ingresasos es: {Multiplicacion()}");
                    break;
                case 4:
                    Console.WriteLine($"la DIVISION de los numeros ingresados es:{Division()}");
                    break;
                case 0:
                    Console.WriteLine("SALIR");
                    break;
            }
        }
        static int CapturarOpcion() 
        {
            return int.Parse(Console.ReadLine());
        }
        static void MostrarMenu() 
        {
            Console.WriteLine("------------MENU-------------------");
            Console.WriteLine("1. Suma                     2. Resta");
            Console.WriteLine("3. Multipliccion            3. Division");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Ingrese una opcion del menu");
        }
    }
}
