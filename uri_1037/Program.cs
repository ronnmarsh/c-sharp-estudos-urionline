using System;
using System.Globalization;
namespace uri_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_lido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor_lido >= 0 && valor_lido <= 25.0000){
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor_lido > 25.0000 && valor_lido <= 50.0000000){
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(valor_lido > 50.0000000 && valor_lido <= 100.0000000){
                Console.WriteLine("Intervalo (75,100]");
            }
            else{
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
