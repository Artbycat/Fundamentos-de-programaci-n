using System;

namespace Estaturas
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
			double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };

			for (int i = 0; i < estatura.Length - 1; i++)
            {
                for (int j = 0; j < estatura.Length - 1; j++)
                {
                    if(estatura[j]>estatura[j + 1])
                    {
                        double temp = estatura[j];
                        estatura[j] = estatura[j+1];
                        estatura[j + 1] = temp;
                        string temp1 = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = temp1;
                    }
                }
            }
            for (int j = 0; j<estatura.Length - 1; j++)
            {
                Console.WriteLine(nombres[j] + "\n Estatura: " + estatura[j]);
            }

		}
	}
}
