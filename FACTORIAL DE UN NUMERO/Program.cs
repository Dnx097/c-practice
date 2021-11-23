using System;

namespace FACTORIAL_DE_UN_NUMERO
{
    //FACTORIZAR UN NUMERO
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES

            byte NUM, K;
            long RESUL = 1;
            String linea;

            //CAPTURAR DATOS

            Console.Write("DIGITE UN NUMERO "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);

            //CICLO

            for (K = 2; K <= NUM; K++)
            {
                RESUL = RESUL * K;
            }

            Console.WriteLine("EL FACTORIAL ES: " + RESUL);

        }
    }
}
