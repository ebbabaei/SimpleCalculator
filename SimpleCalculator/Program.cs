// See https://aka.ms/new-console-template for more information
using SimpleCalculator;

Console.WriteLine("=================================");
Console.WriteLine("        Simple Calculator        ");
Console.WriteLine("=================================");
Console.WriteLine("A basic console application for simple math operations.");

Console.WriteLine("Developed by Bugeto.net");
Console.WriteLine();     

Console.WriteLine("This is the initial version. More features coming soon!");
Console.WriteLine();


CalculatorUtility calc = new CalculatorUtility();

// ورودی امن با TryParse
int ReadInt(string prompt)
{
    while (true)
    {
        Console.WriteLine(prompt);
        var input = Console.ReadLine();
        if (int.TryParse(input, out var value))
            return value;


        Console.WriteLine("Invalid number. Please try again.");
    }
}
int num1 = ReadInt("Please enter the first number:");
int num2 = ReadInt("Please enter the second number:");

Console.WriteLine();
Console.WriteLine("Select an operation:");
Console.WriteLine("1) Sum (+)");
Console.WriteLine("2) Multiply (×)");
Console.WriteLine("3) Divide (÷)");
Console.WriteLine("4) Subtract (−)");
Console.Write("Your choice: ");

var choice = Console.ReadLine();

try
{
    int result = choice switch
    {
        "1" => calc.Sum(num1, num2),
        "2" => calc.Multiply(num1, num2),
        "3" => calc.Divide(num1, num2),
        "4" =>  calc.Subtract(num1, num2),
    };


    Console.WriteLine();
    Console.WriteLine($"Total result: {result}");
}
catch (Exception ex)
{
    Console.WriteLine();
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();