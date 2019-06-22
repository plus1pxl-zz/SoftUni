using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            foreach (var item in input)
            {
                queue.Enqueue(item);
            }

            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    Console.Write(queue.Peek());
                    queue.Dequeue();
                    if (queue.Count > 1)
                    {
                        Console.Write(", ");
                    }
                }
                else
                {
                    queue.Dequeue();
                }

        }
            Console.WriteLine();

        }
    }
}
