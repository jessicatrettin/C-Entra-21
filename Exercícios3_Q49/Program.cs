using System;

namespace Exercícios3_Q49
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 5, identicos = 0;
            int[] v1 = new int[c];
            int[] v2 = new int[c];

            Console.WriteLine("Valores de V1");
            for (int i = 0; i < c; i++)
            {
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Valores de V2");
            for (int i = 0; i < c; i++)
            {
                v2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < c; i++)
            {
                if (v1[i] == v2[i])
                {
                    identicos += 1;
                } 
            }
            Console.WriteLine($"Em {identicos} posições os valores de V1 e V2 são idênticos.");
        }
    }
}
