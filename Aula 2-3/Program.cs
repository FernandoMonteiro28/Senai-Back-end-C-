using System;

namespace Aula_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deixamos declarada falsa por padrao
            bool entrada = false;
            int idade;
            string retorno;

            Console.Write("Digite sua idade");
            idade = int.Parse(Console.ReadLine() );

            // Como ja c
            // Estado da variavel para verdadeiro caso
            // Entre nessa condiçao
            if (idade > 17)
            {
                entrada = true;
            }
            if (entrada == true)
            {
                retorno = "Entrada permitida!!";
            }
            else
            {
                retorno = "Entrada nao permitida ;( ";
            }
            Console.WriteLine("retorno");
        }
    }
}
