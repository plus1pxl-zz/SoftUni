using System;
using System.Collections.Generic;
using System.Linq;

namespace _10softUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> softUniSchedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = Console.ReadLine();


            while (input != "course start")
            {
                List<string> command = input
                .Split(':')
                .ToList();

                if (command[0].ToLower() == "add"
                    && !softUniSchedule.Contains(command[1]))
                {
                    softUniSchedule.Add(command[1]);
                }
                else if (command[0].ToLower() == "insert"
                    && !softUniSchedule.Contains(command[1]))
                {
                    int indexToInsertAt = int.Parse(command[2]);
                    softUniSchedule.Insert(indexToInsertAt, command[1]);
                }
                else if (command[0].ToLower() == "remove"
                    && softUniSchedule.Contains(command[1]))
                {
                    for (int i = 0; i < softUniSchedule.Count - 1; i++)
                    {
                        if (softUniSchedule[i] == command[1])
                        {
                            if (softUniSchedule[i + 1] == command[1] + "-Excersise")
                            {
                                softUniSchedule.RemoveAt(i + 1);
                            }
                            softUniSchedule.RemoveAt(i);
                        }
                    }
                    softUniSchedule.Remove(command[1]);
                }
                else if (command[0].ToLower() == "swap")
                {

                    if (softUniSchedule.Contains(command[1]) && softUniSchedule.Contains(command[2]))
                    {
                        SwapsLessons(softUniSchedule, command[1], command[2]);
                    }
                    if (softUniSchedule.Contains(command[1] + "-Exercise") || softUniSchedule.Contains(command[2] + "-Exercise"))
                    {
                        SwapsExercises(softUniSchedule, command[1], command[2]);
                    }
                }
                else if (command[0].ToLower() == "exercise" && !softUniSchedule.Contains(command[1] + "-Exercise"))
                {
                    if (softUniSchedule.Contains(command[1]))
                    {
                        for (int i = 0; i < softUniSchedule.Count - 1; i++)
                        {
                            if (softUniSchedule[i] == command[1])
                            {
                                softUniSchedule.Insert(i + 1, command[1] + "-Exercise");
                            }
                        }
                    }
                    else
                    {
                        softUniSchedule.Add(command[1]);
                        softUniSchedule.Add(command[1] + "-Exercise");
                    }
                }



                input = Console.ReadLine();

            }
            for (int i = 0; i < softUniSchedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{softUniSchedule[i]}");
            }
        }
        static List<string> SwapsLessons(List<string> schedule, string firstLesson, string secondLesson)
        {

            int firstLessonPosition = schedule.IndexOf(firstLesson);
            int secondLessonPosition = schedule.IndexOf(secondLesson);


            schedule[firstLessonPosition] = secondLesson;
            schedule[secondLessonPosition] = firstLesson;

            return schedule;
        }

        static List<string> SwapsExercises(List<string> schedule, string firstLesson, string secondLesson)
        {


            if (schedule.Contains(firstLesson + "-" + "Exercise"))
            {
                schedule.Remove(firstLesson + "-" + "Exercise");

                if (schedule.IndexOf(firstLesson) == schedule.Count - 1)
                {
                    schedule.Add(firstLesson + "-" + "Exercise");
                }
                else
                {
                    schedule.Insert(schedule.IndexOf(firstLesson) + 1, firstLesson + "-" + "Exercise");
                }

            }
            if (schedule.Contains(secondLesson + "-" + "Exercise"))
            {
                schedule.Remove(secondLesson + "-" + "Exercise");

                if (schedule.IndexOf(secondLesson) == schedule.Count - 1)
                {
                    schedule.Add(secondLesson + "-" + "Exercise");
                }
                else
                {
                    schedule.Insert(schedule.IndexOf(secondLesson) + 1, secondLesson + "-" + "Exercise");
                }
            }
            return schedule;
        }
    }
}
