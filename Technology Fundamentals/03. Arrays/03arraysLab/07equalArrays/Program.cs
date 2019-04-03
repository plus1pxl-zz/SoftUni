using System;
using System.Linq;

namespace _07equalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers2 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < numbers1.Length; i++)
            {
                sum1 += numbers1[i];
                sum2 += numbers2[i];
                if (numbers1[i] != numbers2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum1}");
            }


        }
    }
}
