using System;
class MaxMinAverageNumber
{
    static void Main()
    {
        Console.WriteLine("Enter count of numbers: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter numbers: ");
        int[] array = new int[n];
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }

        Array.Sort(array);
        int min = array[0];
        int max = array[n - 1];
        double average = sum / n;
        Console.Clear();
        Console.WriteLine("Min: {0}\nMax: {1}\nAverage: {2:F2}", min, max, average);
    }
}