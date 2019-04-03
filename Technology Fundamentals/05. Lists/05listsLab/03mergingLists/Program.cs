using System;
using System.Collections.Generic;
using System.Linq;

namespace _03mergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var result = new List<int>();

            var maxIndex = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < maxIndex; i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }

            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
