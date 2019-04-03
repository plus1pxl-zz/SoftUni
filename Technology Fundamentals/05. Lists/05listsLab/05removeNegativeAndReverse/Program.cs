using System;
using System.Collections.Generic;
using System.Linq;

namespace _05removeNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var positiveNumbers = new List<int>();
            foreach (var number  in numbers)
            {
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }

            if (positiveNumbers.Count != 0)
            {
                positiveNumbers.Reverse();
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
