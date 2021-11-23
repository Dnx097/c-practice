using System;

namespace BONO_DEL_EMPLEADO_POR_HIJO
{
    class Program
    {
        static void Main(string[] args)
        {
            Double SUELDO, ARECIBIR;

            int NHIJO, BONO;

            string NOM, linea;

            Console.WriteLine("NOMBRE EMPLEADO: "); NOM = Console.ReadLine();
            Console.WriteLine("SUELDO EMPLEADO: "); linea = Console.ReadLine();

            SUELDO = Double.Parse(linea);

            Console.WriteLine("NUMERO DE HIJOS"); linea = Console.ReadLine();

            NHIJO = int.Parse(linea);

            if (NHIJO >= 3) { BONO = NHIJO * 10; } else { BONO = NHIJO * 20; }

            ARECIBIR = SUELDO + BONO;

            Console.WriteLine( NOM + " RECIBE: " + String.Format( "{0:C}", ARECIBIR ));

        }
    }
}
