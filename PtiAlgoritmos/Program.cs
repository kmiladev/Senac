using System;

namespace PtiAlgoritmos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de elementos para o seu vetor: ");
            int e = int.Parse(Console.ReadLine());

            int[] vetor = new int[e];

            for (int i = 0; i < e; i++)
            {
                Console.Write($"Digite o {i + 1}º número para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int diferenca = MaiorDiferenca(vetor);
            bool ordem = OrdemCrescente(vetor);
        }
        public static int MaiorDiferenca(int[] vetor)
        {
            int maiorNum = vetor.Max();
            int menorNum = vetor.Min();

            int maiorDif = maiorNum - menorNum;
            Console.WriteLine($"A maior diferença entre os números é {maiorDif}");
            return maiorDif;
        }
        public static bool OrdemCrescente(int[] vetor)
        {
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i - 1] > vetor[i])
                {
                    Console.WriteLine("O vetor está em ordem crescente: FALSE");
                    return false;
                }
            }
            Console.WriteLine("O vetor está em ordem crescente: TRUE");
            return true;
        }
        
    }
}
