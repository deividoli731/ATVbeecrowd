using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos valores você vai digitar? ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                string parOuImpar = (valor % 2 == 0) ? "EVEN" : "ODD";
                string sinal = (valor > 0) ? "POSITIVE" : "NEGATIVE";

                Console.WriteLine($"{parOuImpar} {sinal}");
            }
        }
    }
}