using System;

namespace programacion_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string iva = "19%";
            string nombre = "laura";
            nombre = "valentina";
            //iva = "20%"; que a una constante no se le puede cambiar su valor

            //Tipos de Datos
            byte dato1 = 255;
            int dato2 = -256;
            ulong dato3 = 1236333;
            float dato4 = 5.3f;
            double dato5 = 2123.3265d;
            char dato6 = "g";//almacena solo un caracter
            string dato7 = "lkgtfu73873hkg))((//---";
            bool dato8 = false;//true o false
            object dato9 = new object();
            //Operadores
            //Numéricos
            //cambio de signo
            int dato10 = 5;
            int dato11 = -dato10;
            int dato12 = +dato11;
            int dato13 = -dato12;
            Console.WriteLine("dato10; {0}, dato11:{1}, dato12:{2}, dato13:{3}
                dato10, dato11, dato12, dato13);
            //Operadores aritméticos
            int dato14 = 5 + 3;//suma
            int dato15 = dato14 - 2;//resta
            int dato16 = 10 * 3;//producto
            float dato17 = 5.0f / 3.0f;
            Console.WriteLine("suma:{0}, resta: {1}, producto:{2}, división:{3}",
                dato14, dato15, dato16, dato17);
            //Incremento - decremento
            int dato18 = 1;
            dato18++;//dato18=dato18+1
            dato18--;//dato18=dato18


        }
    }
}
