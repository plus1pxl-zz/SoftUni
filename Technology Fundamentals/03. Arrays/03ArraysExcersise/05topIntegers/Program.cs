using System;
using System.Linq;

namespace _05topIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int counter = 0;
            int[] outputArr = new int[0];

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i+1])
                {
                    counter += 1 ;
                    Array.Resize(ref outputArr, counter);
                    outputArr[counter - 1] = input[i];
                }
            }
            counter += 1;
            Array.Resize(ref outputArr, counter);
            outputArr[counter - 1] = input[input.Length - 1];


            string output = string.Join(" ", outputArr);

            Console.WriteLine(output);
        }
    }
}
