using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02_AverageStudentGrades
{
    public class StartUp_02
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < inputN; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string student = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (students.ContainsKey(student))
                {
                    students[student].Add(grade);
                }
                else
                {
                    //students.Add(student, new List<double>() { grade });
                    students[student] = new List<double>();
                    students[student].Add(grade);
                }
            }
            foreach (var student in students)
            {

                Console.WriteLine($"{student.Key} -> {String.Join(" ", student.Value)} (avg: {student.Value.Average():f2}");
            }


        }
    }
}
