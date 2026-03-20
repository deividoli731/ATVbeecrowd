using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            int soma = 0;

            // Se X for par, vai para o próximo ímpar
            if (X % 2 == 0)
            {
                X++;
            }

            for (int j = 0; j < Y; j++)
            {
                soma += X;
                X += 2; // próximo ímpar
            }

            Console.WriteLine(soma);
        }
    }
}