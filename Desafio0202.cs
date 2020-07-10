using System;

namespace Desafío0202
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Para hallar los catetos y el ángulo interno restante de un triángulo rectángulo:");
            Console.Write("Ingrese T: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());

            double aRad = a * Math.PI / 180;
            double y = t * Math.Sin(aRad);
            double z = (t * Math.Cos(aRad));

            double c = 90 - a;

            Console.WriteLine("y: " + y);
            Console.WriteLine("z: " + z);
            Console.WriteLine("El ángulo interno restante es: " + c);

        }
    }
}
