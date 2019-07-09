using System;

namespace _02_KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> appendSirAndPrint = names => 
            Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));
            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            appendSirAndPrint(inputNames);

        }
    }
}
