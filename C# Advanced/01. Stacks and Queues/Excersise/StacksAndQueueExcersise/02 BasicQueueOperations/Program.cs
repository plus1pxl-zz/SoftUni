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

            int nEnqueue = tokens[0];
            int nDequeue = tokens[1];
            int match = tokens[2];

            var queueElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < nEnqueue; i++)
            {
                queue.Enqueue(queueElements[i]);
            }
            for (int i = 0; i < nDequeue; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(match))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallestElement = Int32.MaxValue;
                foreach (var element in queue)
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
