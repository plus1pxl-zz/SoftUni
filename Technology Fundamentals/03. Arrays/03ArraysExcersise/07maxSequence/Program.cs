using System;
using System.Linq;

namespace _07maxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int start = 0;
            int counter = 0;
            int max = 0;

            for (int i = 0; i < input.Length -1; i++)
            {
                if (input[i] == input[i+1])
                {
                    counter++;
                    if (counter > max)
                    {
                        start = i - counter;
                        max = counter;
                    }

                }
                else
                {
                    counter = 0;
                }
            }
            for (int j = start + 1; j <= start + max + 1; j++)
            {
                Console.Write(input[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
