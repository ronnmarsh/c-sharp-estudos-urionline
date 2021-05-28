using System;

namespace uri_1047
{
    class Program
    {
        static void Main(string[] args)
        {
             //ler valores

            string[] vet = Console.ReadLine().Split(' ');

            int hora_inicio = int.Parse(vet[0]);
            int minuto_inicio = int.Parse(vet[1]);
            int hora_fim = int.Parse(vet[2]);
            int minuto_fim = int.Parse(vet[3]);
                    
            int instanteInicial = hora_inicio * 60 + minuto_inicio;
            int instanteFinal = hora_fim * 60 + minuto_fim;

            int duracao; 

            //calcular a duração
          if (instanteInicial < instanteFinal) {
                duracao = instanteFinal - instanteInicial;
            }
            else {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int horas = duracao /60;
            int minutos = duracao % 60;
            
            //Saída
            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");
        }
    }
}
