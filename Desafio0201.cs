using System;

namespace Desafio0201
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.WriteLine("Para hallar la hipotenusa y los ángulos internos de un triángulo rectángulo:");
            Console.Write("Ingrese Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Ingrese Z: ");
            double z = double.Parse(Console.ReadLine());
            
            //hipotenusa
            double t = (y) * (y) + (z) * (z);
            double T = Math.Sqrt(t);
        
            Console.WriteLine("La hipotenusa del triángulo es: " + T);
            //ángulos internos
            double c = Math.Atan((z) / (y));
            double cGrados = c * (180 / Math.PI);
            double a = Math.Atan((y) / (z));
            double aGrados = a * (180 / Math.PI);

            Console.WriteLine("Los ángulos internos del triángulo son: " + cGrados +"y " + aGrados);
        }
    }
}
