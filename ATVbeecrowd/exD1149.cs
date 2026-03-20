using System;

class Program
{
    static void Main()
    {
        string[] entrada = Console.ReadLine().Split(' ');

        int A = int.Parse(entrada[0]);
        int N = 0;

        // Encontrar o primeiro N positivo
        for (int i = 1; i < entrada.Length; i++)
        {
            int valor = int.Parse(entrada[i]);
            if (valor > 0)
            {
                N = valor;
                break;
            }
        }

        int soma = 0;

        for (int i = 0; i < N; i++)
        {
            soma += A + i;
        }

        Console.WriteLine(soma);
    }
}