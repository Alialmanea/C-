using System;

class Program
{
    static void Main(string[] args)
    {
        int d = 0;

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                d = i * j;
                Console.Write("{0} * {1} = {2}\n", i, j, d);
                // Console.WriteLine();
            }
            Console.WriteLine("\t");

        }

        Console.ReadLine();

    }
}
