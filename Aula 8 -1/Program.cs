using System;

namespace Aula_8__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            try
            {
                // Escrevemos um bloco de codigos
                Console.WriteLine("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                // Mostramos a excecao da regra 
                // Erro gerado na aplicacao
                Console.WriteLine("Ops :( Deu ruim" + ex);
            }
        }
    }
}
