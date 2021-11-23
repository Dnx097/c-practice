using System;

namespace EJERCICIO_PROPUESTO
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2;

            Double RESUL;

            string linea;

            Console.WriteLine("NUMERO 1: "); linea = Console.ReadLine();

            NUM1 = int.Parse(linea);

            Console.WriteLine("NUMERO 2: "); linea = Console.ReadLine();

            NUM2 = int.Parse(linea);

            RESUL = (NUM1 + NUM2) * (NUM1 - NUM2);

            Console.WriteLine("EL RESULTADO ES: " + RESUL);

        }
            

    }
}

