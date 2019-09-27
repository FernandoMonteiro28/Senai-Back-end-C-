using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float total;

            Console.WriteLine("Preço total");
            total = float.Parse(Console.ReadLine());

            if ((total >= 100) && (total <= 1000))
            {
                Console.WriteLine(total *0.85f);
            }
        }
    }
}
