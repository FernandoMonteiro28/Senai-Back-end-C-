using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
           float preço;

           Console.WriteLine("Digite o preço");
           preço = float.Parse(Console.ReadLine() );

           if(preço > 100){
               preço = preço -25;
           }

           Console.WriteLine(preço);
        }
    }
}
