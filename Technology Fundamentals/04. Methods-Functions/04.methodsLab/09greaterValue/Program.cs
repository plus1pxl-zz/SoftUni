using System;
using System.Linq;

namespace _08mathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string val1 = Console.ReadLine();
            string val2 = Console.ReadLine();
            string greaterVal = GetMax(type, val1, val2);
            Console.WriteLine(greaterVal);

        }

        static string GetMax(string type, string val1, string val2)
        {
            string greaterVal = "";

            if (type == "int")
            {
                int[] numbers = new int[] { int.Parse(val1), int.Parse(val2) };
                greaterVal = numbers.Max().ToString();
            }
            if (type == "char")
            {
                char[] chars = new char[] { char.Parse(val1), char.Parse(val2) };
                greaterVal = chars.Max().ToString();
            }
            if (type == "string")
            {
                string[] strings = new string[] { val1, val2 };
                greaterVal = strings.Max();
            }

            return greaterVal;

        }


    }
}
