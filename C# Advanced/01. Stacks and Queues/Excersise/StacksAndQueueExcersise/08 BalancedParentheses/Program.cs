using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08_BalancedParentheses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<char> stackOfParenteses = new Stack<char>();

            char[] input = Console.ReadLine()
                .ToCharArray();

            bool isValid = true;

            char[] openParenteses = new char[] { '(', '[', '{' };

            if (!openParenteses.Contains(input[0]))
            {
                isValid = false;
            }

            foreach (var item in input)
            {
                if (openParenteses.Contains(item))
                {
                    stackOfParenteses.Push(item);
                    continue;
                }

                if (stackOfParenteses.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParenteses.Peek() == '(' && item == ')')
                {
                    stackOfParenteses.Pop();
                }
                else if (stackOfParenteses.Peek() == '[' && item == ']')
                {
                    stackOfParenteses.Pop();
                }
                else if (stackOfParenteses.Peek() == '{' && item == '}')
                {
                    stackOfParenteses.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
