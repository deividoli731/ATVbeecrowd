using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos valores você vai digitar? ");
        int N = int.Parse(Console.ReadLine());

        int dentro = 0;
        int fora = 0;

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor >= 10 && valor <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }
        }

        Console.WriteLine($"{dentro} in");
        Console.WriteLine($"{fora} out");
    }
}