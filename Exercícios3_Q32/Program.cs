using System;

namespace Exercícios3_Q32
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, n = 0, quadrado = 0, somaQuadrado = 0;
            while (cont < 20)
            {
                Console.Write("Digite um número: ");
                
                n = int.Parse(Console.ReadLine());
                if (n > 0 && n < 10)
                {
                    if (n % 2 != 0)
                    {
                        quadrado = n * n;
                        somaQuadrado += quadrado;
                        cont += 1;
                    }
                }
            }
            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ípares, dentro do intervalo de 0 e 10 é {somaQuadrado}.");

        }
    }
}
