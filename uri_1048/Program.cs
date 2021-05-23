using System;
using System.Globalization;

namespace uri_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario_atual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario_reajustado, valor_adicional;
            int percentual;

            if(salario_atual <= 400.00){
                percentual = 15;
                valor_adicional = ((salario_atual/100) *percentual);
                salario_reajustado = salario_atual + valor_adicional;
            }
            else if (salario_atual > 400.00 && salario_atual <= 800.00){
                percentual = 12;
                valor_adicional = ((salario_atual/100) *percentual);
                salario_reajustado = salario_atual + valor_adicional;
            }
            else if(salario_atual > 800.00 && salario_atual <= 1200.00){
                percentual = 10;
                valor_adicional = ((salario_atual/100) *percentual);
                salario_reajustado = salario_atual + valor_adicional;
            }
            else if(salario_atual > 1200.00 && salario_atual <= 2000.00){
                percentual = 7;
                valor_adicional = ((salario_atual/100) * percentual);
                salario_reajustado = salario_atual + valor_adicional;
            }
            else{
                percentual = 4;
                valor_adicional = ((salario_atual/100) *percentual);
                salario_reajustado = salario_atual + valor_adicional;
            }
            Console.WriteLine("Novo salario: "+salario_reajustado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: "+valor_adicional.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: "+percentual.ToString()+" %");


        }
    }
}
