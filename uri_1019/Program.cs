using System;

namespace uri_1019
{
    class Program
    {
        static void Main(string[] args)
        {
           int total_segundos = int.Parse(Console.ReadLine());

           int horas = total_segundos/3600;
           int minutos = (total_segundos%3600)/60;
           int segundos_decomp = (total_segundos%3600)%60;

           Console.WriteLine(horas + ":" + minutos + ":" + segundos_decomp);
          //1018 1020 1021 1061

        }
    }
}
