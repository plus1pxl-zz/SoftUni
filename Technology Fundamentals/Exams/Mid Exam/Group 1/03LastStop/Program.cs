using System;
using System.Collections.Generic;
using System.Linq;

namespace _03LastStop
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> paintings = Console.ReadLine().Split(" ").ToList();
            string input = Console.ReadLine();
            var command = input.Split(" ");

            while (command[0] != "END")
            {
                if (command[0] == "Change")
                {
                    if (paintings.Contains(command[1]))
                    {
                        for (int i = 0; i < paintings.Count; i++)
                        {
                            if (paintings[i] == command[1])
                            {
                                paintings[i] = command[2];
                            }
                        }
                    }

                }

                else if (command[0] == "Hide")
                {
                    if (paintings.Contains(command[1]))
                    {
                        paintings.Remove(command[1]);
                    }
                }

                else if (command[0] == "Switch")
                {
                    var tmp = command[1];
                    var index1 = 0;
                    var index2 = 0;
                    if (paintings.Contains(command[1]) && paintings.Contains(command[2]))
                    {
                        for (int i = 0; i < paintings.Count; i++)
                        {
                            if (paintings[i] == command[1])
                            {
                                index1 = i;
                            }
                            else if (paintings[i] == command[2])
                            {
                                index2 = i;
                            }
                        }
                        paintings[index1] = paintings[index2];
                        paintings[index2] = tmp;
                    }

                }

                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    if (paintings.Count > index && index > -1)
                    {
                        paintings.Insert(index + 1, command[2]);
                    }
                }

                else if (command[0] == "Reverse")
                {
                    paintings.Reverse();
                }
                input = Console.ReadLine();
                command = input.Split(" ");
            }

            foreach (var painting in paintings)
            {
                Console.Write($"{painting} ");
            }
        }
    }
}
