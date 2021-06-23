using System;

namespace Exercícios2_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0;

            Console.WriteLine("Digite um valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                n3 = n1 - n2;
            }
            else
            {
                n3 = n2 - n1;
            }
            Console.WriteLine($"A diferença de {n1} entre {n2} é {n3}.");
        }
    }
}
