using System;

namespace PrimeiroArquivo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var minimoPecas = 0f; ;
            var maximoPecas = 0f;
            var estoqueMedio = 0f;

            Console.WriteLine("Quantidade mínima de peças: ");
            minimoPecas = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade máxima de peças: ");
            maximoPecas = float.Parse(Console.ReadLine());
            estoqueMedio = (minimoPecas + maximoPecas) / 2;
            Console.WriteLine("O estoque médio é de " + estoqueMedio + " peças.");
        }
    }
}