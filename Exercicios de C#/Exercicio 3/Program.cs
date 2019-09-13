using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float salariofx, totalvd, sfinal;

            Console.WriteLine("Digite seu salario");
            salariofx = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total da suas vendas");
            totalvd = float.Parse(Console.ReadLine());

            sfinal = salariofx + (totalvd *1.05f);

            Console.WriteLine($"O valor final é: {sfinal}");


        }
    }
}
