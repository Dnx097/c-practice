using System;

namespace TRIANGULOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int LADO1, LADO2, LADO3;

            String linea;

            Console.Write("DIFITE LADO 1: "); linea = Console.ReadLine();
            LADO1 = int.Parse(linea);
            Console.WriteLine("DIGITE LADO 2: "); linea = Console.ReadLine();
            LADO2 = int.Parse(linea);
            Console.WriteLine("DIGITE LADO 3: "); linea = Console.ReadLine();
            LADO3 = int.Parse(linea);

            if ((LADO1 == LADO2) & (LADO2 == LADO3))
            {
                Console.WriteLine("TRIANGULO EQUILATERO. TODOS IGUALES");
            }
            else
            {
                if ((LADO1 != LADO2) & (LADO1 != LADO3) & (LADO2 != LADO3))
                {
                    Console.WriteLine("TRIANGULO ESCLENO. NINGUNO IGUAL");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ISOSCELES. DOS IGUALES");
                }
                

            }
        }
    }
}
