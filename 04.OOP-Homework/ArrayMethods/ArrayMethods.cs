using System;

namespace ArrayMethods
{
    class ArrayMethods
    {
        static void Main()
        {
            int[] numbers = new int[5];
            ReadArray(numbers);
            Console.WriteLine("Average: {0:F2}", AverageNumberFromArray(numbers));
            Console.Write("Numbers bigger than 5: ");
            PrintNumbersBiggerThanNumber(numbers, 5);
        }

        static int[] ReadArray(int[] array)
        {
            Console.WriteLine("Enter {0} numbers: ", array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        static double AverageNumberFromArray(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double average = sum / array.Length;
            return average;
        }

        static void PrintNumbersBiggerThanNumber(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > number)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}