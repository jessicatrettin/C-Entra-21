using System;

namespace Exercício1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            float cotacao = 0, montanteDolar = 0, montanteReal = 0;
               
            Console.Write("Cotação do dólar: US$ 1 = R$ ");
            cotacao = float.Parse(Console.ReadLine());
            Console.Write("Valor em dólar: US$ ");
            montanteDolar = float.Parse(Console.ReadLine());
            montanteReal = montanteDolar * cotacao;
            Console.WriteLine("Valor em real: R$ " + montanteReal);
        }
    }
}
