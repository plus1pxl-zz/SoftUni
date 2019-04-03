using System;

namespace _04ceaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cryptedInput = "";


            for (int i = 0; i < input.Length; i++)
            {
                int newchar = input[i] + 3;
                cryptedInput += Convert.ToChar(newchar);  
            }

            Console.WriteLine(cryptedInput);
        }
    }
}
