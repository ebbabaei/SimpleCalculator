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

Console.WriteLine("Please enter the first number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number:");
int num2 = int.Parse(Console.ReadLine());
CalculatorUtility calc2 = new CalculatorUtility();
int sumResult = calc.Sum(num1, num2);
int subResult = calc.Subtract(num1, num2);

Console.WriteLine($"Sum result: {sumResult}");
Console.WriteLine($"Subtract result: {subResult}");


Console.WriteLine("Press any key to exit...");
Console.ReadKey();
     