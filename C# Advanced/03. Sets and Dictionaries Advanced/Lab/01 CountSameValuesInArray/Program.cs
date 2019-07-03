using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountSameValuesInArray
{
    public class StartUp_0104100
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> numbers = new Dictionary<double, int>();
            foreach (var item in tokens)
            {
                if (numbers.ContainsKey(item))
                {
                    numbers[item] ++;
                }
                else
                {
                    numbers.Add(item, 1);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
