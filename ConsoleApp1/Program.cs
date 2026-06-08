// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
Calculator cal = new Calculator();
Console.WriteLine("please inter num1");


int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("please inter num2");
int num2=int.Parse(Console.ReadLine());
 int  result=cal.sum(num1, num2);
int subtarctResult=cal.subtract(num1,num2);
Console.WriteLine($" sum :{result}");
Console.ReadKey();

