using System;

namespace aula_6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Chamamos nossa primeira funçao
            Console.WriteLine(BomDia());

            // Chamamos a funçao do tipo void que é sem retorno  
            ImprimeDataHora();

            // Chamamos nossa funcao que calcula a media 
            double[] numeros = {2 , 5 , 2};
            Console.WriteLine( CalculaMedia(numeros) );
        }

        /// <summary>
        /// Funçao que escreve Bom IDa para o usuario
        /// </summary>
        /// <returns>Retorna Ola! Bom dia!</returns>

        static string BomDia()
        {
            return "Olá! Bom dia!";
        }

        /// <summary>
        /// Retorna funcao que mostra uma saudacao de acordo com o horario atual
        /// </summary>
        /// <param name="saudacao">Um texto qualquer (sobrecarga de metodo)</param>
        /// <returns>Saudacao de acordo com o horario</returns>
        static string BomDia(string saudacao)
        {
            int hora = DateTime.Now.Hour;
            if (hora <= 11 && hora >= 6)
            {
                saudacao = "BomDia";
            }
            else if (hora >= 12 && hora <= 18)
            {
                saudacao = "Boa Tarde";
            }
            else
            {
                saudacao = "Boa Noite";
            }
            return saudacao;
        }

        /// <summary>
        /// Retorna um nuemro - Teste de Sobrecarga 
        /// </summary>
        /// <param name="numero">Um numero inteiro qualquer</param>
        /// <returns>Numero passado com parametro</returns>
        static int BomDia(int numero){
            return numero;
        }

        /// <summary>
        /// Retorna Data e Hora atuais
        /// </summary>
        static void ImprimeDataHora()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour.ToString());
        }

        /// <summary>
        /// Funcao que calcula a media de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia( double[] valores){
            
            double resultado = 0;
            
            for(int i = 0; i <= valores.Length; i++){
                resultado += valores[i];
            }
            
            resultado = resultado / valores.Length;

            return resultado;
        }
    }
}
