using System;

namespace SUMA_NUMEROS_PARES_E_IMPARES
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte NUM, I;
            int SUMP = 0;
            int SUMI = 0;

            String linea;

            Console.Write("NUMERO MAXIMO"); linea = Console.ReadLine();
            NUM = Byte.Parse(linea);

            for (I = 1 ; I <= NUM; I += 2)
            {
                SUMP = SUMP + I;
               
            }
            for (I = 2; I <= NUM; I += 2)
            {
                SUMI = SUMI + I;
                

            }

            Console.WriteLine("TOTAL EN PARES:" + SUMP);
            Console.WriteLine("TOTAL EN IMPARES " + SUMI);

        }
    }
}
