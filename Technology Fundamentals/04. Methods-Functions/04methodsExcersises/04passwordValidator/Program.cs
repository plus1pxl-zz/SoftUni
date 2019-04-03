using System;
using System.Text.RegularExpressions;

namespace _04passwordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (CheckIfLengthIsBetween6And10(input) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (CheckCharacterIfContainsOnlyLettersAndDigits(input) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (CheckIfContainsAtLeast2digits(input) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (CheckIfLengthIsBetween6And10(input) != false
                && CheckCharacterIfContainsOnlyLettersAndDigits(input) != false
                && CheckIfContainsAtLeast2digits(input) != false)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CheckIfLengthIsBetween6And10(string input)
        {   
            if (input.Length >= 6
                && input.Length <= 10)
	        {
                return true;
	        }
            else
            {
                return false;            
            }
        }
        static bool CheckCharacterIfContainsOnlyLettersAndDigits(string input)
        {
            return Regex.IsMatch(input, @"^[0-9a-zA-Z]+$");
        }
        static bool CheckIfContainsAtLeast2digits(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    counter++;
                }
            }

            if (counter >= 2)
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
