using System;

namespace uri_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            //leia a hora inicial e final de um jogo
            int hora_inicio, hora_fim, total;
            string[] vetor = Console.ReadLine().Split(' ');

            hora_inicio = int.Parse(vetor[0]);
            hora_fim = int.Parse(vetor[1]);

            //A seguir calcule a duração do jogo, sabendo que o mesmo pode
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas
             
            if (hora_inicio == hora_fim){
                total = 24;
            }
            else if(hora_inicio > hora_fim){
                total = (24 - hora_inicio) + (hora_fim);
            }
            else{
                total = hora_fim - hora_inicio;
            }
            Console.WriteLine("O JOGO DUROU "+total+" HORA(S)");
        }
    }
}
