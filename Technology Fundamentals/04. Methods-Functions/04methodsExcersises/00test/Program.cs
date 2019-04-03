using System;

namespace _00test
{
    class Program
    {
        static void Main(string[] args)
        {
            ScrambleKeys();
        }

        static void ScrambleKeys()
        {
            int[] keys = new int[10];
            int randomNumber = 0;
            bool duplicateFound = false;
            Random rnd = new Random();

            for (int i = 0; i < 9; i++)
            {
                keys[i] = 99;
            }

            for (int i = 0; i < 9; i++)
            {
                randomNumber = rnd.Next(0, 9);
                for (int k = 0; k < 9; k++)
                {
                    if (keys[k] == randomNumber)
                    {
                        k = 9;
                        i = i - 1;
                        duplicateFound = true;
                    }
                }
                if (duplicateFound == false)
                {
                    Console.WriteLine($"assigning {randomNumber} to key {i}");
                }

            }
            Console.ReadLine();

        }
    }
}
