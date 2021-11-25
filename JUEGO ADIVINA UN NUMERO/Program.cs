using System;

namespace JUEGO_ADIVINA_UN_NUMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            const int OPOR = 4;

            int NUM, ADI;

            Byte I, SW;

            String linea;

            /*GENERAR NUMERO DEL 1 AL 20*/

            Random RAN = new Random();

            do
            {
                NUM = Convert.ToInt32(RAN.Next(100));

            } while (!(NUM >= 1) & (NUM <= 20));
            //PROCESO
            I = 1;
            SW = 0;

            do
            {
                Console.Write("PIENSA QUE NUMERO SERÁ "); linea = Console.ReadLine();
                ADI = int.Parse(linea);

                if (ADI == NUM)
                {
                    Console.WriteLine("ADIVINASTE, ERES GENIAL");
                }
                else
                {
                    if (ADI > NUM)
                    {
                        Console.WriteLine("TE PASASTE");
                    }
                    else
                    {
                        Console.WriteLine("ESTAS BAJO");
                    }


                }

                I++;

            } while ( (I <= OPOR) & (SW == 0));

            if (SW == 0)
            {
                Console.Write("EL NUMERO FUE: " + NUM);
            }
        }
    }
}
