using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        double tavsan = 500;
        double tavuk = 1750;
        int yil = 0;
        while (tavsan<=tavuk)
        {
            tavsan += tavsan * 17 / 100;
            tavuk += tavuk * 92 / 1000;
            yil += 1;

        }
        Console.WriteLine(yil);
        Console.ReadLine();

    }
}
