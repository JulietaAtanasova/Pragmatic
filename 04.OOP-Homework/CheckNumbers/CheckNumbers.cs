using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckNumbers
{
    class CheckNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers in range [0...100]. The program will ends when you enter 0.");
            List<int> numbers = ReadListOfNumbers();
            PrintReversedList(numbers);
            PrintNumbersBiggerThanAverage(numbers);
            int lastNumber = numbers[numbers.Count - 1];
            Console.WriteLine("Count of last number: {0}", CountNumber(numbers, lastNumber));
        }

        private static List<int> ReadListOfNumbers()
        {
            List<int> numbers = new List<int>();
            while (true)
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
            }
            Console.Clear();
            return numbers;
        }

        static void PrintReversedList(List<int> list)
        {
            list.Reverse();
            Console.WriteLine("Reversed numbers: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            list.Reverse();
        }

        static void PrintNumbersBiggerThanAverage(List<int> list)
        {
            double sum = list.Sum();
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
