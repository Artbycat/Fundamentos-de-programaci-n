using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.WriteLine("Para calcular su IMC:");
            Console.Write("Ingrese su estatura en CENTÍMETROS: ");
            double e = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su peso en KILOGRAMOS: ");
            double kg = double.Parse(Console.ReadLine());

            //Conversion a metros
            double eMetros = (e) / 100;

            //Calculo imc
            double eMetrosSq = eMetros * eMetros;
            double IMC = (kg / eMetrosSq);

            //Informe del IMC
            Console.WriteLine("Su IMC es de: " + IMC);

            //Condicional para informe
            if (IMC < 18.5)
            {
                Console.WriteLine("Usted tiene un peso inferior al normal.");
            }
            else if (18.5 <= IMC && IMC <= 24.9)
            {
                Console.WriteLine("Usted tiene un peso normal.");
            }
            else if (25 <= IMC && IMC <= 29.9)
            {
                Console.WriteLine("Usted tiene un peso superior al normal.");
            }
            else if (30 <= IMC)
            {
                Console.WriteLine("Usted tiene obesidad.");
            }

        }
    }
}
