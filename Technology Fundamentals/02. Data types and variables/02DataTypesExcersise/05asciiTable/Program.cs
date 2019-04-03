using System;

namespace _05asciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = begining; i <= end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
