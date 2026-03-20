using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0)
            {
                int quadrado = i * i;
                Console.WriteLine($"{i}^2 = {quadrado}");
            }
        }
    }
}