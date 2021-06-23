using System;

namespace Exercícios3_Q30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- TABUADA ----------------");
            Console.Write("Digite um valor para ver sua tabuada: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            for(int mult = 1; mult <= 10; mult++)
            {
                int tab = mult * num;
                Console.WriteLine($"{mult} x {num} = {tab}");
            }
        }
    }
}
