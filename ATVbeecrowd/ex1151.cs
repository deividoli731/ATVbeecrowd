using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        int a = 0, b = 1;

        for (int i = 0; i < N; i++)
        {
            if (i == 0)
            {
                Console.Write(a);
            }
            else if (i == 1)
            {
                Console.Write(" " + b);
            }
            else
            {
                int c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
        }

        Console.WriteLine();
    }
}