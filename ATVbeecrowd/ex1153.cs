using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        int fatorial = 1;

        for (int i = 1; i <= N; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine("Fatorial: " + fatorial);
    }
}