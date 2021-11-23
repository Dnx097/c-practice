using System;

namespace SERIE_DE_FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CAN, K;
            int A, B, C;
            string linea;
            
            Console.Write("CUANTOS NÚMEROS: "); linea = Console.ReadLine();
            
            CAN = byte.Parse(linea);
            
            A = 1; B = 1;
            
            Console.Write(A + " " + B + " ");
            
            for (K = 3; K <= CAN; K++)
            {
                C = A + B;
                Console.Write(C + " ");
            
             //INTERCAMBIO DE VALORES
             
                A = B;

                B = C;
            }
            

        }
    }
}
