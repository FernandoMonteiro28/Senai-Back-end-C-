using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            double nota1, nota2, nota3, media;

            // Capturamos a 1º nota
            Console.Write("Digite sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            // Capturamos a 2º nota
            Console.Write("Digite sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            // Capturamos a 3º nota
            Console.Write("Digite sua terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            // Calculamos a meid adas notas
            media = (nota1 + nota2 + nota3) / 3;

            //Verificamos se a media do aluno é maior ou igual a 6
            if(media > 6) {
                Console.WriteLine($"Média": (media) "Aluno Aprovado!");
                 Console.WriteLine($"Média": (media) "Aluno Reprovadp!");
            }

            // Verificamos se a media do aluno é amior ou igual a 6
            if (media > 6)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }


        }
    }
}
