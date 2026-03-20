using System;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Z;

        // Ler até Z ser maior que X
        do
        {
            Z = int.Parse(Console.ReadLine());
        } while (Z <= X);

        int soma = 0;
        int contador = 0;
        int numero = X;

        // Somar até ultrapassar Z
        while (soma <= Z)
        {
            soma += numero;
            numero++;
            contador++;
        }

        Console.WriteLine(contador);
    }
}