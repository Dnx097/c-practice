using System;

namespace DIA_DE_LA_SEMANA
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM;

            string linea;

            Console.WriteLine("DIAS DE LA SEMANA");

            Console.WriteLine();

            Console.Write("INGRESE UN NUMERO DEL 1 AL 7");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);

            switch (NUM)
            {
                case 1:
                    Console.WriteLine("EL NUMERO QUE INGRESO CORRESPONDE AL DÍA DOMINGO");
                    break;

                case 2:
                    Console.WriteLine("EL NUMERO QUE INGRESO CORRESPONDE AL DÍA LUNES");
                    break;
                case 3:
                    Console.WriteLine("EL NUMERO QUE INGRESO CORRESPONDE AL DÍA MARTES");
                    break;
                case 4:
                    Console.WriteLine("EL NUMERO QUE INGRESO CORRESPONDE AL DÍA MIERCOLES");
                    break;
                case 5:
                    Console.WriteLine("EL NUMERO QUE INGRESO CORRESPONDE AL DÍA JUEVES");
                    break;
                case 6:
                    Console.WriteLine("EL NUMERO QUE INGRESO CORRESPONDE AL DÍA VIERNES");
                    break;
                case 7:
                    Console.WriteLine("EL NUMERO QUE INGRESO CORRESPONDE AL DÍA SABADO");
                    break;
                default:
                    Console.WriteLine("LA SEMANA SOLO TIENE 7 DIAS ESCRIBA ALGO QUE SIRVA");
                    break;
            }
        }
    }
}
