using System;

namespace Desafío_triángulos_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.Write("Ingrese W: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese X: ");
            double x = double.Parse(Console.ReadLine());

            //operaciones matemáticas
            double dRad = d * Math.PI / 180;
            double z = w * (Math.Sin(dRad));
            double W = w * w;
            double Z = z * z;

            double y = (Math.Sqrt(W - Z)) - x;

            Console.WriteLine("y: " + y);
        }
    }
}
