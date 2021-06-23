using System;

namespace Exercícios1_Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos = 0, meses = 0, dias = 0, idadeDias = 0;

            Console.WriteLine("Infome sua idade em Anos, Meses e Dias");
            Console.Write("Anos: ");
            anos = int.Parse(Console.ReadLine());
            Console.Write("Meses: ");
            meses = int.Parse(Console.ReadLine());
            Console.Write("Dias: ");
            dias = int.Parse(Console.ReadLine());
            idadeDias = (anos * 365) + (meses * 30) + dias;
            Console.WriteLine("Você tem " + idadeDias + " dias de idade.");
        }
    }
}
