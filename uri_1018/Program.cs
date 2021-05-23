using System;

namespace uri_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor_recebido, valor;
            valor_recebido = int.Parse(Console.ReadLine());
            
            Console.WriteLine(valor_recebido);
                       
            int[] vet = new int[7];

            vet[0] = 100;
            vet[1] = 50;
            vet[2] = 20;
            vet[3] = 10;
            vet[4] = 5;
            vet[5] = 2;
            vet[6] = 1;

            for(int x = 0; x <= 6; x++)
            {
                valor = valor_recebido/vet[x];
                Console.WriteLine(valor + " nota(s) de R$ " + vet[x].ToString("F2"));
                valor_recebido = valor_recebido%vet[x];
            }
        }
    }
}




//outra forma
/*valor = valor_recebido/100;
            Console.WriteLine(valor + " nota(s) de R$ 100,00");
            valor_recebido = valor_recebido%100;

            valor = valor_recebido/50;
            Console.WriteLine(valor + " nota(s) de R$ 50,00");
            valor_recebido = valor_recebido%50;

            valor = valor_recebido/20;
            Console.WriteLine(valor + " nota(s) de R$ 20,00");
            valor_recebido = valor_recebido % 20;

            valor = valor_recebido/10;
            Console.WriteLine(valor + " nota(s) de R$ 10,00");
            valor_recebido = valor_recebido%10;

            valor = valor_recebido/5;
            Console.WriteLine(valor + " nota(s) de R$ 5,00");
            valor_recebido = valor_recebido%5;

            valor = valor_recebido/2;
            Console.WriteLine(valor + " nota(s) de R$ 2,00");
            valor_recebido = valor_recebido%2;

            valor = valor_recebido;
            Console.WriteLine(valor + " nota(s) de R$ 1,00");*/


