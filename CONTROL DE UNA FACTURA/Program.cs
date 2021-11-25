using System;

namespace CONTROL_DE_UNA_FACTURA
{
    class Program
    {
        static void Main(string[] args)
        {
            string PROD;
            int CAN = 0;
            int FI = 0;
            Double PRE = 0;
            Double TOT = 0;
            Double PAGA = 0;
            Char OP;
            string linea;
            FI = 6;
            PAGA = 0;
            Console.SetCursorPosition(5, 4);
            Console.Write("PRODUCTO CANTIDAD PRECIO TOTAL");

            do
            {
                Console.SetCursorPosition(5, FI);
                PROD = Console.ReadLine();

                Console.SetCursorPosition(17, FI);
                linea = Console.ReadLine();
                CAN = int.Parse(linea);
                Console.SetCursorPosition(27, FI);
                linea = Console.ReadLine();
                PRE = int.Parse(linea);
                TOT = CAN * PRE;
                Console.SetCursorPosition(33, FI);
                Console.Write(TOT);
                PAGA = PAGA + TOT;
                FI = FI + 1;
                Console.SetCursorPosition(30, 23);
                Console.Write("OTRO PRODUCTO? S/N ");
                linea = Console.ReadLine();
                OP = char.Parse(linea);
            } while (OP.ToString().Contains("s"));

            Console.WriteLine("TOTAL A PGAR" + TOT);
        }
    }
}
