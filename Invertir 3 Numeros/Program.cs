using System;

namespace Invertir_3_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, AUX, DEC, UNI, CEN;
            string linea;

            Console.WriteLine("ESCRIBA MUMERO DE TRES CIFRAS");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            CEN = NUM / 100;
            NUM = NUM % 100;
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 100) + (DEC * 10) + CEN;
            Console.WriteLine("EL NUMERO INVERTIDO ES: " + AUX);
            Console.WriteLine("PULSE UNA TECLA:"); Console.ReadLine();
        }
    }
}
