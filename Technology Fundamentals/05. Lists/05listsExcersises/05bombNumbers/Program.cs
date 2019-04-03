using System;
using System.Collections.Generic;
using System.Linq;

namespace _05bombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int j = 0; j < collection.Count; j++)
            {
                if (collection[j] == bombNumbers[0])
                {
                    int start = 0;
                    if (j - bombNumbers[1] < 0)
                    {
                        start = 0;
                    }
                    else
                    {
                        start = j - bombNumbers[1];
                    }
                    int end = 0;
                    if (j + bombNumbers[1] > collection.Count)
                    {
                        end = collection.Count;
                    }
                    else
                    {
                        end = j + bombNumbers[1] + 1;
                    }

                    for (int i = start; i < end; i++)
                    {
                        collection[i] = 0;
                    }
                }
            }

            Console.WriteLine(collection.Sum());
        }
    }
}

