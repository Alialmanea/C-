using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        string[] hucre = new string[100];

        for (int i = 0; i < 100; i++)
        {
            hucre[i] = "Kaplı";

        }
        for (int i = 1; i <= 100; i++)
        {
            for (int j = i; j <= 100; j = j + i)
            {
                if (hucre[j - 1] == "Kaplı")
                    hucre[j - 1] = "Açık";
                else
                    hucre[j - 1] = "Kaplı";

            }


        }

        for (int i = 0; i < 100; i++)
            Console.WriteLine(1+i+".hucre :"+ hucre[i]);



        Console.ReadLine();

    }
}
