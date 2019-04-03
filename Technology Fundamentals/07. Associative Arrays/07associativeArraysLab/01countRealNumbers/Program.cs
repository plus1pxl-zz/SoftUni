using System;
using System.Collections.Generic;

namespace _01countRealNumbers
{
    class Program
    {
        // 8 2.5 2.5 8 2.5

        static void Main()
        {
       
            string[] numbersAsString = Console.ReadLine().Split(' ');
            List<double> numbers = new List<double>(); 
            foreach (var numberAsString in numbersAsString)
            {
                numbers.Add(double.Parse(numberAsString)); 
            }

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

    	}
    }

}
