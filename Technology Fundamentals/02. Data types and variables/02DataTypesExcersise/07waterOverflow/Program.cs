using System;

namespace _07waterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int filled = 0;
            int capacity = 255;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current > capacity - filled)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    filled += current;
                }
            }
            Console.WriteLine(filled);
        }
    }
}
