using System;
class Program
{
    static void Main(string[] args)
    {
        int[] student = new int[25];

        int k = 0;
        for (int i = 0; i < student.Length; i++)
        {
            student[i] = ++k;
        }
   
        Random rnd = new Random();
        int max = 24;

        for (int j = 0; j < student.Length-1; j++)
        {
            System.Threading.Thread.Sleep(6000); //6sn

            int index = rnd.Next(0, max);

            student[index] = student[max];
            student[max] = -1;
            max--;
            for (int i = 0; i < student.Length; i++)
            {
                Console.Write(student[i] + ",");
            }
            Console.WriteLine();
        }
        Console.WriteLine("En son kalan öğrenci =" + student[0] + ". öğrenci");

    }
}
