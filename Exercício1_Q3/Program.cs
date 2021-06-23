using System;

namespace Exercício1_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int percentualComissao = 5;
            string vendedor = "";
            int codigo = 0, quant = 0;
            float precoUnit = 0, comissao = 0;

            Console.Write("Vendedor(a): ");
            vendedor = Console.ReadLine();
            Console.Write("Código do produto: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Preço unitário: R$ ");
            precoUnit = float.Parse(Console.ReadLine());
            Console.Write("Quantidade vendida: ");
            quant = int.Parse(Console.ReadLine());
            comissao = percentualComissao * precoUnit * quant / 100;
            Console.WriteLine("A comissão do(a) vendedor(a) " + vendedor + " é de R$ " + comissao + ".");
        }
    }
}
