using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        int anotherNumber = int.Parse(Console.ReadLine());

        Console.Clear();
        double a = (double)number / (double)anotherNumber;
        Console.WriteLine(number + " + " + anotherNumber + " = " + (number + anotherNumber));
        Console.WriteLine(number + " * " + anotherNumber + " = " + (number * anotherNumber));
        Console.Write(number + " / " + anotherNumber);
        Console.Write(" = {0:F2}", a);
        Console.WriteLine();
        Console.WriteLine(number + " - " + anotherNumber + " = " + (number - anotherNumber));
    }
}