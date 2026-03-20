using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int PA = int.Parse(valores[0]);
            int PB = int.Parse(valores[1]);
            double G1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double G2 = double.Parse(valores[3], CultureInfo.InvariantCulture);

            int anos = 0;

            while (PA <= PB)
            {
                PA += (int)(PA * (G1 / 100));
                PB += (int)(PB * (G2 / 100));
                anos++;

                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                    break;
                }
            }

            if (anos <= 100)
            {
                Console.WriteLine(anos + " anos.");
            }
        }
    }
}