using System;

namespace _07repeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int reps = int.Parse(Console.ReadLine());
            string output = RepeatString(input, reps);
            Console.WriteLine(output);

        }

        private static string RepeatString(string input, int reps)
        {
            string result = "";
            for (int i = 0; i < reps; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
