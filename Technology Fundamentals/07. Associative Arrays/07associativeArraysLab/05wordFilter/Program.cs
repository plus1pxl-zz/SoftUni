﻿using System;
using System.Linq;

namespace _05wordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length % 2 == 0);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
