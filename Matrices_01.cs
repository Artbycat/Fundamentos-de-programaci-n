using System;

namespace Matrices_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "o", "x" };
            int n = 10;
            int m = 15;
            int xCount = 0, oCount = 0, guion = 0;
            double xPercent = 0, oPercent = 0, guionPercent = 0;

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
                    Console.Write("|" + tablero[i,j]);
                }
                Console.Write("|\n");
            }

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if (tablero[i, j] == "-") guion++;
                    if (tablero[i, j] == "x") xCount++;
                    if (tablero[i, j] == "o") oCount++;
                }
            }

            for (int i = 0; i < tablero.GetLength(0)-2; i++)
            {
                for (int j = 0; j < tablero.GetLength(1)-2; j++)
                {
                    if (tablero[i, j] == "o" && tablero[i, j + 1] == "o"&&tablero[i,j+2]=="o")
                    {
                        salida[i, j] = "2";
                        salida[i, j + 1] = "2";
                        salida[i, j + 2] = "2";                     
                    }
                    if (tablero[i, j] == "o" && tablero[i + 1, j] == "o" && tablero[i + 2, j] == "o")
                    {
                        salida[i, j] = "2";
                        salida[i + 1, j] = "2";
                        salida[i + 2, j] = "2";
                    }
                    if (tablero[i, j] == "x" && tablero[i, j + 1] == "x" && tablero[i, j + 2] == "x")
                    {
                        salida[i, j] = "1";
                        salida[i, j + 1] = "1";
                        salida[i, j + 2] = "1";
                    }
                    if (tablero[i, j] == "x" && tablero[i + 1, j] == "x" && tablero[i + 2, j] == "x")
                    {
                        salida[i, j] = "1";
                        salida[i + 1, j] = "1";
                        salida[i + 2, j] = "1";
                    }
                }
            }
            xPercent = (xCount * 100) / (n*m);
            oPercent = (oCount * 100) / (n*m);
            guionPercent = (guion * 100) / (n*m);

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
            Console.WriteLine("El porcentale de x es: " + xPercent + "%" + "\nEl porcentaje de o es: " + oPercent + "%" + "\nEl porcentaje de - es: " + guionPercent + "%");
        }
    }
}
