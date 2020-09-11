using System;

namespace Matrices_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "o", "x" };
            int n = 10;
            int m = 15;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }

            Console.WriteLine("ENTRADA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }
            Console.WriteLine("Ingrese la fila de la matriz.");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la columna de la matriz.");
            int columna = int.Parse(Console.ReadLine());

            if (tablero[fila, columna] == "-") salida[fila, columna] = "X";

            else Console.WriteLine("Esta posición está ocupada");

            Console.WriteLine("\nSALIDA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write("\n");
        }
    }
}
