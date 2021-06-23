using System;

namespace Exercícios2_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nota 1: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            float n3 = float.Parse(Console.ReadLine());
            Console.Write("Nota 4: ");
            float n4 = float.Parse(Console.ReadLine());
            float media = (n1 + n2 + n3 + n4) / 4;
            if (media >= 7)
            {
                Console.WriteLine($"Aluno APROVADO! Média {media}.");
            }
            else
            {
                Console.Write("Nota da recuperação: ");
                float nRecup = float.Parse(Console.ReadLine());
                float mediaNova = (media + nRecup) / 2;
                if (mediaNova >= 7)
                {
                    Console.WriteLine($"Aluno APROVADO! Média {mediaNova}.");
                }
                else
                {
                    Console.WriteLine($"Aluno REPROVADO! Média {media}.");
                }
            }
        }
    }
}
