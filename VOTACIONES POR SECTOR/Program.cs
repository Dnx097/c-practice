using System;

namespace VOTACIONES_POR_SECTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int CANN = 0;
            int CANS = 0;
            int CANC = 0;
            char OP;
            string ZONA, linea;
            CANN = 0;
            CANS = 0;
            CANC = 0;

            do
            {

                Console.WriteLine("QUE SECTOR NORTE, CENTRO, SUR: ");
                ZONA = Console.ReadLine();
                switch (ZONA.ToUpper())
                {
                    case "NORTE":
                        CANN = CANN + 1;
                        break;
                    case "CENTRO":
                        CANC = CANC + 1;
                        break;
                    case "SUR":
                        CANS = CANS + 1;
                        break;

                }

                Console.Write("HAY OTRA ERSONA S/N: ");
                linea = Console.ReadLine();
                OP = char.Parse(linea.ToUpper());

            } while (OP.ToString().Contains("S"));
            Console.WriteLine("DE LA ZONA NORTE: " + CANN);
            Console.WriteLine("DE LA ZONA CENTRO: " + CANC);
            Console.WriteLine("DE LA ZONA SUR: " + CANS);

        }
    }
}
