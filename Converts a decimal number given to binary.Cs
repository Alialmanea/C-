using System;
class Program
{
    static void Main(string[] args)
    {
        int number;
        Console.Write("Enter a Number : ");
        number = int.Parse(Console.ReadLine());
        int q;
        string rem = "";
        while (number >= 1)
        {
            q = number / 2;
            rem += (number % 2).ToString();
            number = q;
        }
        string binary = "";
        for (int i = rem.Length - 1; i >= 0; i--)
        {
            binary = binary + rem[i];
        }
        Console.WriteLine("The Binary format for {0} is {1}", number, binary);
    }
}
