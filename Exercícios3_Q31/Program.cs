using System;

namespace Exercícios3_Q31
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, parSoma = 0, imparSoma = 0; 
            
            Console.WriteLine("Digite valores inteiros positivos");
            Console.WriteLine("(Digite um valor inteiro negativo para parar)");
            
            while (n >= 0)
            {
                if (n > 0)
                {
                    if (n % 2 == 0)
                    {
                        int par = n;
                        Console.WriteLine($"O número {par} é par.");
                        parSoma += par;
                    }
                    else
                    {
                        int impar = n;
                        Console.WriteLine($"O número {impar} é ímpar.");
                        imparSoma += impar;
                    }
                }
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"A soma dos números pares é {parSoma}.");
            Console.WriteLine($"A soma dos números ímpares é {imparSoma}.");
        }
    }
}
