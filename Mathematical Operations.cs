using System;


class Program
{
    static void Main()
    {
        //Reading First Number
        there:
        Console.Write("Enter No1: ");
        int a = Convert.ToInt16(Console.ReadLine());
        //Reading Second Number  
        Console.Write("Enter No2: ");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(" + .Addition");
        Console.WriteLine(" - .Subtraction");
        Console.WriteLine(" / .Divsion");
        Console.WriteLine(" X .Multiplication");
        //Reading a Choice  
        char c = Convert.ToChar(Console.ReadLine());
        string yorN;
        switch (c)
        {
            case '+':
                Console.WriteLine("Addition Of Two Numbers : " + (a + b));
                Console.WriteLine("Do you want to make anothor operation ? Y/N");
                yorN = Console.ReadLine();
                if (yorN == "Yes" || yorN == "Y")
                {
                    goto there;
                }
                else
                    goto Out;
                break;
            case '-':
                Console.WriteLine("Subtraction Of Two Numbers : " + (a - b));
                Console.WriteLine("Do you want to make anothor operation ? Y/N");
                yorN = Console.ReadLine();
                if (yorN == "Yes" || yorN == "Y")
                {
                    goto there;
                }
                else
                    goto Out;
                break;
            case '/':
                Console.WriteLine("Division Of Two Numbers : " + (a / b));
                Console.WriteLine("Do you want to make anothor operation ? Y/N");
                yorN = Console.ReadLine();
                if (yorN == "Yes" || yorN == "Y")
                {
                    goto there;
                }
                else
                    goto Out;
                break;
            case 'x':
                Console.WriteLine("Multiplicaion Of Two Numbers : " + (a * b));
                Console.WriteLine("Do you want to make anothor operation ? Y/N");
                yorN = Console.ReadLine();
                if (yorN == "Yes" || yorN == "Y")
                {
                    goto there;
                }
                else
                    goto Out;
                break;
            default:
                Console.WriteLine("Choose Only + - / X ");
                Console.WriteLine("Do you want to make anothor operation ? Y/N");
                 yorN = Console.ReadLine();
                if (yorN == "Yes" || yorN == "Y")
                {
                    goto there;
                }
                else
                    goto Out;
                break;
        }
       Out: 
        Console.ReadLine();
    }
}
