using System;

namespace Desafío0203
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.WriteLine("Para hallar un cateto, la hipotenusa y el ángulo interno restante de un triángulo rectángulo:");
            Console.Write("Ingrese Z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            //operaciones matemáticas
            //Angulo
            double a = 90 - c;
            //Conversion a radianes
            double cRad = c * Math.PI / 180;
            double aRad = a * Math.PI / 180;
            //hallar cateto, hipotenusa.
            double y = (z * Math.Sin(aRad)) / (Math.Sin(cRad));
            double t = (y) / (Math.Sin(aRad));
            

            //consola shows
            Console.WriteLine("Hipotenusa: " + t);
            Console.WriteLine("y: " + y);
            Console.WriteLine("El ángulo interno restante es: " + a);
        }
    }
}
