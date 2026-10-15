using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Programación_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Para cada enunciado, crear el diagrama de módulos y escribir el código en C#. 
            //1.Desarrolla un programa que permita: 
            //Ingresar una palabra
            //LLevar la palabra ingresada a un vector de caracteres
            //Contar la cantidad de vocales y consonantes en la palabra proporcionada por el
            //usuario.

            string palabra;
            int vocales = 0;
            int consonantes = 0;
            string vls = "aeiouAEIOU";

            Console.WriteLine("Ingrese una palabra:");
            palabra = Console.ReadLine();

     
            foreach (char c in palabra)
            {
                if (char.IsLetter(c)) 
                {
                    if (vls.Contains(c))
                    {
                        vocales++;
                    }
                    else 
                    {
                        consonantes++;
                    }
                }
            }

            Console.WriteLine("Palabra ingresada: " + palabra);
            Console.WriteLine("Cantidad de vocales: " + vocales);
            Console.WriteLine("Cantidad de consonantes: " + consonantes);

            Console.ReadLine();

            //Crear un programa que permita gestionar una lista de tareas: 
            //Agregar tareas. 
            //Eliminar tareas 
            //Mostrar la lista de tareas.

            static List<string> listaTareas = new List<string>();

            static void Main(string[] args)
            {
                int opcion;

               
                do
                {
                    MostrarMenu();
                    opcion = LeerOpcion();
                    ProcesarOpcion(opcion);

                } while (opcion != 4); 
            }

            static void MostrarMenu()
            {
                Console.Clear();
                Console.WriteLine("=== GESTOR DE LISTA DE TAREAS ===");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea");
                Console.WriteLine("3. Mostrar lista de tareas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
            }

            static int LeerOpcion()
            {
                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    return opcion;
                }
                return 0;
            }

            
            static void ProcesarOpcion(int opcion)
            {
                Console.WriteLine(); 
                switch (opcion)
                {
                    case 1:
                        ModuloAgregarTarea();
                        break;
                    case 2:
                        ModuloEliminarTarea();
                        break;
                    case 3:
                        ModuloMostrarTareas();
                        PausarPantalla();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa... ¡Que tenga un gran día!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        PausarPantalla();
                        break;
                }
            }

            
            static void PausarPantalla()
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

            static void ModuloAgregarTarea()
            {
                Console.Write("Escriba la descripción de la nueva tarea: ");
                string nuevaTarea = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(nuevaTarea))
                {
                    listaTareas.Add(nuevaTarea);
                    Console.WriteLine("¡Tarea agregada exitosamente!");
                }
                else
                {
                    Console.WriteLine("Error: La descripción de la tarea no puede estar vacía.");
                }
                PausarPantalla();
            }

            static void ModuloMostrarTareas()
            {
                Console.WriteLine("=== TU LISTA DE TAREAS ===");

                if (listaTareas.Count == 0)
                {
                    Console.WriteLine("[La lista está vacía actualmente]");
                }
                else
                {
                    for (int i = 0; i < listaTareas.Count; i++)
                    {
                       
                        Console.WriteLine($"{i + 1}. {listaTareas[i]}");
                    }
                }
            }

            }

    }

}

