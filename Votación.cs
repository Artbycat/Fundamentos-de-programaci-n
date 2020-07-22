using System;

namespace Votación
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario
            Console.WriteLine("Ingrese los votantes del partido A:  ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los votantes del partido B:  ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los votos en blanco:  ");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los votos anulados:  ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la población total:  ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de la población que es mayor de edad:  ");
            double p = double.Parse(Console.ReadLine());

            //variables necesarias
            int votantes = a + b + blanco + anulados;
            int mayores = (int)(n * (p / 100));
            int abstinencia = (mayores) - votantes;
            //booleanos
            bool A = anulados < ((a + b) * 0.30);
            bool B = blanco < (a + b);
            bool C = abstinencia < votantes;
            bool ganador = a < b;

            //Output
            Console.WriteLine("Total mayores de edad: " + mayores);
            Console.WriteLine("Total votantes: " + votantes + " Abstinencia: " + abstinencia);

            //Condicionales
            if ((A || B) && C)
            {
                if (ganador) Console.WriteLine("El ganador es B.");
                else Console.WriteLine("El ganador es A.");
            }
            else Console.WriteLine("La elección debe repetirse.");

           
        }
            

    }
}
