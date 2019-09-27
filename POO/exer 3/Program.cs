using System;

namespace exer_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mostrainfo();

            System.Console.WriteLine();
            string nome = Console.ReadLine();
            Console.WriteLine(Mostrainfo(nome, "Monteiro"));

            Console.WriteLine(Mostrainfo(21, 60.80, 1, 85));

        }
        static void Mostrainfo()
        {
            Console.WriteLine("Razao Social da Escola Seni de Informatica");
        }

        static string Mostrainfo(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        static string Mostrainfo(int idade, double peso, double altura)
        {
            return $"\nIdade: {idade}\n Peso: {peso}\n Altura: {altura.ToString("f2")}";
        }
    }
}
