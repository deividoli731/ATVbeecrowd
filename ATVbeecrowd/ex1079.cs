using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Quantos casos de teste? ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite 3 valores (separados por espaço) para o {i + 1}º teste: ");
            string[] valores = Console.ReadLine().Split(' ');

            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double media = (a * 2 + b * 3 + c * 5) / 10.0;

            Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}