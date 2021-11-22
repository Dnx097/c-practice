using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Invertir_número_de_dos_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, AUX, DEC, UNI;
            string linea;

            Console.WriteLine("INGRESE NUMERO DE DOS CIFRAS: ");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 10) + DEC;
            Console.WriteLine("NUMERO INVERTIDO ES: " + AUX);
            Console.WriteLine("PULSE UNA TECLA:"); Console.ReadLine();
        }
    }
}
