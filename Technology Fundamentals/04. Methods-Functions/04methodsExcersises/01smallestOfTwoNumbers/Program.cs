using System;

namespace _01smallestOfThreeoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(FindSmallestNumber(numbers));

        }

        private static int FindSmallestNumber(int[] numbers)
        {
            int smallest = numbers[0];
            for (int i = 1; i < 3; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            return smallest;
        }
    }
}
