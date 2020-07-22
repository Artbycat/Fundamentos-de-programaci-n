using System;

namespace Salario
{
    class Program
    {
        static void Main(string[]args)
        {
            //Input del usuario
            Console.WriteLine("Ingrese su salario: ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione su tipo de contrato: 1. Dependiente 2. Independiente");
                int tipo = int.Parse(Console.ReadLine());

            //Salario base
            double sBase = s * (0.4);
            int smmlv = 887803;
            if(sBase < smmlv){
                sBase = smmlv;}
                
            
            //condicional independiente
            if (tipo == 2)
            {
                Console.WriteLine("Clasifique su nivel de riesgo de 1 a 5");
                int r = int.Parse(Console.ReadLine());
                //Condicional riesgo
                if (r == 1)
                {
                    //Cálculo deducciones
                    double pPercent = (sBase) * (0.16);
                    double ePercent = (sBase) * (0.125);
                    double rPercent = sBase * (0.00522);
                    double deducciones = (rPercent + pPercent + ePercent);
                    //Cálculo salario
                    double sMensual = s - deducciones;
                    double sAnual = sMensual * 12;
                    //output
                    Console.WriteLine("Su ARL es de: " + rPercent);
                    Console.WriteLine("Su EPS es de: " + ePercent);
                    Console.WriteLine("Su Pension es de: " + pPercent);
                    Console.WriteLine("Sus deducciones son: " + deducciones);
                    Console.WriteLine("Su salario mensual real es: " + sMensual);
                    Console.WriteLine("Su salario anual real es: " + sAnual);
                }
                else if (r == 2)
                {
                    double pPercent = (sBase) * (0.16);
                    double ePercent = (sBase) * (0.125);
                    double rPercent = sBase * (0.01044);
                    double deducciones = (rPercent + pPercent + ePercent);
                    double sMensual = s - deducciones;
                    double sAnual = sMensual * 12;
                    Console.WriteLine("Su ARL es de: " + rPercent);
                    Console.WriteLine("Su EPS es de: " + ePercent);
                    Console.WriteLine("Su Pension es de: " + pPercent);
                    Console.WriteLine("Sus deducciones son: " + deducciones);
                    Console.WriteLine("Su salario mensual real es: " + sMensual);
                    Console.WriteLine("Su salario anual real es: " + sAnual);
                }
                else if (r == 3)
                {
                    double pPercent = (sBase) * (0.16);
                    double ePercent = (sBase) * (0.125);
                    double rPercent = sBase * (0.02436);
                    double deducciones = (rPercent + pPercent + ePercent);
                    double sMensual = s - deducciones;
                    double sAnual = sMensual * 12;
                    Console.WriteLine("Su ARL es de: " + rPercent);
                    Console.WriteLine("Su EPS es de: " + ePercent);
                    Console.WriteLine("Su Pension es de: " + pPercent);
                    Console.WriteLine("Sus deducciones son: " + deducciones);
                    Console.WriteLine("Su salario mensual real es: " + sMensual);
                    Console.WriteLine("Su salario anual real es: " + sAnual);
                }
                else if (r == 4)
                {
                    double pPercent = (sBase) * (0.16);
                    double ePercent = (sBase) * (0.125);
                    double rPercent = sBase * (0.0435);
                    double deducciones = (rPercent + pPercent + ePercent);

                    double sMensual = s - deducciones;
                    double sAnual = sMensual * 12;
                    Console.WriteLine("Su ARL es de: " + rPercent);
                    Console.WriteLine("Su EPS es de: " + ePercent);
                    Console.WriteLine("Su Pension es de: " + pPercent);
                    Console.WriteLine("Sus deducciones son: " + deducciones);
                    Console.WriteLine("Su salario mensual real es: " + sMensual);
                    Console.WriteLine("Su salario anual real es: " + sAnual);
                }
                else
                {
                    double pPercent = (sBase) * (0.16);
                    double ePercent = (sBase)* (0.125);
                    double rPercent = (sBase) * (0.0696);
                    double deducciones = (rPercent + pPercent + ePercent);
                    
                    double sMensual = s - deducciones;
                    double sAnual = sMensual * 12;
                    Console.WriteLine("Su ARL es de: " + rPercent);
                    Console.WriteLine("Su EPS es de: " + ePercent);
                    Console.WriteLine("Su Pension es de: " + pPercent);
                    Console.WriteLine("Sus deducciones son: " + deducciones);
                    Console.WriteLine("Su salario mensual real es: " + sMensual);
                    Console.WriteLine("Su salario anual real es: " + sAnual);
                  
                }
                
            }
            else
            {
                double pPercent = (sBase) * (0.04);
                double ePercent = (sBase) * (0.04);
                double prima = s;
                double deducciones = (pPercent + ePercent);

                double sMensual = s - deducciones;
                double sAnual = (sMensual * 12) + prima;
                
                Console.WriteLine("Su EPS es de: " + ePercent);
                Console.WriteLine("Su Pension es de: " + pPercent);
                Console.WriteLine("Sus deducciones son: " + deducciones);
                Console.WriteLine("Su salario mensual real es: " + sMensual);
                Console.WriteLine("Su salario anual real es: " + sAnual);

            }
        }
    }
}
