using System;
using System.Collections.Generic;
using System.Linq;

namespace _04students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputParts = input.Split();

                string firstName = inputParts[0];
                string lastName = inputParts[1];
                double grade = double.Parse(inputParts[2]);

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                students.Add(student);

            }
            students = students.OrderByDescending(x => x.Grade)
                    .ToList();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
