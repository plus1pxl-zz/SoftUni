using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            var commandLine = Console.ReadLine();

            while (commandLine?.ToLower() !="end")
            {
                var tokens = commandLine.Split();
                var command = tokens[0].ToLower();
                if (command == "add")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        stack.Push(int.Parse(tokens[i]));
                    }
                }
                else if (command == "remove")
                {
                    var removeCycles = int.Parse(tokens[1]);
                    if (stack.Count >= removeCycles)
                    {
                        for (int i = 0; i < removeCycles; i++)
                        {
                            stack.Pop();
                        }
                    }

                }
                commandLine = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");


        }
    }
}