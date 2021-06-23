using System;

namespace Exercícios3_Q28
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int n = 100; n <= 200; n++)
            {
                if (n % 2 != 0)
                    Console.WriteLine($"{n}");
            }
                
        }
    }
}
