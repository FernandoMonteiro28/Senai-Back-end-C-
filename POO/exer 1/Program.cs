using System;

namespace exer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double porcentagem;

            try
            {
                Console.WriteLine("Digite o valor: ");
                numero = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o desconto: ");
                porcentagem = double.Parse(Console.ReadLine());

                Console.WriteLine("O seu valor convertido é: " + conversao(numero, porcentagem));
            }
            catch (Exception)
            {
                Console.WriteLine("Opa :( Algo de errado nao esta certo");
            }
        }

        static double conversao(double numero, double porcentagem)
        {
            try
            {
                double media = numero * porcentagem / 100;

                return media;
            }
            catch (Exception)
            {
                Console.WriteLine("Opa :( Algo de errado nao esta certo");

                return 0;
            }
        }
    }
}

