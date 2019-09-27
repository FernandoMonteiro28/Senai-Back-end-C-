using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 3)
            {
                Console.WriteLine("Early Childhood");
            }
            else if (idade <= 10 )
            {
                Console.WriteLine("")
            }
            else if (idade <= 10 )
            {
                Console.WriteLine("Everyone 10+");
            }
            else if (idade <= 13 )
            {
                Console.WriteLine("Teen");
            }
            else if (idade <= 17 )
            {
                Console.WriteLine("Mature 17+");
            }
             else if (idade <= 17  )
            {
                Console.WriteLine("Adults only 18+");
            }
            else{
                Console.WriteLine(Everyone);
            }

        }
    }
}
