using System;

namespace _6CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Multiples
            int respuesta = 0;
            Console.WriteLine("---------Menu--------");
            Console.WriteLine("1.Opcion 1     2.Opcion 2");
            Console.WriteLine("3.Opcion 3     4.Opcion 4");
            Console.WriteLine("5.Opcion 5");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Elia una opcion del menu");
            respuesta=int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligio la opcion 1");
                    break;
                case 2:
                    Console.WriteLine("Eligio la opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Eligio la opcion 3");
                    break;
                case 4:
                    Console.WriteLine("Eligio la opcion 4");
                    break;
                case 5:
                    Console.WriteLine("Eligio la opcion 5");
                    break;
                default:
                    Console.WriteLine("Elija una opcion valida");
                    break;
            }






        }
    }
}
