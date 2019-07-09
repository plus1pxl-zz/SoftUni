using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int lowerBounds = bounds[0];
            int upperBounds = bounds[1];

            List<int> numbers = new List<int>();

            string numberType = Console.ReadLine();

            for (int i = lowerBounds; i <= upperBounds; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = n 
                => n % 2 == 0;

            Predicate<int> isOdd = n
                => n % 2 != 0;

            Action<List<int>> printNumbers = outputNumbers 
                => Console.WriteLine(string.Join(" ", outputNumbers));

            if (numberType == "odd")
            {
                numbers = numbers
                    .Where(x => isOdd(x))
                    .ToList();
            }
            else if (numberType == "even")
            {
                numbers = numbers
                    .Where(x => isEven(x))
                    .ToList();
            }
            printNumbers(numbers);
        }
    }
}
