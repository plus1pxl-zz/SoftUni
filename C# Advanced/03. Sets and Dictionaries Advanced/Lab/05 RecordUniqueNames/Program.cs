using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05_RecordUniqueNames
{
    public class StartUp_05
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < inputN; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
