using System;

namespace Exercícios1_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int autonomia = 12;
            int tempo = 0, velocidade = 0;
            float distancia = 0, combustivel = 0;

            Console.Write("Tempo de viagem (minutos): ");
            tempo = int.Parse(Console.ReadLine());
            Console.Write("Velocidade média (km/h): ");
            velocidade = int.Parse(Console.ReadLine());
            distancia = (tempo / 60f) * velocidade;
            combustivel = distancia / autonomia;
            Console.WriteLine("Foram percorridos " + distancia + "km à uma velocidade média de " + velocidade + "km/h.");
            Console.WriteLine("A viagem durou " + tempo + " minutos e foram consumidos " + combustivel + "L de combustível.");
        }
    }
}
