using System;

namespace Arreglos_electric_boogaloo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Tanjiro", "Nezuko", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };
            double[] dist = new double[estatura.Length];
            double total = 0;

            for (int i = 0; i < estatura.Length; i++)
            {
                total += estatura[i];
            }           
            double promedio = total / (estatura.Length);
            Console.WriteLine("El promedio de las estaturas es:  " + promedio);
            for (int i = 0; i < dist.Length; i++)
            {
                dist[i] = Math.Sqrt((estatura[i] - promedio) * (estatura[i] - promedio)) + (estatura[i] - promedio) * (estatura[i] - promedio);
            }           
            double totalDist = 0;
            for (int i = 0; i < dist.Length; i++)
            {
                totalDist += dist[i];
            }
            double promedioDist = totalDist / (dist.Length);
            Console.WriteLine("El promedio de las distancias entre las estaturas y el promedio de estaturas es: " + promedioDist);
            for (int j = 0; j < dist.Length; j++)
            {
                for (int i = 0; i < dist.Length - 1; i++)
                {
                    if (dist[i] > dist[i + 1])
                    {
                        double tmp = dist[i];
                        dist[i] = dist[i + 1];
                        dist[i + 1] = tmp;
                        string tmp1 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp1;
                    }
                }
            }
            Console.WriteLine("El más cercano al promedio es: " + nombres[0]);
        }
    }
}
