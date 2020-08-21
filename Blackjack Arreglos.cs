using System;

namespace Blackjack_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int carta = 2, total = 0, puntuacion = 0, jugador = 1, jugadores = 0, ganador = 0, jugadorWin = 0, jugadoresAct = 0;
            Random aleatorio = new Random();
            string cont = "";

            Console.WriteLine("Ingrese el número de jugadores: ");
            jugadores = int.Parse(Console.ReadLine());
            jugadoresAct = jugadores;
            int[] puntuacion1 = new int[jugadores];

            while (jugadores < 2 || jugadores > 5)
            {
                Console.WriteLine("Ingrese un número válido de jugadores.");
                jugadores = int.Parse(Console.ReadLine());
            }
            string[] nombres = new string[jugadores];
            
            for ( int i = 0; i< nombres.Length; i++)
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombres[i] = Console.ReadLine();
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                while (jugador < jugadores + 1)
                {
                    Console.WriteLine("¿Iniciar el juego? (s/n)");
                    cont = Console.ReadLine();
                    while (cont != "s" && cont != "n")
                    {
                        Console.WriteLine("Ingrese una entrada válida.");
                        cont = Console.ReadLine();
                    }
                    Console.WriteLine("Jugador: " + jugador);
                    puntuacion = aleatorio.Next(1, 21);
                    total = puntuacion;
                    Console.WriteLine("Cartas: " + carta + "  Puntuación: " + puntuacion + "  Total: " + total);
                    while (cont == "s")
                    {
                        puntuacion = aleatorio.Next(1, 11);
                        Console.WriteLine("¿Continuar? (s/n)");
                        cont = Console.ReadLine();
                        while (cont != "s" && cont != "n")
                        {
                            Console.WriteLine("Ingrese una entrada válida.");
                            cont = Console.ReadLine();
                        }
                        if (cont == "s")
                        {
                            carta = carta++;
                            total += puntuacion;
                            Console.WriteLine("Cartas: " + carta + "  Puntuación: " + puntuacion + "  Total: " + total);
                        }
                        if (total > 21)
                        {
                            total = 0;
                            Console.WriteLine("Ha perdido el juego.");
                            cont = "n";
                        }
                        else if (total == 21)
                        {
                            Console.WriteLine("Ha ganado el juego.");
                            cont = "n";
                        }
                        else if (cont == "n")
                        {
                            Console.WriteLine("Gracias por jugar.");

                        }
                        Console.WriteLine("Su total fue de: " + total);
                        puntuacion1 = total;
                    }
                    jugador += 1;
                    if (total > ganador)
                    {
                        ganador = total;
                        if (jugador > jugadorWin)
                        {
                            jugadorWin = jugador;
                        }
                    }
                    if (jugador >= jugadores) break;
                }       
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i] + ": " + puntuacion1[i]);
            }

            for (int j = 0; j < nombres.Length - 1; j++)
            {
                for (int i = 0; i < nombres.Length - 1; i++)
                {
                    if (puntuacion1[i] < puntuacion1[i + 1])
                    {
                        int temp = puntuacion1[i];
                        puntuacion1[i] = puntuacion1[i + 1];
                        puntuacion1[i + 1] = temp;

                        string temp1 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = temp1;
                    }
                }
            }
            Console.WriteLine("El ganador es: " + nombres[0]);
            Console.WriteLine("El segundo lugar es:  " + nombres[1]);
        }
    }    
}
