using System;
using System.Linq;

namespace _06listManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (input.ToLower().Contains("add "))
                {
                    numbers.Add(int.Parse(input.Substring(4)));
                }
                if (input.ToLower().Contains("remove "))
                {
                    numbers.Remove(int.Parse(input.Substring(6)));
                }
                if (input.ToLower().Contains("removeat "))
                {
                    numbers.RemoveAt(int.Parse(input.Substring(9)));
                }

                if (input.ToLower().Contains("insert "))
                {
                    var insert = input.Split(' ').ToList();

                    numbers.Insert(int.Parse(insert[2]), int.Parse(insert[1]));
                }
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
