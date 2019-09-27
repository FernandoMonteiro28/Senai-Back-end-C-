using System;

namespace Aula_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime[] data_ida = new DateTime[5];
            DateTime[] data_volta = new DateTime[5];

            string sair = "";

            while (sair != "0")
            {
                Console.WriteLine("Bem-vindo ao nosso sistema de passasgens!!");
                Console.WriteLine(
                    @"Menu: 
                        1- Cadastrar
                        2- Listar passagens
                        0- Sair");

                sair = Console.ReadLine();

                switch (sair){
                
                    caso "1";
                    for (int i = 0; i <= 4; i++)
                    {
                        Console.WriteLine("Digite seu nome completo: ");
                        nome[indice] = Console.ReadLine();

                        Console.WriteLine("Digite a UF de origem: ");
                        origem[indice] = Console.ReadLine();

                        Console.WriteLine("Digite a UF de destino: ");
                        destino[indice] = Console.ReadLine();

                        Console.WriteLine("Digite a data de ida: ");
                        data_ida[indice] = DateTime.Parse(Console.ReadLine());


                        Console.WriteLine(nome[i]);
                        Console.WriteLine(origem[i]);
                        Console.WriteLine(destino[i]);
                        Console.WriteLine(data_ida[i]);
                        Console.WriteLine(data_volta[i]);
                    }
                }
                break;

                    case "0";
                Console.WriteLine("Obrigado por utilizar o nosso sistema! ");

                break;

                default;
                        Console.WriteLine("Entrada invalida!");
                break;
            }
        }
    }
}

