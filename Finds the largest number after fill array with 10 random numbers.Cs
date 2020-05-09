using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        int Maxnum=0;
        bool Isfirsttime=true;
        Random rnd  = new Random();


        //fll array with random nums
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rnd.Next(-10,10);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (Isfirsttime == true) {
                Maxnum = arr[i];
                Isfirsttime = false;
            }

            if (Maxnum < arr[i])
                Maxnum = arr[i];
        }


        //print array
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
                Console.Write("[" + arr[i]);
            else if (i == arr.Length - 1)
                Console.Write("," + arr[i] + "]");
            else Console.Write(","+arr[i]);
        }


        Console.WriteLine("\n The Max Number in array is :"+Maxnum);

    }
}
