using System;
using System.Linq;

namespace _09kaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int longestSubSq = -1;
            int longestSubSqIndex = -1;
            int longestSubSum = -1;
            int indexOfSequence = 1;
            int indexOfLongest = 0;

            int[] bestSequence = new int[length];

            string input = Console.ReadLine();

            

            while (input != "Clone them!")
            {
                int[] currentSeqence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int subSq = 0;
                int SubSqIndex = -1;
                int subSum = 0;

                int count = 0;
                for (int i = 0; i < length; i++)
                {
                    if (currentSeqence[i] == 1)
                    {
                        count++;
                        subSum++;
                        if (count > subSq)
                        {
                            subSq = count;
                            SubSqIndex = i - count;
                        }
                    }

                    else
                    {

                        count = 0;
                    }

                }
                if (subSq > longestSubSq)
                {
                    longestSubSqIndex = SubSqIndex;
                    longestSubSq = subSq;
                    longestSubSum = subSum;
                    bestSequence = currentSeqence;
                    indexOfLongest = indexOfSequence;
                }
                else if (subSq == longestSubSq
                    && longestSubSqIndex > SubSqIndex)
                {
                    longestSubSqIndex = SubSqIndex;
                    longestSubSum = subSum;
                    bestSequence = currentSeqence;
                    indexOfLongest = indexOfSequence;

                }
                else if (subSq == longestSubSq
                    && longestSubSqIndex == SubSqIndex
                    && longestSubSum < subSum)
                {
                    longestSubSum = subSum;
                    bestSequence = currentSeqence;
                    indexOfLongest = indexOfSequence;
                }

                indexOfSequence++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {indexOfLongest} with sum: {longestSubSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));



        }
    }
}
