using System;
using System.Linq;

namespace _11arrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string input = "";
            int[] numbers = s1.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            while (input.ToLower() != "end")
            {
                if (input.ToLower().Contains("exchange"))
                {
                    int index = int.Parse(input.Substring(10, input.Length - 10));
                    if (index > numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers = ExchangeArrayParts(numbers, index);
                    }
                    

                }
                if (input.ToLower().Contains("max"))
                {

                }
                if (input.ToLower().Contains("min"))
                {

                }
                if (input.ToLower().Contains("first"))
                {

                }
                if (input.ToLower().Contains("last"))
                {

                }
                input = Console.ReadLine();
            }

        }

        private static int ExchangeArrayParts(int numbers, int index)
        {

            return numbers;
        }
    }
}
