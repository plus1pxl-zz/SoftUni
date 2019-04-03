using System;

namespace _09spice
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYeld = int.Parse(Console.ReadLine());
            int dailyYeld = startingYeld;
            int extractedSpice = 0;
            int daysOfOperation = 0;

            while (dailyYeld >= 100)
            {
                extractedSpice += dailyYeld - 26;
                dailyYeld -= 10;
                daysOfOperation++;
                

            }
            extractedSpice -= 26;
            if (extractedSpice > 0)
            {
                Console.WriteLine(daysOfOperation);
                Console.WriteLine(extractedSpice);
            }
            else
            {
                Console.WriteLine(daysOfOperation);
                Console.WriteLine(0);
            }
        }
    }
}
