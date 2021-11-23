using System;

namespace FORMATOS_DE_SALIDA
{
    class Program
    {
        static void Main(string[] args)
        {
            Double BASE, ALTURA, RESUL;

            string linea;

            Console.WriteLine("DIGITE LA BASE: "); linea = Console.ReadLine();

            BASE = Double.Parse(linea);

            Console.WriteLine("DIGITE LA ALTURA"); linea = Console.ReadLine();

            ALTURA = Double.Parse(linea);

            RESUL = (BASE * ALTURA) / 2;

            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL));
            
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", RESUL));
            
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", RESUL));
            
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", RESUL));
            
            Console.WriteLine();
            
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
            
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}", DateTime.Now));
            
        }
    }
}
