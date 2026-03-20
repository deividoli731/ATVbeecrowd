using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de X: ");
        int X = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de Y: ");
        int Y = int.Parse(Console.ReadLine());

        int menor = Math.Min(X, Y);
        int maior = Math.Max(X, Y);

        int soma = 0;

        for (int i = menor; i <= maior; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine("Soma: " + soma);
    }
}