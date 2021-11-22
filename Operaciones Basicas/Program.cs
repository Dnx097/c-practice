using System;

namespace Operaciones_Basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, RESUL;

            String linea;

            Console.WriteLine("ESCRIBA PRIMER NUMERO");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.WriteLine("ESCRIBA EL SEGUNDO NUMERO");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            RESUL = NUM1 + NUM2;
            Console.WriteLine("EL RESULTADO ES {0}:", RESUL);
            RESUL = NUM1 - NUM2;
            Console.WriteLine("LA RESTA ES: {0} - {1} = {2} ", NUM1, NUM2, RESUL);
            RESUL = NUM1 * NUM2;
            Console.WriteLine("LA MULTIPLICACION ES {0} * {1} = {2}", NUM1, NUM2, RESUL);
            RESUL = NUM1 / NUM2;
            Console.WriteLine("EL RESULTADO DE LA DIVISION ES {0} / {1} = {2}", NUM2, NUM1, RESUL);
        }
    }
}
