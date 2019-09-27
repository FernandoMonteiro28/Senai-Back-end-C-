using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, despesa;

            Console.WriteLine("Digite seu salario");
            salario = float.Parse(Console.ReadLine() );

            Console.WriteLine("Digite o total de despesas");
            despesa = float.Parse(Console.ReadLine() );

            if (salario >= despesa)
            {
                Console.WriteLine("superavit");
            }
            else
            {
                Console.WriteLine("deficit");
            }
        }
    }
}
