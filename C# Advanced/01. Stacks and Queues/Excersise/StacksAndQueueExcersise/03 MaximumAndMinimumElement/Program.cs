using System;
using System.Collections.Generic;

namespace _03_MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            if (queries > 105)
            {
                queries = 105;
            }
            else if (queries < 1)
            {
                queries = 1;
            }
            Stack<int> stack = new Stack<int>();
            int min = Int32.MaxValue;
            int max = Int32.MinValue;


            for (int i = 0; i < queries; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "1")
                {
                    int elementToPush = int.Parse(tokens[1]);
                    if (elementToPush >= 1 && elementToPush <= 109)
                    {
                        stack.Push(elementToPush);
                    }
                }
                else if (tokens[0] == "2")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (tokens[0] == "3" && stack.Count > 0)
                {
                    foreach (var item in stack)
                    {
                        if (item > max)
                        {
                            max = item;
                        }
                    }
                    Console.WriteLine(max);
                }
                else if (tokens[0] == "4" && stack.Count > 0)
                {
                    foreach (var item in stack)
                    {
                        if (item < min)
                        {
                            min = item;
                        }
                    }
                    Console.WriteLine(min);
                }
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
                if (stack.Count > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
