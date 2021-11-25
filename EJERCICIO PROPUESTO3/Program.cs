using System;

namespace EJERCICIO_PROPUESTO3
{
    class Program
    {
        //Crear un programa que muestre las letras de la Z(mayúscula) a la A(mayúscula,
        //descendiendo).
        //1. Abrir un nuevo Proyecto
        //2. Seleccione Aplicación de Consola

        static void Main(string[] args)
        {
            int I; //ITERADOR

            Console.WriteLine("ABECEDARIO DESCENDENTE");
            Console.WriteLine();

            // I  = 90 POR QUE VAMOS A TRANSFORMAR CADA VALOR (DEL 90 AL 65) EN ASCII, LO CUAL VA A IMPRIMIR EL ABECEDARIO
            //SI EL ABECEDARIO FUESE EN ORDEN ASCENDENTE (I = 65; I <= 90; I++) E IMPRIMIRIA DE LA A HASTA LA Z
            for (I = 90; I >= 65; I--)
            {
                Console.WriteLine("LETRA: " + Convert.ToString((Char)I));
            }

            Console.WriteLine();
        }
    }
}
