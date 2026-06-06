// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
Calculator cal = new Calculator();
//Console.WriteLine("please inter num1");


//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("please inter num2");
//int num2=int.Parse(Console.ReadLine());

// int  result=cal.sum(num1, num2);
//Console.WriteLine($" sum :{result}");
int ReadInt(string promot)
{
    while (true)
    {
        Console.WriteLine(promot);
        var INPUT=Console.ReadLine();
        if(int.TryParse(INPUT, out int value))
            return value;
        Console.WriteLine("invalid number .please agine");
    }
}
int num1 = ReadInt("please enter number1");
int num2 = ReadInt("please enter number2");
Console.WriteLine();
Console.WriteLine("select an operation");
Console.WriteLine("1) sum(+)");
Console.WriteLine("2) multyPly(*)");
Console.WriteLine("3) divide(%)");
Console.WriteLine("4)subtract(-)");
Console.Write("your choice:");
var choice = Console.ReadLine();
try
{
    int result = choice switch
    {
        "1" => cal.sum(num1, num2),
        "2" => cal.multi(num1, num2),
        "3" => cal.divide(num1, num2),
        "4" => throw new NotImplementedException("this feature  is under development"),

     _ =>  throw new ArgumentOutOfRangeException(nameof(choice), "unknown exception")
    };

    Console.WriteLine();
    Console.WriteLine($"Total Result:{ result}");

}
catch(Exception ex)
{
    Console.WriteLine();
    Console.WriteLine($"Error:{ex.Message}");
}


Console.ReadKey();

