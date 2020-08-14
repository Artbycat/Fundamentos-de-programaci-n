using System;

namespace Dados02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, totalDoble = 0, total = 0, vidas = 3, turno = 1;
            string cont = "";
            Console.WriteLine("Inicio del juego.");
            Console.WriteLine("¿iniciar? (s/n)");
            cont = Console.ReadLine();

            while (cont == "s")
            {                
                while (turno % 2 !=0  && turno % 3 != 0)
                {
                    dado1 = aleatorio.Next(1, 7);
                    turno += 1;
                    total += dado1;
                    Console.WriteLine("Dado 1: " + dado1 + "\n Vidas: " + vidas + "\n Turno: " + turno + "\n Total: " + total);
                    Console.WriteLine("¿Continuar? (s/n)");
                    cont = Console.ReadLine();
                }
                while (turno % 3 == 0 && turno % 2 == 0)
                {
                    vidas -= 1;
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    if (dado1 == dado2)
                        vidas++;                  
                    totalDoble = dado1 + dado2;
                    Console.WriteLine("Dado 1: " + dado1 + "\n Dado 2: " + dado2 + "\n Vidas: " + vidas + "\n Turno: " + turno + "\n Total: " + totalDoble);  
                    Console.WriteLine("¿Continuar? (s/n)");
                    cont = Console.ReadLine();
                    turno += 1;
                }
                while (turno % 3 == 0)
                {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7); 
                    if (dado1 == dado2)
                        vidas++;
                   totalDoble = dado1 + dado2;
                    Console.WriteLine("Dado 1: " + dado1 + "\n Dado 2: " + dado2 + "\n Vidas: " + vidas + "\n Turno: " + turno + "\n Total: " + totalDoble);
                    Console.WriteLine("¿Continuar? (s/n)");
                    cont = Console.ReadLine();
                    turno += 1;
                }
                while (turno % 2 == 0)
                {
                    vidas -= 1;
                    dado1 = aleatorio.Next(1, 7);
                    turno += 1;
                    total += dado1;
                    Console.WriteLine("Dado 1: " + dado1 + "\n Vidas: " + vidas + "\n Turno: " + turno  + "\n Total: " + total);
                    Console.WriteLine("¿Continuar? (s/n)");
                    cont = Console.ReadLine();
                }                
               
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
            }
            if(cont == "n")
            {
                Console.WriteLine("Gracias por jugar.");
            }
        }
    }
}
