using System;

namespace SalarioSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double pension = 0, eps = 0, arl = 0, deducciones = 0;
            int prima = 0;
            //Input del usuario
            Console.WriteLine("Ingrese su salario: ");
            int salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione su tipo de contrato: 1. Dependiente 2. Independiente");
            int tipo = int.Parse(Console.ReadLine());
            //Salario base
            double sBase = salario * (0.4);
            int smmlv = 887803;
            if (sBase < smmlv) sBase = smmlv;
            switch (tipo)
            {
                case 1:
                pension = (sBase) * (0.04);
                eps = (sBase) * (0.04);
                prima = salario;
                deducciones = (pension + eps); break;
                case 2:
                Console.WriteLine("Clasifique su nivel de riesgo de 1 a 5");
                int riesgoSwitch = int.Parse(Console.ReadLine());
                switch (riesgoSwitch)
                {
                    case 1:
                       arl = 0.00522; break;
                    case 2:
                       arl = 0.01044; break;
                    case 3:
                       arl = 0.02436; break;
                    case 4:
                       arl = 0.04350; break;
                    default:
                        arl = 0.0696; break;
                }                
                arl *= sBase;
                pension = sBase * 0.16;
                eps = sBase * 0.125;
                deducciones = (pension + eps + arl); break;
            }
            int salarioReal = salario - (int)(deducciones);
            int salarioAnual = salarioReal * 12 + prima;
            Console.WriteLine("Su EPS es de: " + eps + " Su Pension es de: " + pension + " Su ARL es de: " + arl + " Sus deducciones son: " + deducciones);
            Console.WriteLine("Su salario mensual real es: " + salarioReal + " Su salario anual real es: " + salarioAnual);
        }
    }
}
    

