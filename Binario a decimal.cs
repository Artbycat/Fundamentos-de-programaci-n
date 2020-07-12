using System;

namespace Binario_a_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input binary value 1: ");
            string s1 = Console.ReadLine();

            Console.WriteLine("Input binary value 2: ");
            string s2 = Console.ReadLine();

            Console.WriteLine("Input binary value 3: ");
            string s3 = Console.ReadLine();

            Console.WriteLine("Input binary value 4: ");
            string s4 = Console.ReadLine();

            Console.WriteLine("Input binary value 5: ");
            string s5 = Console.ReadLine();

            int b1 = Convert.ToInt32(s1, 2);
            int b2 = Convert.ToInt32(s2, 2);
            int b3 = Convert.ToInt32(s3, 2);
            int b4 = Convert.ToInt32(s4, 2);
            int b5 = Convert.ToInt32(s5, 2);

            Console.WriteLine("Input value 1 in base 10: " + b1);
            Console.WriteLine("Input value 2 in base 10: " + b2);
            Console.WriteLine("Input value 3 in base 10: " + b3);
            Console.WriteLine("Input value 4 in base 10: " + b4);
            Console.WriteLine("Input value 5 in base 10: " + b5);
        }
    }
}
