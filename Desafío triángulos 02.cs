using System;

namespace Desafío_triángulos_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.Write("Ingrese d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese Y: ");
            double y = double.Parse(Console.ReadLine());

            //operaciones matemáticas
            double e = 180 - d - b;
            double c = 180 - e;
            double a = 90 - c;
            double aRad = a * Math.PI / 180;
            double cRad = c * Math.PI / 180;
            double z = (y * Math.Sin(cRad)) / (Math.Sin(aRad));

            Console.WriteLine("z: " + z);


        }
    }
}
