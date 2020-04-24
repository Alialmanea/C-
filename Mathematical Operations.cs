using System;  
class Program  
{  
static void Main()  
{  
//Reading First Number  
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
switch(c)  
{  
case +:  
   Console.WriteLine("Addition Of Two Numbers : "+(a+b));  
   break;  
case -:  
   Console.WriteLine("Subtraction Of Two Numbers : " + (a - b));  
   break;  
case /:  
    Console.WriteLine("Division Of Two Numbers : " + (a / b));  
    break;  
case x:  
   Console.WriteLine("Multiplicaion Of Two Numbers : " + (a * b));  
   break;    
default:  
   Console.WriteLine("Choose Only + - / X ");  
break;  
}  
Console.ReadLine();  
}  
}
