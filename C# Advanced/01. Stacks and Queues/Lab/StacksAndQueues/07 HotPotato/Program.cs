using System;
using System.Collections.Generic;

namespace _07_HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(kids);


            while (queue.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
