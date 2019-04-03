using System;

namespace _04reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            string reversed = new string(charArray);

            Console.WriteLine(reversed);
        }
    }
}
