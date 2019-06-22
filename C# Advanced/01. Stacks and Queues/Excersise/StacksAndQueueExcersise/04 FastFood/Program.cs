using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());
            if (qty > 1000)
            {
                qty = 1000;
            }
            int biggestOrder = Int32.MinValue;

            var orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(orders);
            bool ordersToProcess = true;

            while (ordersToProcess)
            {
                if (queue.Count <= 0)
                {
                    ordersToProcess = false;
                }
                else if (queue.Peek() > qty)
                {
                    ordersToProcess = false;
                }
                else
                {
                    if (queue.Peek() > biggestOrder)
                    {
                        biggestOrder = queue.Peek();
                    }
                    qty -= queue.Dequeue();
                    
                }

            }

            Console.WriteLine(biggestOrder);
            if (queue.Count > 0)
            {
                Console.Write("Orders left: ");
                while (queue.Count > 0)
                {
                    Console.Write($"{queue.Dequeue()} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
