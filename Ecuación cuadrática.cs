using System;

namespace Cuadrática
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.WriteLine("Para resolver una ecuación cuadrática:");
            Console.Write("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            //Operaciones matemáticas
            double discrim = (b * b) - (4 * a * c);
            
            //Condicional
            if (discrim == 0)
            {
                double solutionPositive = (-b) / (2 * a);
                
                Console.WriteLine("La solución es única.");
                Console.WriteLine("Solucion: " + solutionPositive);
            }
            else if(discrim > 0)
            {
                double solutionPositive = ((-b) + Math.Sqrt(discrim)) / (2 * a);
                double solutionNegative = ((-b) - Math.Sqrt(discrim)) / (2 * a);
                
                Console.WriteLine("Existen dos soluciones.");
                Console.WriteLine("Solucion(es): " + solutionPositive + " y " + solutionNegative);
            }
            else
            {
                Console.WriteLine("No hay solución.");
            }
           
           
        }
    }
}
