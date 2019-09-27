using System;

namespace exer_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[2];
            string[] cor = new string[2];
            double[] tamanho = new double[2];
            double[] preco = new double[2];

            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite a cor do produto: ");
                cor[i] = Console.ReadLine();

                Console.WriteLine("Digite o tamanho do produto: ");
                tamanho[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preco do produto: ");
                preco[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine($"{nome[i]} ; {cor[i]} ; {tamanho[i]} ; {preco[i]}");
            }
        }
    }
}
