using System;
using System.Collections.Generic;
using System.Globalization;

namespace _01dayOfWeek
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
