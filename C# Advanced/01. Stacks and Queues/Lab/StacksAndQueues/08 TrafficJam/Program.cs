using System;
using System.Collections.Generic;

namespace _08_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            Queue<string> queue = new Queue<string>();

            string input = Console.ReadLine();
            while (input?.ToLower() != "end")
            {
                if (input?.ToLower() == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count >= n-i)
                        {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                        }

                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");

        }
    }
}
