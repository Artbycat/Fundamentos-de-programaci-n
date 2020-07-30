using System;
using System.Threading;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.Write("Ingrese el numero de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string nombreMax = "nombreMax";
            string nombreMin = "nombreMin";


            while (i < n)
            {
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                
                if (edad > max)
                {
                    max = edad;
                    nombreMax = nombre;
                }
                if (edad < min)
                { 
                    min = edad;
                    nombreMin = nombre;
                }
                total += edad;
                i++;
                // if (i == 0){max = edad;min = edad;}
            }
            double promedio = total / n;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mayor: " + max + " " + nombreMax);
            Console.WriteLine("Menor: " + min + " " + nombreMin);
           
        }
    }
}
