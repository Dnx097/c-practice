using System;

namespace ESTADO_CIVIL
{
    class Program
    {
        static void Main(string[] args)
        {
            char ECIVIL;

            string linea;

            Console.WriteLine("DIGITE C,S,V,D"); linea = Console.ReadLine();

            ECIVIL = char.Parse(linea);

            switch (ECIVIL)
            {
                case 'C':
                    Console.WriteLine("CASADO");
                    break;
                case 'S':
                    Console.WriteLine("SOLTERO");
                    break;
                case 'V':
                    Console.WriteLine("VIUDO");
                    break;
                case 'D':
                    Console.WriteLine("DIVORSIADO");
                    break;
                default:
                    Console.WriteLine("NO SIRVIÓ NI PA SOLTERO?");
                    break;
            }
        }
    }
}
