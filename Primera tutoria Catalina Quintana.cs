using System;

namespace Primer_Reto
{
    public class Program
    {
        static void Main(string[] args)
        {

			{
				// Entrada del usuario de la variable X1
				Console.Write("Ingrese X1: ");
				double x1 = double.Parse(Console.ReadLine());

				// Entrada del usuario de la variable Y1
				Console.Write("Ingrese Y1: ");
				double y1 = double.Parse(Console.ReadLine());

				Console.Write("Ingrese X2: ");
				double x2 = double.Parse(Console.ReadLine());

				Console.Write("Ingrese Y2: ");
				double y2 = double.Parse(Console.ReadLine());

				double m = (y2 - y1) / (x2 - x1);
				double b = y1 - (m * x1);
				double a = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
				double A = Math.Sqrt(a);

				Console.WriteLine("La pendiente es: " + m);
				Console.WriteLine("El intercepto es: " + b);
				Console.WriteLine("La distancia es: " + A);


			}
		}
	}
}
