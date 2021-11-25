using System;

namespace SUCESION_DE_N_CUADROS
{
    class Program
    {
        static void Main(string[] args)
        {
            int CAN, F, C, T, FI, FF, CI, CF;
            string linea;

            Console.Write("DIGITE UN NUMERO DEL 1 AL 10: "); linea = Console.ReadLine();

            CAN = Byte.Parse(linea);

            FI = 2; 
            FF = 22;
            CI = 2;
            CF = 77;

            for (T = 1; T <= CAN; T++)
            {
                for (F = CI; F <= CF ; F++)
                {
                    Console.SetCursorPosition(F, FF); Console.Write("x");
                    Console.SetCursorPosition(F, FI); Console.Write("X");
                }
                for (C = FI; C <= FF; C++)
                {
                    Console.SetCursorPosition(CI, C); Console.Write("X");
                    Console.SetCursorPosition(CF, C); Console.Write("X");
                }
                FI = FI + 1;
                FF = FF - 1;
                CI = CI + 1;
                CF = CF - 1;
            }
            Console.WriteLine();
            Console.SetCursorPosition(25, 24); Console.Write("PULSE UN TECLA: ");
            Console.ReadLine();
        }
    }
}
