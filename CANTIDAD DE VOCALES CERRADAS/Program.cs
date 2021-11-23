using Microsoft.VisualBasic;
using System;

namespace CANTIDAD_DE_VOCALES_CERRADAS
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOM;
            int K, SUM;
            string LE;

            Console.WriteLine("DIGITE UNA FRASE: "); NOM = Console.ReadLine();

            SUM = 0;

            NOM = NOM.ToUpper();

            Console.WriteLine(NOM);

            for (K = 1; K < NOM.Length; K++)
            {
                LE = Mid(NOM, K, 1);

                if (LE.Contains("U") || LE.Contains("I"))
                {
                    SUM = SUM + 1;
                }

                Console.WriteLine("EXISTEN {0} VOCALES CERRADAS", SUM);



            }
        }

        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
           
 }
        public static string Mid(string param, int startIndex)
        {
            string result = param.Substring(startIndex);
            return result;
        }

    }
}
       
