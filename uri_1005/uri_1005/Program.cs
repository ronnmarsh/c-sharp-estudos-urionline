using System;
using System.Globalization;

namespace uri_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double valor_A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor_B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //cálculo da média ponderada
            double media = ((valor_A * 3.5) + (valor_B * 7.5))/(11);

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
            

        }
    }
}
