using System;

namespace _01signofIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberEvaluation(int.Parse(Console.ReadLine()));
        } 

        static void NumberEvaluation(int number)
        {

            if (number > 0)
                Console.WriteLine($"The number {number} is positive.");

            else if (number < 0)
                Console.WriteLine($"The number {number} is negative.");
            else
                Console.WriteLine($"The number {number} is zero.");
        }
    }
}
