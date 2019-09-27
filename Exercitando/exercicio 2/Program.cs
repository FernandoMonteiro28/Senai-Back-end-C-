using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine() );

            for (int cont = 1; cont <= 10; cont++)
            {
                Console.WriteLine(num + "x" + cont + "=" + (num*cont)); 
            }
        }
    }
}
