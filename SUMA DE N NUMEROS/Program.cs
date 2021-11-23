using System;

namespace SUMA_DE_N_NUMEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte CAN, K;
            int NUM;
            int SUM = 0;
            String linea;

            Console.WriteLine("LIMITE"); linea = Console.ReadLine();
            CAN = byte.Parse(linea);


            for (K = 1; K <= CAN; K++)
            {
                Console.WriteLine("DIGITE UN NUMERO: "); linea = Console.ReadLine();
                NUM = int.Parse(linea);
                SUM += NUM;
            }

            Console.WriteLine("SUMA TOTAL ES: " + SUM);
            Console.WriteLine("MEDIA ARITMETICA: " + SUM / CAN);
        }
    }
}
