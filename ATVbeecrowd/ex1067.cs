using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int X = int.Parse(Console.ReadLine());

        for (int i = 1; i <= X; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}