using System;

namespace Exercícios2.Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            float v2 = float.Parse(Console.ReadLine());
            if (v1 > v2)
            {
                Console.WriteLine($"O maior valor é {v1} e o menor valor é {v2}.");
            }
            else if (v2 > v1)
            {
                Console.WriteLine($"O maior valor é {v2} e o menor valor é {v1}.");
            }
            else
            {
                Console.WriteLine($"Os valores são iguais.");
            }
        }
    }
}
