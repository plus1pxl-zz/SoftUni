using System;

namespace _01_ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            string[] inputNames = Console.ReadLine()
                .Split();

            printNames(inputNames);
        }
    }
}
