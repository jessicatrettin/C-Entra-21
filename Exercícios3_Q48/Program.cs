using System;

namespace Exercícios3_Q48
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nome = new string[20];
            int[] idade = new int[20];
            string[] apta = new string[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Nome da candidata: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade da candidata: ");
                idade[i] = int.Parse(Console.ReadLine());
                if (idade[i] >= 18 && idade[i] <= 20)
                {
                    apta[i] = nome[i];
                }
            }
            Console.WriteLine("As candidatas aptas para a campanha são:");
            for (int i = 0; i < apta.Length; i++)
            {
                if (!String.IsNullOrEmpty(apta[i]))
                {
                    Console.WriteLine(apta[i]);
                }
            }
        }
    }
}
