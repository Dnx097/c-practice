using System;

namespace VERIFICACION_DE_UNA_CLAVE_3_OPORTUNIDADES
{
    class Program
    {
        static void Main(string[] args)
        {

            //el CICLO WHILE, FUNCIONA DE LA SIGUIENTE FORMA:

            //do
            //{

            //    Lo QUE QUIERO QUE HAGA
            //      var ++ (DENTRO DE LO QUE QUIERO QUE HAGA VA LA SUMA RESTA U OPERACION DEL ITERADOR)

            //} while(CONDICION QUE DEBE CUMPLIRSE PARA QUE EL CICLO SE DETENGA);


            String PASS;
            int NUMI, I;
            NUMI = 0; I = 0;
            do
            {
                Console.WriteLine("DIGITE LA CLAVE: "); PASS = Console.ReadLine();
                if (PASS.ToUpper() == "CONTRASEÑA")
                {
                    I = 1;
                }
                else
                {
                    NUMI++;
                }
            } while ((NUMI < 3) && (I == 0));

            if (I == 1)
            {
                Console.WriteLine("HA INICIADO SESION");
            }
            else
            {
                Console.WriteLine("HA EXEDIDO EL NUMERO DE INTENTOS");
            }


        }
    }
}
