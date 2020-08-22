using System;

namespace Sumatorias
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            double result = 0, result1 = 0;
            Console.WriteLine("Ingrese el valor de x: ");
            double x = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
               result += (Math.Pow(x, i))/(Factorial(i));
               result1 += ((Math.Pow(-1, i)) / (Factorial((2 * i) + 1))) * (Math.Pow(x, ((2 * i) + 1)));
            }
            Console.WriteLine("Resultado: " + result);
            Console.WriteLine("Resultado Sin: " + result1);
        }
        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
