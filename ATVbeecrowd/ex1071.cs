using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro valor: ");
        int X = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        int Y = int.Parse(Console.ReadLine());

        int menor = Math.Min(X, Y);
        int maior = Math.Max(X, Y);

        int soma = 0;

        for (int i = menor + 1; i < maior; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine("Soma dos ímpares entre eles: " + soma);
    }
}