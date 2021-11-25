using System;

namespace FACTORES_PRIMOS_DE_UN_NUMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RESI, K;
            String linea;

            Console.Write("NUMERO "); linea = Console.ReadLine();
            NUM = int.Parse(linea);

            K = 2;

            while (NUM != 1)
            {
                RESI = NUM % K;

                if (RESI == 0)
                {
                    Console.WriteLine(K);
                    NUM = NUM / K;
                }
                else
                {
                    K = K + 1;
                }
            }

            Console.Write("PULSE UNA TECLA: ");

        }
    }
}
