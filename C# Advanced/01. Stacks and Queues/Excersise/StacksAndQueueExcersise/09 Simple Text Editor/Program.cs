using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stackOfText = new Stack<string>();
            StringBuilder text = new StringBuilder();



            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (tokens[0] == "1")
                {
                    stackOfText.Push(text.ToString());
                    text.Append(tokens[1]);

                }
                else if (tokens[0] == "2")
                {
                    int index = int.Parse(tokens[1]);
                    stackOfText.Push(text.ToString());
                    text.Remove(text.Length - index, index);
                }
                else if (tokens[0] == "3")
                {
                    int index = int.Parse(tokens[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (tokens[0] == "4")
                {
                    if (stackOfText.Count > 0)
                    {
                        text.Clear();
                        text.Append(stackOfText.Pop());
                    }

                }

            }
        }
    }
}
