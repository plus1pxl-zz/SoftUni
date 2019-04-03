using System;
using System.Collections.Generic;
using System.Linq;

namespace _07studentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = "";
            double gradeToAdd = 0.00;

            var students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                gradeToAdd = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }
                students[name].Add(gradeToAdd);
            }

            var studentsAverageGrade = new Dictionary<string, double>();

            foreach (var kvp in students)
            {
                double sum = 0.00;
                foreach (var grade in kvp.Value)
                {
                    sum += grade;
                }
                double averageGrade = sum / kvp.Value.Count;
                if (averageGrade >= 4.50)
                {
                    studentsAverageGrade.Add(kvp.Key, averageGrade);
                }
                
            }

            foreach (var kvp in studentsAverageGrade.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
