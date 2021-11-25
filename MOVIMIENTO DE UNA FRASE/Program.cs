using System;

namespace MOVIMIENTO_DE_UNA_FRASE
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS VARIABLES
            string NOM;
            Byte K; // TIPO DE DATO DE 8 BITS CON SIGNO POR EJ: -128 A 128

            Console.Write("SU NOMBRE ES: "); NOM = Console.ReadLine();

            //LO QUE HACE ESTE SISTEMA ES TOMAR UN NOMBRE Y ANTES DE PLASMARLO EN PANTALLA MOVER EL NOMBRE EN LA CONSOLA

            for (K = 1; K <= 70; K++)
            {
                //SET CURSOR POSITION SIRVE PARA MOVER EL CURSOR EL LA CONSOLA, BASICAMENTE ES MOVER ESPACIOS EN LA CONSOLA
                Console.SetCursorPosition(K, 1); 
                Console.Write(" " + NOM);
                //HACER UNA PAUSA

                //ESTO NOS SIRVE PARA RETARDAR EL MOVIMIENTO EN LA CONSOLA DE LO QUE SE ESTA EN EL CICLO FOR
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
