using System;

namespace Exercícios1_Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 0, c = 0;

            Console.Write("Temperatura em ºF: ");
            f = float.Parse(Console.ReadLine());
            c = ((f - 32) * 5) / 9;
            Console.WriteLine("Temperaturaa em ºC: " + c);
        }
    }
}
