vusing System;

namespace Exercícios1_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0, n4 = 0;

            Console.Write("Digite o 1º valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º valor: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 4º valor: ");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("OPERAÇÕES DE SOMA");
            Console.WriteLine("1º valor com 2º valor = " + n1 + " + " + n2 + " = " + (n1 + n2));
            Console.WriteLine("1º valor com 3º valor = " + n1 + " + " + n3 + " = " + (n1 + n3));
            Console.WriteLine("1º valor com 4º valor = " + n1 + " + " + n4 + " = " + (n1 + n4));
            Console.WriteLine("2º valor com 3º valor = " + n2 + " + " + n3 + " = " + (n2 + n3));
            Console.WriteLine("2º valor com 4º valor = " + n2 + " + " + n4 + " = " + (n2 + n4));
            Console.WriteLine("3º valor com 4º valor = " + n3 + " + " + n4 + " = " + (n3 + n4));
            Console.WriteLine("OPERAÇÕES DE MULTIPLICAÇÃO");
            Console.WriteLine("1º valor com 2º valor = " + n1 + " x " + n2 + " = " + (n1 * n2));
            Console.WriteLine("1º valor com 3º valor = " + n1 + " x " + n3 + " = " + (n1 * n3));
            Console.WriteLine("1º valor com 4º valor = " + n1 + " x " + n4 + " = " + (n1 * n4));
            Console.WriteLine("2º valor com 3º valor = " + n2 + " x " + n3 + " = " + (n2 * n3));
            Console.WriteLine("2º valor com 4º valor = " + n2 + " x " + n4 + " = " + (n2 * n4));
            Console.WriteLine("3º valor com 4º valor = " + n3 + " x " + n4 + " = " + (n3 * n4));

        }
    }
}
