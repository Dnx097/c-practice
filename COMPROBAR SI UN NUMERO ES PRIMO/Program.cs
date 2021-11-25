using System;

namespace COMPROBAR_SI_UN_NUMERO_ES_PRIMO
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, SW, RESI;
            string linea;

            X = 2;
            SW = 0;

            Console.WriteLine("NUMERO PRIMO: ");
            Console.WriteLine();
            Console.WriteLine("INGRESE EL NUMERO: ");

            linea = Console.ReadLine();

            N = int.Parse(linea);

            while (X < N && SW == 0)
            {
                RESI = N % X;
                if (RESI == 0)
                {
                    SW = 1;
                }
                else
                {
                    X = X + 1;
                }
            }
            if (SW == 0)
            {
                Console.WriteLine();
                Console.WriteLine("EL NUMERO ES PRIMO");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("EL NUMERO NO ES PRIMO");
            }

        }
    }
}
