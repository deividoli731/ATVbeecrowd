using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Quantos casos de teste? ");
        int N = int.Parse(Console.ReadLine());

        int total = 0;
        int coelhos = 0;
        int ratos = 0;
        int sapos = 0;

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite quantidade e tipo (C, R ou S) do {i + 1}º teste: ");
            string[] entrada = Console.ReadLine().Split(' ');

            int quantidade = int.Parse(entrada[0]);
            char tipo = char.Parse(entrada[1].ToUpper());

            total += quantidade;

            if (tipo == 'C')
                coelhos += quantidade;
            else if (tipo == 'R')
                ratos += quantidade;
            else if (tipo == 'S')
                sapos += quantidade;
        }

        double percCoelhos = (double)coelhos / total * 100;
        double percRatos = (double)ratos / total * 100;
        double percSapos = (double)sapos / total * 100;

        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelhos);
        Console.WriteLine("Total de ratos: " + ratos);
        Console.WriteLine("Total de sapos: " + sapos);

        Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de ratos: " + percRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de sapos: " + percSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
    }
}