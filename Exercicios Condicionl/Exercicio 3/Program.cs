using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o primeiro num");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
