using System;

namespace Blackjack_multiplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int carta = 2, total = 0, puntuacion = 0, jugador = 1, jugadores = 0, ganador = 0, jugadorWin = 0;
            Random aleatorio = new Random();
            string cont = "";

            Console.WriteLine("Ingrese el número de jugadores: ");
            jugadores = int.Parse(Console.ReadLine());
            
            while (jugadores < 2 || jugadores > 5) 
            {
                Console.WriteLine("Ingrese un número válido de jugadores.");
                jugadores = int.Parse(Console.ReadLine());
            }

            while (jugador < jugadores + 1)
            {
                Console.WriteLine("¿Iniciar el juego? (s/n)");               
                cont = Console.ReadLine();                       
                while(cont != "s" && cont != "n")
                {
                    Console.WriteLine("Ingrese una entrada válida.");
                    cont = Console.ReadLine();
                }               
                Console.WriteLine("Jugador: " + jugador);
                puntuacion = aleatorio.Next(2, 21);
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
                  if (jugador >=jugadores) break;  
                }
            Console.Writeline("El ganador es: "+ jugadorWin);
            }
        }
    }
}
