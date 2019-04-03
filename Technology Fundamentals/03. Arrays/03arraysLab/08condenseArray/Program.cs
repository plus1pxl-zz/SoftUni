﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {

        int[] mainArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] condensedArray = new int[mainArray.Length - 1];

        if (mainArray.Length == 1)
        {
            Console.WriteLine(mainArray[0]);
            return;
        }

        for (int i = 0; i < mainArray.Length; i++)
        {
            for (int j = 0; j < condensedArray.Length - i; j++)
            {
                condensedArray[j] = mainArray[j] + mainArray[j + 1];
            }
            mainArray = condensedArray;
        }
        Console.WriteLine(condensedArray[0]);
    }
}