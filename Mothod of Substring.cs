using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        String ad = "ahmet";
        for (int i = 0; i < ad.Length; i++)
            Console.WriteLine(ad.Substring(4-i,1+i));

        Console.ReadLine();

    }
}
