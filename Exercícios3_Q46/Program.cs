using System;

namespace Exercícios3_Q46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De quantos elementos você quer que sejam seus vetores? ");
            int n = int.Parse(Console.ReadLine());
            int[] vetor_x = new int[n];
            int[] vetor_y = new int[n];
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um valor pro Vetor X: ");
                vetor_x[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite um valor pro Vetor Y: ");
                vetor_y[i] = int.Parse(Console.ReadLine());
                soma += vetor_x[i] * vetor_y[i];
            }
            Console.Write($"O produto escalar dos vetores é {soma}.");
        }
    }
}
