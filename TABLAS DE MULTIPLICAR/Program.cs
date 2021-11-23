using System;

namespace TABLAS_DE_MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RESULT, T, I;
            string linea;

            Console.Write("CUANTAS TBLAS? "); linea = Console.ReadLine();
            NUM = int.Parse(linea);

            for (T = 1; T <= NUM; T++)
            {
                for (I = 1; I <= 10; I++)
                {
                    RESULT = T * I;
                    Console.WriteLine("{0} * {1} ES IGUAL A {2}", T , I, RESULT);
                }
            }
            Console.WriteLine("OTRA TABLA");



        }
    }
}
