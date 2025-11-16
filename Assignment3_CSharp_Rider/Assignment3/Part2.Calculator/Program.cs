using System;
using Part2.CalculatorLib;

namespace Part2.CalculatorApp;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("=== Simple Calculator Demo ===");

        Console.Write("Enter first number (A): ");
        var a = ReadDoubleFromConsole();

        Console.Write("Enter second number (B): ");
        var b = ReadDoubleFromConsole();

        Console.Write("Enter operation (+, -, *, /): ");
        var opInput = Console.ReadLine();
        var op = string.IsNullOrWhiteSpace(opInput) ? '+' : opInput.Trim()[0];

        try
        {
            var calculator = new Calculator(a, b, op);
            var result = calculator.Calculate();
            Console.WriteLine($"Result: {a} {op} {b} = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private static double ReadDoubleFromConsole()
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (double.TryParse(input, out var value))
                return value;

            Console.Write("Invalid number, try again: ");
        }
    }
}
