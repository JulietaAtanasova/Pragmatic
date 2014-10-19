using System;
using System.Collections.Generic;

namespace CheckNumbers
{
    class CheckNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers in range [0...100]. The program will ends when you enter 0.");
            List<int> numbers = new List<int>();
            double sum = 0;
            while(true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                if (n < 0 || n > 100)
                {
                    Console.WriteLine("This number is out of range. Try again:");
                    continue;
                }
                numbers.Add(n);
                sum += n;
            }

            Console.Clear();
            int lastNumber = numbers[numbers.Count - 1];
            PrintRevesedList(numbers);
            PrintNumbersBiggerThanAverage(numbers, sum);
            Console.WriteLine("Count of last number: {0}", CountNumber(numbers, lastNumber));

        }
        static void PrintRevesedList(List<int> list)
        {
            list.Reverse();
            Console.WriteLine("Reversed numbers: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void PrintNumbersBiggerThanAverage(List<int> list, double sum)
        {
            double average = sum / list.Count;
            Console.WriteLine("Numbers bigger than average number: ");
            foreach (var item in list)
            {
                if (item > average)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

        static int CountNumber(List<int> list, int number)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item == number)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
