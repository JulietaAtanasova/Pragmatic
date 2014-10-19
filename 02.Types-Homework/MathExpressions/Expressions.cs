using System;

class Expressions
{
    static void Main()
    {
        int x = 5;

        double firstSolution = (Math.Sin(x) / Math.Abs(x)) + Math.Pow(10, x);
        double secondSoluton = 2 * (Math.Pow(10, Math.Abs(x)) / (x + Math.Pow(5, 2)));
        double thirdSolution = Math.Pow((2 * x + x), (1.0 / 3.0));
        double fourthSolution = Math.Pow(x, 10) / (2 * x) - Math.Abs(x) / 2;
        double fifthSolution = x + Math.Pow(10, (2 * x)) / Math.Cos(x) + Math.Abs(100 - Math.Pow(x, 2));
        double sixSolution = (5 * x * Math.Sqrt(100)) + ((x / 2) * x);

    }
}
