using System;

namespace TALLER_CONDICIONALES_LH
{
    internal class Program
    {
        static void Main(string[] args);

        ////Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
        //numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
        //diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
        //pantalla los números de menor a mayor.

          
        double numero1, numero2, numero3;

            Console.WriteLine("=== ALGORITMO DE COMPARACIÓN Y ORDENAMIENTO ===");

            Console.Write("Ingrese el primer valor (numero1): ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo valor (numero2): ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer valor (numero3): ");
            numero3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--- Procesando Resultados ---");

            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            {
              
                Console.WriteLine("Error: Se deben ingresar números diferentes.");
            }
            else
            {
                
                double menor, medio, mayor;

                if (numero1 > numero2 && numero1 > numero3)
                {
                    mayor = numero1;
                    medio = (numero2 > numero3) ? numero2 : numero3;
                    menor = (numero2 < numero3) ? numero2 : numero3;
                }
                else if (numero2 > numero1 && numero2 > numero3)
                {
                    mayor = numero2;
                    medio = (numero1 > numero3) ? numero1 : numero3;
                    menor = (numero1 < numero3) ? numero1 : numero3;
                }
                else
                {
                    mayor = numero3;
                    medio = (numero1 > numero2) ? numero1 : numero2;
                    menor = (numero1 < numero2) ? numero1 : numero2;
                }

          
                Console.WriteLine($"El número mayor es: {mayor}");
                Console.WriteLine($"Números ordenados de menor a mayor: {menor}, {medio}, {mayor}");
            }

           
            Console.WriteLine("Presione cualquier tecla para salir...");
           

            //El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
            //cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
            //a.Permita ingresar por teclado si el personaje está en estado invencible (True). 
            //b. La cantidad de munición que tiene el personaje en el momento será calculada por el 
            //sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#.
            
            
            bool esInvencible = false;
            int municion;

            
            Random aleatorio = new Random();

            Console.WriteLine("Estado del personaje");

            
            Console.Write("¿El personaje es invencible? (Escriba 'True' o 'False'):");
            string entrada = Console.ReadLine();

            
            if (bool.Console.Parse(entrada, out esInvencible))
            {
                
                municion = aleatorio.Next(0, 11); 

                Console.WriteLine("--- Diagnóstico del Sistema ---");
                Console.WriteLine($"Estado invencible: {esInvencible}");
                Console.WriteLine($"Cantidad de munición generada: {municion}");
                Console.WriteLine("--------------------------------");

                
                if (municion > 0 && esInvencible)
                {
                    Console.WriteLine("¡Resultado: El personaje PUEDE disparar!");
                }
                else
                {
                    Console.WriteLine("Resultado: El personaje NO puede disparar.");
                    
                    
                    if (municion == 0 && !esInvencible)
                        Console.WriteLine("Razón: No tiene munición y tampoco es invencible.");
                    else if (municion == 0)
                        Console.WriteLine("Razón: Se quedó sin munición.");
                    else
                        Console.WriteLine("Razón: No se encuentra en estado invencible.");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Debe escribir exactamente 'True' o 'False'.");
            }

            
            Console.WriteLine("Presione cualquier tecla para salir...");
            
        }

    }
    
}
