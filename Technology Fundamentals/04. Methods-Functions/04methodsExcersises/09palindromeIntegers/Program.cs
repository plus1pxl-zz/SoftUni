using System;

namespace _09palindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (CheckIfNumberIsPalindrome(input) == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }

        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static bool CheckIfNumberIsPalindrome(string input)
        {
            string reversed = ReverseString(input);
            if (input == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
