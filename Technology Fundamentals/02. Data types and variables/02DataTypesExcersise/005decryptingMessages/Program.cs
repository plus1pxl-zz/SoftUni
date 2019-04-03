using System;

namespace _005decryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < num; i++)
            {
                char character = char.Parse(Console.ReadLine());
                char decryptedChar = (char)(character + key);
                message += decryptedChar.ToString();
            }
            Console.WriteLine(message);
        }
    }
}
