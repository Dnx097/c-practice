using System;

namespace MOVIMIENTO_CARACTER_POR_CARACTER_EN_VERICAL
{
    class Program
    {

        //String value = "This is a string.";
        //int startIndex = 5;
        //int length = 2;
        //String substring = value.Substring(startIndex, length);
        //Console.WriteLine(substring);

        // The example displays the following output:
        //       is


        public static String Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        //

        static void Main(string[] args)
        {
            string NOM;
            string CAR;
            int K = 0;
            int P = 0;
            int CI = 0;

            Console.Write("SU NOMBRE ES: "); NOM = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(25, 1);
            Console.Write(NOM);

            CI = 25;

            NOM = NOM.ToUpper();

            for (P = 1; P <= NOM.Length; P++)
            {
                CAR = Mid(NOM, P - 1, 1);
                for (K = 1; K <= 22; K++)
                {
                    Console.SetCursorPosition(CI, K);
                    Console.Write(CAR);

                    //SET STOP
                    System.Threading.Thread.Sleep(50);
                    Console.SetCursorPosition(CI, K);
                    Console.Write(" ");
                }

                Console.SetCursorPosition(CI, K);
                Console.Write(CAR);
                CI = CI + 1;
            }

            Console.WriteLine();
        }

    }
}
