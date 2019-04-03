using System;
using System.Linq;

namespace _02characterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();
            string wordA = words[0];
            string wordB = words[1];

            int sum = 0;

            if (wordA.Length == wordB.Length)
            {
                sum = SumOfCharacterCodes(wordA, wordB);
            }
            else if (wordA.Length > wordB.Length)
            {
                sum = SumOfCharacterCodes(wordA, wordB);
                for (int i = wordA.Length -1; i > wordB.Length -1; i--)
                {
                    sum += wordA[i];
                }
            }
            else if (wordA.Length < wordB.Length)
            {
                sum = SumOfCharacterCodes(wordA, wordB);
                for (int i = wordB.Length-1; i > wordA.Length-1; i--)
                {
                    sum += wordB[i];
                }
            }
            Console.WriteLine(sum);
        }

        private static int SumOfCharacterCodes(string wordA, string wordB)
        {
            int sum = 0;
            for (int i = 0; i < wordA.Length; i++)
            {
                char A = wordA[i];
                char B = wordB[i];
                sum += A * B;
            }
            return sum;
        }

    }
}
