using System;

namespace Caja_compensación
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.WriteLine("Para saber su tarifa en 2020:");
            Console.WriteLine("Ingrese su salario: ");
            int s = int.Parse(Console.ReadLine());

            //Cálculo
            double smmlv = s / 877803;

            if (smmlv <= 2)
            {
                Console.WriteLine("Tarifa A");
            }
            else if (2 < smmlv && smmlv <= 4)
            {
                Console.WriteLine("Tarifa B");
            }
            else
            {
                Console.WriteLine("Tarifa C");
            }
        }
    }
}
