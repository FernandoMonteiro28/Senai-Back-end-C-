using System;

namespace Exercios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 4
             float vreais, vdolar, cotaçao;
            Console.WriteLine("Digite o valor em reais");
            vreais = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor da cotação do dolar");
            cotaçao = float.Parse(Console.ReadLine());

            vdolar = vreais / cotaçao;

            Console.WriteLine( $"Esse valor em dolar é: {vdolar}" );
        }
    }
}
