using System;

class Program
{
    static void Main()
    {
        int I = 1;
        int J = 60;

        while (J >= 0)
        {
            Console.WriteLine($"I={I} J={J}");
            I += 3;
            J -= 5;
        }
    }
}