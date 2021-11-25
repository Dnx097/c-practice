using System;

namespace MOVIMIENTO_POR_CARACTER_HORIZONTAL
{
    class Program
    {
        //LO QUE ESTAMOS DECLRANDO ES UN METODO QUE NOS YUDA A OBTENER 

        public static String Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        static void Main(string[] args)
        {
            string NOM; //STRING NOMBRE
            string CAR; //STRING CARCTERES
            int K = 0; //ITERADOR
            int P = 0; //ITERADOR
            int CI = 0; // DONDE ALMCENAREMOS EL NUMERO DE CARACTERES QUE TIENE EL STRING (.LENGTH)
            int CF = 0; //NUMERO DE ESPACIOS ANTES DE ESCRIBIR EL NOMBRE

            Console.Write("SU NOMBRE ES: ");
            NOM = Console.ReadLine();


            CI = NOM.Length; //CI VA A SER IGUAL A LA LONGITUD DEL NOMBRE (A CUANTAS LETRAS TIENE EL NOMBRE)
            CF = 70;

            NOM = NOM.ToUpper(); //EL STRING LO PASAMOS A MAYÚSCULAS


            //EL CICLO, ITERA DESDE EL NUMERO DE CARACTERES QUE TIENE EL NOMBRE, PERO EST VEZ VA RESTANDO DE 1 EN UNO HASTA QUE SOLO QUEDE UN CARACTER PARA CICLAR
            for (P = CI; P >= 1; P--)
            {
                //ACA DECLARAMOS QUE CAR = AL METODO QUE SE ESTABLECIÓ AL PRINCIPIO DEL EJERCICIO
                CAR = Mid(NOM, P - 1, 1);
                //HACEMOS UN CICLO ANIDADO QUE LO QUE HACE ES ORGANIZAR LA POSICIÓN DE CADA CARACTER EN CONSOLA CON SET CURSOT POSITION
                for (K = CI; K <= CF; K++)
                {
                    Console.SetCursorPosition(K, 12);
                    Console.Write(" " + CAR);

                    //PONER UNA PAUSA PARA QUE SE VEA COMO ITERA LETRA POR LETRA

                    System.Threading.Thread.Sleep(50);
                }

                //INCLUIMOS LA RESTA A CADA ESPACIO EN CONSOLA Y A CADA NUMERO DE LONGITUD DEL NOMBRES

                CF = CF - 1;
                CI = CI - 1;

            }

            Console.WriteLine();
        }
    }
}
