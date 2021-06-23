using System;

namespace Exercícios3_Q47
{
    class Program
    {
        static void Main(string[] args)
        {
            int somaMenor = 0, somaMaior = 0, somaIgual = 0;
            int[] vetor = new int[10];
            Console.Write("Digite um valor maior que 0 para comparar ao seu vetor: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 10 números inteiros maiores que 0 para comporem o seu vetor");
            for (int i = 0; i < 10; i++)
            {
                                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] < n)
                    somaMenor += 1;
                if (vetor[i] > n)
                    somaMaior += 1;
                if (vetor[i] == n)
                    somaIgual += 1;
            }
            Console.WriteLine($"{somaMenor} números do vetor são menores que {n}.");
            Console.WriteLine($"{somaMaior} números do vetor são maiores que {n}.");
            Console.WriteLine($"{somaIgual} números do vetor são iguais à {n}.");
        }
    }
}
