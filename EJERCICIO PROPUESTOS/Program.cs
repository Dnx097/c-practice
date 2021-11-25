using System;

namespace EJERCICIO_PROPUESTOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, I, Z, CONT = 0;
            string linea;

            Console.Write("DIGITE EL NUMERO "); linea = Console.ReadLine();

            NUM = int.Parse(linea);
            Z = linea.Length;
            I = Z; // EL ITERADOR VA A SER IGAL AL NUMERO DE CARACTERES QUE TENIA EL STRING, AHORA CONVERTIDO A INT

            while (I >= 1)
            {
                I--;    //EL ITERADOR SE RESTA EN CADA CICLO 
                CONT++;
            }
            Console.WriteLine();
            Console.WriteLine("EL NUMERO INGRESADO TIENE " + CONT + " DIGITOS");


        }
    }
}
