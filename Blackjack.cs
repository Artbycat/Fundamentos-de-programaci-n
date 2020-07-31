using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            int carta = 2, total = 0, puntuacion = 0;
            Random aleatorio = new Random();
            string cont = "";
            Console.WriteLine("¿Iniciar el juego? (s/n)");
            cont = Console.ReadLine();
            puntuacion = aleatorio.Next(2, 21);
            total = puntuacion;
            Console.WriteLine("Cartas: " + carta + "  Puntuación: " + puntuacion + "  Total: " + total);

            while (cont == "s")
            {
                puntuacion = aleatorio.Next(1, 11);
                Console.WriteLine("¿Continuar? (s/n)");
                cont = Console.ReadLine();
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
                else if( total == 21)
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
            
        }
    }
}
