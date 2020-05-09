using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{  
    class Program
    {
        
        static void Main(string[] args)
        {
            int Num1,Num2,Num3;
            Num1 = DateTime.Now.Millisecond;
            for (int i=0; i <= 100000; i++)
            {
                Console.WriteLine(++i);
            }
            Num2 = DateTime.Now.Millisecond;
            Num3 = Num2 - Num1;
            Console.WriteLine("{0}.ms", s3);
            Console.ReadKey();

        }
    }
}
