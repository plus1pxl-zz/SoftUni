using System;

namespace _03charactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            int start = ch1 + 1;
            int end = ch2;

            if (ch1 > ch2)
            {
                start = ch2 + 1;
                end = ch1;
            }

            PrintCharactersInRange(start, end);
        }

        static void PrintCharactersInRange(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
