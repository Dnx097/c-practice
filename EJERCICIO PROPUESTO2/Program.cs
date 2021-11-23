using System;

namespace EJERCICIO_PROPUESTO2
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOM1;

            Console.WriteLine("ESCRIBA SU NOMBRE"); NOM1 = Console.ReadLine();

            if (NOM1 == "DAVID")
            {
                Console.Write("HOLA");
            }
            else
            {
                Console.Write("NO TE CONOZCO ALA");
            }
        }
    }
}
