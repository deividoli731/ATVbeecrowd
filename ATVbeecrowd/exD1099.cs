using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos casos de teste? ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite X e Y do {i + 1}º caso: ");
            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            int menor = Math.Min(X, Y);
            int maior = Math.Max(X, Y);

            int soma = 0;

            for (int j = menor + 1; j < maior; j++)
            {
                if (j % 2 != 0)
                {
                    soma += j;
                }
            }

            Console.WriteLine("Soma: " + soma);
        }
    }
}