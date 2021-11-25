using System;

namespace SERIE_DE_UN_NUMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, K, F; // K ES UN ITERADOR & F TAMBIEN SERÁ UN ITERADOR
            long FAC; //TIPO DE DATO LONG, VARIANTE DE INT DE 64 BITS
            double RESUL = 0; // DOUBLE SE USA PARA DECLARAR NUMEROS RELES CON COMA FLOTANTE DE  64 BITS
            String linea;

            Console.WriteLine("INSERTE UN NUMERO"); linea = Console.ReadLine();
            NUM = int.Parse(linea);

            for (K = 1; K <= NUM; K++)
            {
                FAC = 1;
                for (F = 1; F <= K; F++)
                {
                    FAC = FAC * FAC;
                }

                RESUL = RESUL + (K / FAC);
            } 
            Console.WriteLine("EL RESULTADO DE LA SERIE ES:  " + RESUL);
        }
    }
}
