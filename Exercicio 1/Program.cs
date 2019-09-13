using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num, sfinal;

            Console.WriteLine("Digite um numero");
            num = float.Parse(Console.ReadLine());

            sfinal = num * 3;

            Console.WriteLine($"Valor final é: {sfinal}");
        }
    }
}
