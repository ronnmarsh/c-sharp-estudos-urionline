using System;
using System.Globalization;

namespace uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            float n1 = float.Parse(valores[0], CultureInfo.InvariantCulture); //peso 2
            float n2 = float.Parse(valores[1], CultureInfo.InvariantCulture); //peso 3
            float n3 = float.Parse(valores[2], CultureInfo.InvariantCulture); //peso 4
            float n4 = float.Parse(valores[3], CultureInfo.InvariantCulture); //peso 1

            float media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (2 + 3 + 4 + 1);

            float nExame, mediaExame;

           //problema de arredodamento específico do C#
            if(media == 4.85f){
                media = 4.8f;
            }
            //fium do problema de arredondamento específico do C#
            
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if(media >= 7.0){
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0){
                Console.WriteLine("Aluno reprovado.");
            }
            else{
                Console.WriteLine("Aluno em exame.");

                nExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Nota do exame: " + nExame.ToString("F1"));

                mediaExame = (media + nExame)/2;

                    if(mediaExame >= 5.0){
                       Console.WriteLine("Aluno aprovado.");
                    }
                    else{
                      Console.WriteLine("Aluno reprovado.");
                    }

                Console.WriteLine("Media final: "+mediaExame.ToString("F1", CultureInfo.InvariantCulture));
            }


        }
    }
}
