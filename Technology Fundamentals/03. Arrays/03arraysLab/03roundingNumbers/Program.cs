using System;

namespace _03roundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            double[] numbers = Array.ConvertAll(tokens, double.Parse);
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} => {Math.Round(number, 0, MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
