using System;

namespace Exercícios2_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, modulo = 0;
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            if (n >= 0)
                modulo = n;
            else
                modulo = n * (-1);
            Console.WriteLine($"Módulo de {n} é {modulo}");
        }
    }
}
