using System;

namespace EjercicioPropesto3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            string linea;

            Console.WriteLine("ESCRIBA UNA LETRA"); linea = Console.ReadLine();

            letra = char.Parse(linea);


            switch (letra)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("ES UN NUMERO");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("ES UNA VOCAL");
                    break;

                default:
                    Console.WriteLine("ES UNA CONSONANTE");
                    break;
            }
            

        }
    }
}
