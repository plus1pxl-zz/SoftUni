using System;
using System.Linq;

namespace _02commonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split()
                .ToArray();
            string[] array2 = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (string itemA1 in array1)
            {
                foreach (string itemA2 in array2)
                {
                    if (itemA2 == itemA1)
                    {
                        Console.Write(itemA2 + " ");
                    }
                }
            }
        }
    }
}
