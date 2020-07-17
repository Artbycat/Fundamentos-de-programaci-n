using System;

namespace Cuota_moderadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.WriteLine("Para saber su cuota moderadora en 2020:");
            Console.WriteLine("Ingrese su salario: ");
            int s = int.Parse(Console.ReadLine());

            //Cálculo
            double smmlv = s / 877803;

            if (smmlv <= 2)
            {
                Console.WriteLine("Cuota A: usted debe pagar $3.400");
            }
            else if (2 < smmlv && smmlv <= 5)
            {
                Console.WriteLine("Cuota B: usted debe pagar $13.500");
            }
            else
            {
                Console.WriteLine("Cuota C: usted debe pagar $35.600");
            }
        }
    }
}
