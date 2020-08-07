using System;

namespace Dados01
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado = 0, total = 0, contadorTurnos = 0;
            bool dadoDoce = false;
            string cont = "";
            Random aleatorio = new Random();
            Console.WriteLine("¿Iniciar el juego? (s/n)");
            cont = Console.ReadLine();
            dado = aleatorio.Next(1, 13);
            total = dado;

            Console.WriteLine("Dado: " + dado + ".  Total: " + total);
            Console.WriteLine("¿Continuar? (s/n)");
            cont = Console.ReadLine();

            while (cont == "s")
            {
                dado = aleatorio.Next(1, 13);
                total += dado;
                contadorTurnos++;
               
                if (contadorTurnos<3)
                {               
                    Console.WriteLine("Dado: " + dado + ".  Total: " + total);
                    Console.WriteLine("¿Continuar? (s/n)");
                    cont = Console.ReadLine();
                    if (dado == 12)
                    {
                        dadoDoce = true;
                    }

                    else if (dado == 10 && dadoDoce)
                    {
                        Console.WriteLine("Ha ganado el juego.");
                        cont = "n";
                    }
                    else
                        dadoDoce = false;
                }
                else
                {
                    Console.WriteLine("Dado: " + dado + ".  Total: " + total);
                    if (dado % 2 != 0)
                    {
                        Console.WriteLine("Total: " + total + ".  Usted ha perdido el juego.");
                        cont = "n";
                    }
                    else
                    {
                        Console.WriteLine("¿Continuar? (s/n)");
                        cont = Console.ReadLine();
                    }
                    if (dado == 12)
                    {
                        dadoDoce = true;
                    }

                    else if (dado == 10 && dadoDoce)
                    {
                        Console.WriteLine("Ha ganado el juego.");
                        cont = "n";
                    }
                    else
                        dadoDoce = false;
                }

                if (total >= 100)
                {
                    Console.WriteLine("Ha ganado el juego.");
                    cont = "n";
                }

                if (cont == "n")
                    Console.WriteLine("Gracias por jugar.");

            }
            Console.WriteLine("Su total fue de: " + total);
        }
    }
}
