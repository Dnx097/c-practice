using System;

namespace TARIFA_TELEFONICA
{
    class Program
    {
        static void Main(string[] args)
        {
            int CNKV;

            Double TOT, COSKV;
            COSKV = 0;

            String linea;

            Console.WriteLine("ESCRIBA LA CANTIDAD DE KILIVATIOS"); linea = Console.ReadLine();

            CNKV = int.Parse(linea);
            if(CNKV <= 1000)
            {
                COSKV = 0.14;
            }
            if ((CNKV > 1000) & (CNKV <= 1800))
            {
                COSKV = 0.12;
            }
            if (CNKV > 1800)
            {
                COSKV = 0.8;
            }

            TOT = CNKV * COSKV;

            Console.Write("EL VALOR A PAGAR ES: " + TOT);
        }
    }
}
