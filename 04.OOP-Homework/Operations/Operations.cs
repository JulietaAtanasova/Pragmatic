using System;
class Operations
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose type of operation:\n +, -, *, /");
        string operation = Console.ReadLine();

        Console.WriteLine("Enter a number:");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Clear();
        Calculate(firstNumber, operation, secondNumber);
    }

    private static void Calculate(double firstNumber, string operation, double secondNumber)
    {
        double result = firstNumber;
        switch (operation)
        {
            case "+":
                result += secondNumber;
                PrintNumberWithTwoDigitsAfterDecimalPoint(result);
                break;
            case "-":
                result -= secondNumber;
                PrintNumberWithTwoDigitsAfterDecimalPoint(result);
                break;
            case "*":
                result *= secondNumber;
                PrintNumberWithTwoDigitsAfterDecimalPoint(result);
                break;
            case "/":
                result /= secondNumber;
                PrintNumberWithTwoDigitsAfterDecimalPoint(result);
                break;
            default:
                Console.WriteLine("Unsupported operation");
                break;
        }
    }

    static void PrintNumberWithTwoDigitsAfterDecimalPoint(double number)
    {
        Console.WriteLine("The result is: {0:F2}", number);
    }
}