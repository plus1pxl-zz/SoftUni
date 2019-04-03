using System;
using System.Collections.Generic;

namespace _05students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }
                string[] inputParts = input.Split();

                string firstName = inputParts[0];
                string lastName = inputParts[1];
                int age = int.Parse(inputParts[2]);
                string city = inputParts[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = city,
                };
                students.Add(student);
            }
            string filterCity = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
