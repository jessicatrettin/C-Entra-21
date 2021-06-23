using System;

namespace Exercícios1_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            float c = 0, f = 0;

            Console.Write("Temperatura em ºC: ");
            c = float.Parse(Console.ReadLine());
            f = ((9 * c) + 160) / 5;
            Console.WriteLine("Temperatura em ºF: " + f);
        }
    }
}
