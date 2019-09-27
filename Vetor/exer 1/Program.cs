using System;

namespace exer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
 
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Digite o numero:");
                num[i] = int.Parse(Console.ReadLine());
            }
                Console.Write($"{num [9]}: {num[9]*5} ");

        }
    }
}
