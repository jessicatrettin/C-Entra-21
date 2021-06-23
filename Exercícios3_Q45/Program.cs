using System;

namespace Exercícios3_Q45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de 10 valores");
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sua sequência de trás pra frente");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
