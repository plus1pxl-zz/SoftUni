using System;
using System.Collections.Generic;

namespace _07stringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> result = new List<char>();
            int pow = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (pow > 0)
                {
                    if (input[i] == '>')
                    {
                        result.Add(input[i]);
                        pow += Convert.ToInt32(new string(input[i + 1], 1));
                        i++;
                    }
                }
                else if (pow == 0)
                {
                    if (input[i] != '>')
                    {
                        result.Add(input[i]);
                    }
                    else
                    {
                        result.Add(input[i]);
                        pow += Convert.ToInt32(new string(input[i + 1], 1));
                        i++;
                    }
                }

                if (pow > 0)
                {
                    pow--;
                }

            }
            foreach (var c in result)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
