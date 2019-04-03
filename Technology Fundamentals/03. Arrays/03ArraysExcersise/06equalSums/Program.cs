using System;
using System.Linq;

namespace _06equalSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            if (input.Length >= 2)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int sumLeft = 0;
                    int sumRight = 0;

                    for (int j = 0; j < i; j++)
                    {
                        sumLeft += input[j];
                    }
                    for (int k = i+1; k < input.Length; k++)
                    {
                        sumRight += input[k];
                    }
                    if (sumLeft == sumRight)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    else if (i == input.Length-1)
                    {
                        Console.WriteLine("no");
                    }
                }

            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
