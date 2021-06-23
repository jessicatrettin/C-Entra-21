using System;

namespace Exercícios1_Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double v = 0, r = 0, a = 0;

            Console.WriteLine("- Dimensões da lata de óleo -");
            Console.Write("Raio (cm): ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Altura (cm): ");
            a = double.Parse(Console.ReadLine());
            v = pi * r * r * a;
            Console.WriteLine("Volume (cm³): " + v);
        }
    }
}
