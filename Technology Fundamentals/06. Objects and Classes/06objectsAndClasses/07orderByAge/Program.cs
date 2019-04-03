using System;
using System.Collections.Generic;
using System.Linq;

namespace _07orderByAge
{
    class Program
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0].ToLower() == "end")
                {
                    break;
                }

                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person
                {
                    Name = name,
                    ID = id,
                    Age = age
                };
                persons.Add(person);
            }

            persons = persons.OrderBy(x => x.Age).ToList();

            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }

        }
      
    }

    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
