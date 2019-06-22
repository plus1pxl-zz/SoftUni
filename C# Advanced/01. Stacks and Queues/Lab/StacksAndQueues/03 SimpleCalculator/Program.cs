using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(tokens.Reverse());
            while (stack.Count>1)
            {
                int operand1 = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int operand2 = int.Parse(stack.Pop());

                switch (opr)
                {
                    case "+":
                        stack.Push((operand1 + operand2).ToString());
                        break;
                    case "-":
                        stack.Push((operand1 - operand2).ToString());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
