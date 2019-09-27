using System;

namespace exer_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = {4, 7, 3, 4, 5, 6 };
           System.Console.WriteLine(MaioresVetores(vetor));
        }

        static double MaioresVetores(double[] vetores)
        {
            double maior = 0;
            try
            {
                for (int i = 0; i < vetores.Length; i++)
                {
                    if (vetores[i] > maior)
                    {
                        maior = vetores[i];
                    }
                }
                return maior;
            }
            catch (Exception e){

                return maior;
            }
        }
    }
}
