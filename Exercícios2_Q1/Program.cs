using System;

namespace Exercícios2_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor");
            int b = int.Parse(Console.ReadLine());
            int aux = a;
            a = b;
            Console.WriteLine($"O 1º valor era {aux} e passou a ser {b}.");
            Console.WriteLine($"O 2º valor era {a} e passou a ser {aux}.");
        }
    }
}
