using System;

namespace TABLA_DE_MULTIPLICAR_CON_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, I, RESUL;
            string linea;

            Console.Write("DIGITE UN NÚMERO: "); linea = Console.ReadLine();

            NUM = int.Parse(linea);
            I = 1;

            // ESTRUCTURA DEL CICLO WHILE, A DIFERENCIA DEL CICLO FOR, EL CICLO WHILE HACE TODO LO QUE ESTE DENTRO DE LAS LLAVES, PERO EN ORDEN

                //while (I <= 12) CONDICION DEL CICLO, SE DETIENE HASTA QUE...
                //{
                //    RESUL = NUM * I;        

                //    Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);
                //    I = I + 1;        AUMENTO DEL CICLO
                //}


            while (I <= 12)
            {
                RESUL = NUM * I;

                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);

                I = I + 1;
            }

            Console.WriteLine("PULSE UNA TECLA");
        }
    }
}
