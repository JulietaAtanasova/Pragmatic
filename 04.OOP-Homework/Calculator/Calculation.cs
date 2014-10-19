using System;

namespace Calculator
{
    class Calculation
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int y = int.Parse(Console.ReadLine());

            Calculator calc = new Calculator();
            calc.a = x;
            calc.b = y;

            Console.WriteLine("Sum: {0}", calc.Sum(calc.a, calc.b));
            Console.WriteLine("Sub: {0}", calc.Sub(calc.a, calc.b));
            Console.WriteLine("Mul: {0}", calc.Mul(calc.a, calc.b));
            Console.WriteLine("Div: {0:F2}", calc.Div(calc.a, calc.b));

        }
    }
}
