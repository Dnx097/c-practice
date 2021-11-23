using System;

namespace Compra_en_restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CANV, CANH, CANP;

            double APAGAR;

            string linea;

            const double PRECIOB = 0.8;

            const double PRECIOH = 2;

            const double PRECIOP = 1.2;

            Console.WriteLine("CNTIDAD HAMBURGUESAS"); linea = Console.ReadLine();

            CANH = byte.Parse(linea);

            Console.WriteLine("CANTIDAD DE PAPAS"); linea = Console.ReadLine();

            CANP = byte.Parse(linea);

            Console.WriteLine("CANTIDAD DE BEBIDAS"); linea = Console.ReadLine();

            CANV = byte.Parse(linea);

            APAGAR = (CANH * PRECIOH) + (CANP * PRECIOP) + (CANV * PRECIOB);

            Console.WriteLine("EL VALOR A PAGAR ES:" + APAGAR);

        }
    }
}
