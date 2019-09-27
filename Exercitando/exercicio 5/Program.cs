using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcionarios;
            double media;
            double salario;
            double soma_salarios = 0;
            int cont = 1;

            Console.Write("Digite o numero de funcionarios:");
            funcionarios = int.Parse(Console.ReadLine() );

            while( cont <= funcionarios){
                Console.Write("Digite o salario: ");
                salario = double.Parse(Console.ReadLine() );

                soma_salarios += salario;

                cont ++;
            }

            media = soma_salarios / funcionarios;

            Console.WriteLine($"A media de salario é: {media}"); 
        }
    }
}
