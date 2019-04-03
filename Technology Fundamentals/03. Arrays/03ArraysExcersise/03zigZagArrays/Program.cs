using System;
using System.Linq;

namespace _03zigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] firstArr = new int[num];
            int[] secondArr = new int[num];

            for (int i = 0; i < num; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (i % 2 ==0)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        firstArr[i] = input[0];
                        secondArr[i] = input[1];
                    }
                }

                else if (i % 2 != 0)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        firstArr[i] = input[1];
                        secondArr[i] = input[0];
                    }
                }

            }

            string outputFirstArr = string.Join(" ", firstArr);
            string outputSecondArr = string.Join(" ", secondArr);

            Console.WriteLine(outputFirstArr);
            Console.WriteLine(outputSecondArr);

        }
    }
}
