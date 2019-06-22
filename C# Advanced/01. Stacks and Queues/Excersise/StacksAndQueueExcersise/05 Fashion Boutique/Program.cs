using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Fashion_Boutique
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(input);
            int rackCapacity = int.Parse(Console.ReadLine());
            int racksTaken = 0;
            int sum = 0;
            while (stack.Count > 0)
            {
                if (sum + stack.Peek() <= rackCapacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    racksTaken++;
                    sum = 0;
                }
                if (sum> 0 && stack.Count == 0)
                {
                    racksTaken++;
                    sum = 0;
                }

            }
            Console.WriteLine(racksTaken);
        }
    }
}
