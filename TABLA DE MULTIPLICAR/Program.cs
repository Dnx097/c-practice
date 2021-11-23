using System;

namespace TABLA_DE_MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte NUM, I;
            int RESUL;
            string linea;

            Console.WriteLine("DIGITE UN NUMERO"); linea = Console.ReadLine();
            NUM = Byte.Parse(linea);

            for (I = 1; I <= 10; I++)
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} ES IGUAL A {2}", NUM, I, RESUL);
            }

        }
    }
}
