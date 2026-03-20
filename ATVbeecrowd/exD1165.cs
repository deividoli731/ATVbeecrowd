using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());
            bool ehPrimo = true;

            if (X < 2)
                ehPrimo = false;
            else
            {
                for (int j = 2; j < X; j++)
                {
                    if (X % j == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
            }

            if (ehPrimo)
                Console.WriteLine($"{X} eh primo");
            else
                Console.WriteLine($"{X} nao eh primo");
        }
    }
}