using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int nPush = tokens[0];
            int nPop = tokens[1];
            int match = tokens[2];

            var stackElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < nPush; i++)
            {
                stack.Push(stackElements[i]);
            }
            for (int i = 0; i < nPop; i++)
            {
                if (stack.Count >0)
                {
                    stack.Pop();
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(match))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestElement = Int32.MaxValue;
                foreach (var element in stack)
                {
                    if (smallestElement > element)
                    {
                        smallestElement = element;
                    }
                }
                Console.WriteLine(smallestElement);
            }
        }
    }
}
