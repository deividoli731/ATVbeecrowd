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

        for (int i = menor + 1; i < maior; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}