using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        string str;
        str = Console.ReadLine();

        string[] words = str.Split(' ');

        for (int i = 0; i < words.Length; i++) {
            Console.WriteLine(i+"."+words[i]);
            if (words[i].EndsWith("a") || words[i].EndsWith("A")) {
                Console.WriteLine(words[i]);
            }
        }
    }
}
