using System;

namespace Salario
{
    class Program
    {
        static void Main(string[]args)
        {
            double pension = 0, eps = 0, arl = 0, deducciones = 0;
            int prima = 0;
            //Input del usuario
            Console.WriteLine("Ingrese su salario: ");
            int salarioMensual = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione su tipo de contrato: 1. Dependiente 2. Independiente");
            int tipo = int.Parse(Console.ReadLine());
            //Salario base
            double sBase = salario * (0.4);
            int smmlv = 887803;
            if(sBase < smmlv){
                sBase = smmlv;}            
            if (tipo == 1){
                pension = (sBase) * (0.04);
                eps = (sBase) * (0.04);
                prima = salario;
                deducciones = (pension + eps);        
            }
            else{
                Console.WriteLine("Clasifique su nivel de riesgo de 1 a 5");
                int riesgo = int.Parse(Console.ReadLine());
                double claseRiesgo = 0;   
                if(riesgo == 1) arl = 0.00522;
                else if (riesgo == 2) arl = 0.01044;
                else if (riesgo == 3) arl = 0.02436;
                else if (riesgo == 4) arl = 0.04350;
                else if (riesgo == 5) arl = 0.0696;    
                arl *= ibc; //double salarioAnual = salarioRealMensual * 12;
                pension = sBase * 0.16;
                eps = sBase * 0.125;
                deducciones = (pension + eps + arl);                       
            }
            int salarioReal = salario - (int)(deducciones);
            int salarioAnual = salarioReal * 12 + prima;
              Console.WriteLine("Su EPS es de: " + eps + " Su Pension es de: " + pension + " Su ARL es de: " + arl + " Sus deducciones son: " + deducciones);
              Console.WriteLine("Su salario mensual real es: " + salarioReal + " Su salario anual real es: " + salarioAnual);  
        }
    }
}
