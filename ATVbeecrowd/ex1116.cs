using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Quantos pares de valores? ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite X e Y do {i + 1}º par: ");
            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            if (Y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double resultado = (double)X / Y;
                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}