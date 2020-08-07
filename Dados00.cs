using System;

namespace Dados00
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado1 = 0, dado2 = 0, total = 0, puntuacionActual = 0, contadorTurnos = 1, contadorSeis = 0, contadorDobles = 0;
            double porcentajeSeis = 0;
            string cont = "";
            Random aleatorio = new Random();
            Console.WriteLine("¿Iniciar el juego? (s/n)");
            cont = Console.ReadLine();
            dado1 = aleatorio.Next(1, 6);
            dado2 = aleatorio.Next(1, 6);
            puntuacionActual = dado1 + dado2;
            total = puntuacionActual;

            if (dado1 == 1 && dado2 == 1)
            {
                Console.WriteLine("Dado 1: " + dado1 + "; dado 2: " + dado2 + ".  Puntuación: " + puntuacionActual + ".  Total: " + total + ".  Usted ha perdido el juego.");
                cont = "n";
            }
            else
            {
                Console.WriteLine("Dado 1: " + dado1 + "; dado 2: " + dado2 + ".  Puntuación: " + puntuacionActual + ".  Total: " + total);
                Console.WriteLine("¿Continuar? (s/n)");
                cont = Console.ReadLine();
            }

            if (puntuacionActual > 6)
                contadorSeis++;


            while (cont == "s")
            {
                dado1 = aleatorio.Next(1, 6);
                dado2 = aleatorio.Next(1, 6);
                puntuacionActual = dado1 + dado2;
                total += puntuacionActual;
                contadorTurnos++;

                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("Dado 1: " + dado1 + "; dado 2: " + dado2 + ".  Usted ha perdido el juego.");
                    cont = "n";
                }
                else
                {
                    Console.WriteLine("Dado 1: " + dado1 + "; dado 2: " + dado2 + ".  Puntuación: " + puntuacionActual + ".  Total: " + total);
                    Console.WriteLine("¿Continuar? (s/n)");
                    cont = Console.ReadLine();
                }

                if (puntuacionActual > 6)
                    contadorSeis++;

                if(total >= 100)
                {
                    Console.WriteLine("Ha ganado el juego.");
                    cont = "n";
                }

                if (dado1 == dado2)
                {
                    contadorDobles++;

                    if (contadorDobles >= 3)
                    {
                        Console.WriteLine("Ha ganado el juego.");
                        cont = "n";
                    }
                }  
              
                else
                    contadorDobles = 0;

                if (cont == "n")
                    Console.WriteLine("Gracias por jugar.");
              
            }
            porcentajeSeis = Math.Round((((double)contadorSeis / contadorTurnos) * 100), 2);
            Console.WriteLine("Su total fue de: " + total + ". El porcentaje de turnos en que la suma de los dados fue mayor que 6 es: " + porcentajeSeis + "%");
        }
    }
}

