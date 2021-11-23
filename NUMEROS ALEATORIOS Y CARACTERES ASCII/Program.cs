using System;

namespace NUMEROS_ALEATORIOS_Y_CARACTERES_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES

            byte CAN, K;

            int NUM;

            string linea;

            // IMPUT & READ

            Console.Write("CUANTOS NUMEROS"); linea = Console.ReadLine();

            CAN = byte.Parse(linea);

            // START ALEATORY GENERATOR

            Random RAN = new Random();

          // CICLO, PARA GENERAR ALEATORIAMENTE LOS NUMEROS

            for (K = 1; K <= CAN; K++)
            {
                NUM = Convert.ToInt32(RAN.Next(100));

                Console.WriteLine("GENERO EL: " + NUM);

                if ( (NUM > 0) & (NUM <256) )
                {
                    Console.WriteLine("EL CODIGO DEL: " + NUM + " ES " + Convert.ToString((char)NUM)); //Convert.ToString((char)NUM)) ESTO ES LO QUE CONVIERTE EL VALOR EN ASCII
                                                                                                                //VALOR NUMERICO ALMACENADO EN NUM
                }
            }
        }
    }
}
