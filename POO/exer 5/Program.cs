using System;

namespace exer_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = { 4, 7, 3, 4, 5, 6 };
            System.Console.WriteLine(MaioresVetores(vetor));
        }
        static double MaioresVetores(double[] vetores)
        {
            double total = 0;
            try
            {
                for (int i = 0; i < vetores.Length; i++)
                {
                    total += vetores[i];
                }
                return total;
            }
            catch (Exception e)
            {

                return total;
            }

        }
    }
}