using System;

namespace Promedios
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nombres = { "Tanjiro", "Nezuko", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176 };
            double[] dist = new double[7];

            double total = 0;
            total += estatura[0];
            total += estatura[1];
            total += estatura[2];
            total += estatura[3];
            total += estatura[4];
            total += estatura[5];
            total += estatura[6];
            double promedio = total / 7;
            Console.WriteLine("El promedio de las estaturas es:  " + promedio);

            for (int i = 0; i < dist.Length; i++)
            {
                dist[i] = Math.Sqrt((estatura[i] - promedio) * (estatura[i] - promedio)) + (estatura[i] - promedio) * (estatura[i] - promedio);
            }

            double totalDist = 0;
            totalDist += dist[0];
            totalDist += dist[1];
            totalDist += dist[2];
            totalDist += dist[3];
            totalDist += dist[4];
            totalDist += dist[5];
            totalDist += dist[6];
            double promedioDist = totalDist/ 7;
            Console.WriteLine("El promedio de las distancias entre las estaturas y el promedio de estaturas es: " + promedioDist);
        }
    }
}
