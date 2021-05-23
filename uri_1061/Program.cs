using System;

namespace uri_1061
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADAS DE DADOS PARA O ÍNICIO
            string[] inicio = Console.ReadLine().Split(' ');
            int dia_inicio = int.Parse(inicio[1]);
            string[] hora_inicio = Console.ReadLine().Split(" : ");

            int[] vet_hora_inicio = new int[3];

            vet_hora_inicio[0] = int.Parse(hora_inicio[0]);//horas inicio
            vet_hora_inicio[1] = int.Parse(hora_inicio[1]);//minutos inicio
            vet_hora_inicio[2] = int.Parse(hora_inicio[2]);//segundos inicio

            //ENTRADA DE DADOS PARA O FIM
            string[] fim = Console.ReadLine().Split(' ');
            int dia_fim = int.Parse(fim[1]);
            string[] hora_fim = Console.ReadLine().Split(" : ");

            int[] vet_hora_fim = new int[3];

            vet_hora_fim[0] = int.Parse(hora_fim[0]); //horas fim
            vet_hora_fim[1] = int.Parse(hora_fim[1]); //minutos fim
            vet_hora_fim[2] = int.Parse(hora_fim[2]); //segundo fim

            //CALCULAR O TOTAL DE DIAS BRUTOS (ENTRE O PRIMEIRO E O SEGUNDO, DESCONSIDERANDO O HORÁRIO)
            int dias_bruto = dia_fim - dia_inicio;
            
            //CONVERTER OS DIAS BRUTOS EM SEGUNDOS
            int dias_liquidos = ((dias_bruto*24)*60)*60;

            //CALCULAR O TEMPO A SER DESCONTADO DO PRIMEIRO DIA
            int segundos_descontados_inicio = (vet_hora_inicio[0]*3600) + (vet_hora_inicio[1] * 60) + vet_hora_inicio[2];

            //CALCULAR O TEMPO A SER DESCONTADO DO ÚLTIMO DIA
            int segundos_descontados_fim = (24*3600) - ((vet_hora_fim[0]*3600) + (vet_hora_fim[1]*60) + vet_hora_fim[2]);

            //CALCULAR O TEMPO TOTAL, CONSIDERANDO OS DESCONTOS, EM SEGUNDOS
            double tempo_total = dias_liquidos - segundos_descontados_fim - segundos_descontados_inicio;

            //DECOMPOR O TEMPO TOTAL EM FUNÇÃO DE DIAS, HORAS, MINUTOS E SEGUNDOS
            double[] vet_tempo = new double[4];

            vet_tempo[0] = tempo_total/86400; //recebe o total de dias
            vet_tempo[1] = (tempo_total%86400)/3600; //recebe o total de horas
            vet_tempo[2] = ((tempo_total%86400)%3600)/60; //recebe o total de minutos
            vet_tempo[3] = ((tempo_total%86400)%3600)%60; //recebe o total de segundos

            int dias = Convert.ToInt32(vet_tempo[0]);
            int horas = Convert.ToInt32(vet_tempo[1]);
            int minutos = Convert.ToInt32(vet_tempo[2]);
            int segundos = Convert.ToInt32(vet_tempo[3]);

            //SAÍDA NA TELA
            //Console.WriteLine("\n" + tempo_total);
            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " hora(s)");
            Console.WriteLine(minutos + " minutos(s)");
            Console.WriteLine(segundos + " segundos(s)");

            
        }
    }
}
