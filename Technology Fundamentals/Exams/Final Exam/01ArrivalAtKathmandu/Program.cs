using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01ArrivalAtKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            //string namePattern = @"^(?<name>[A-Za-z!@#$?]+)$";
            //string geohashPattern = @"^(?<geohash>\X+)$";
            //string LengthPattern = @"^(?<geohashLength>[0-9]+)$";
            string matchPattern = @"^(?<name>[A-Za-z0-9!@#$?]+)[=]{1}(?<geohashLength>[0-9]+)[<]{2}(?<geohash>[^$]+)$";

            string input = Console.ReadLine();

            while (input != "Last note")
            {
                bool inputIsValid = Regex.IsMatch(input, matchPattern);
                if (inputIsValid)
                {
                    string[] tokens1 = input.Split("=");
                    string[] tokens2 = tokens1[1].Split("<<");
                    string name = tokens1[0];
                    int length = int.Parse(tokens2[0]);
                    string geohash = tokens2[1];

                    if (length > 0 && geohash.Length == length)
                    {
                        string processedName = Regex.Replace(name, @"[^A-Za-z0-9]+", "");
                        Console.WriteLine($"Coordinates found! {processedName} -> {geohash}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

                input = Console.ReadLine();

            }
        }
    }
}
