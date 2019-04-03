using System;
using System.Collections.Generic;
using System.Linq;

namespace _06courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] input = inputLine.Split(" : ").ToArray();

                string courseName = input[0];
                string studentName = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
                inputLine = Console.ReadLine();
            }

            foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
