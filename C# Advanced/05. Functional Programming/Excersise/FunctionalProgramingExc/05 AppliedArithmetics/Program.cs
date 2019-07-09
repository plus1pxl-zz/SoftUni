using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Func<int, int> incrementByOne = x => x += 1;
            Func<int, int> multiplyByTwo = x => x *= 2;
            Func<int, int> SubtractByOne = x => x -= 1;
            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    inputNumbers = inputNumbers.Select(incrementByOne).ToArray();
                }
                else if (command == "multiply")
                {
                    inputNumbers = inputNumbers.Select(multiplyByTwo).ToArray();
                }
                else if (command == "subtract")
                {
                    inputNumbers = inputNumbers.Select(SubtractByOne).ToArray();
                }
                else if (command == "print")
                {
                    print(inputNumbers);
                }
                command = Console.ReadLine();
            }
        }
    }
}
