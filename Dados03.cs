using System;

namespace Dados03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dadoEspecial = 0, contadorE = 0, total = 0, vidas = 2, contador1 = 0;
            string cont = "", especial = "";
            bool contador6 = false;
            Console.WriteLine("Inicio del juego.");
            Console.WriteLine("¿iniciar? (s/n)");
            cont = Console.ReadLine();

            while (cont == "s")
            {
                dado1 = aleatorio.Next(1, 7);
                dadoEspecial = aleatorio.Next(1, 13);
                if (dado1 == 1 || dadoEspecial == 1) contador1++;
                if (contador1 == 2)
                {
                    vidas -= 1;
                    contador1 = 0;
                }               
                if (contadorE < 2)
                {
                    Console.WriteLine("¿Desea utilizar su dado especial? (s/n)");
                    especial = Console.ReadLine();
                }
                if (contadorE >= 2) especial = "n";
                while (especial == "s")
                {
                    total += dadoEspecial;
                    Console.WriteLine("\nDado Especial: " + dadoEspecial + "\nVidas: " + vidas);
                    Console.WriteLine("¿Continuar? (s/n)");
                    cont = Console.ReadLine();
                    contadorE++;
                    break;
                }
                if (especial == "n")
                {
                    total += dado1;
                    Console.WriteLine("\nDado 1: " + dado1 + "\nVidas: " + vidas );
                    Console.WriteLine("¿Continuar? (s/n)");
                    cont = Console.ReadLine();
                }
                if (dado1 == 6 || dadoEspecial == 6) contador6 = true;
                if ((dado1 == 6 || dadoEspecial == 6) && contador6) vidas++;
                else if (vidas > 3) vidas = 3;
                if (cont == "n") break;

                if (total >= 100)
                {
                    Console.WriteLine("Ha ganado el juego.");
                    cont = "n";
                }
                else if (vidas == 0)
                {
                    Console.WriteLine("Ha perdido el juego.");
                    cont = "n";
                }
                else cont = "s";
                Console.WriteLine("Total: " + total);
            }
            if (cont == "n")
            {
                Console.WriteLine("Gracias por jugar. Su total fue de: " + total);
            }
        }
    }
}
