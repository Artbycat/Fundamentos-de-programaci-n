using System;

namespace Validación
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, contadorError = 0;
            Random aleatorio = new Random();
            a = aleatorio.Next(0, 10);
            b = aleatorio.Next(0, 10);
            int sumaCorrecta = a + b;
            Console.WriteLine("Ingrese el resultado de la suma para poder continuar: \n A= " + a + "\n B= " + b);
            int sumaUsuario = int.Parse(Console.ReadLine());
            if (sumaCorrecta != sumaUsuario) contadorError+=1;

            while (sumaCorrecta != sumaUsuario)
            {
                a = aleatorio.Next(0, 10);
                b = aleatorio.Next(0, 10);
                sumaCorrecta = a + b;

                Console.WriteLine("Incorrecto, inténtelo de nuevo.");
                Console.WriteLine("Ingrese el resultado de la suma para poder continuar: \n A= " + a + "\n B= " + b);
                sumaUsuario = int.Parse(Console.ReadLine());

                if (contadorError >= 2)
                {
                    Console.WriteLine("Acceso denegado.");
                    break;
                }
                contadorError += 1;
                
            }
            if (sumaCorrecta == sumaUsuario)
                Console.WriteLine("Acceso permitido.");            
        }
    }
}
