using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int n;

            Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            while (cont <= n){
                Console.WriteLine($"{cont}: {5*cont}");

                cont++;
        }
    }
}
}
