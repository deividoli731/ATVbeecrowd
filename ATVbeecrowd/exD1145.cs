using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite X e Y: ");
        string[] valores = Console.ReadLine().Split(' ');

        int X = int.Parse(valores[0]);
        int Y = int.Parse(valores[1]);

        for (int i = 1; i <= Y; i++)
        {
            Console.Write(i);

            if (i % X == 0)
                Console.WriteLine();
            else if (i != Y)
                Console.Write(" ");
        }
    }
}