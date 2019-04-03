using System;

namespace _01DoW
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] DoW = new string[7];
            DoW[0] = "Monday";
            DoW[1] = "Tuesday";
            DoW[2] = "Wednesday";
            DoW[3] = "Thursday";
            DoW[4] = "Friday";
            DoW[5] = "Saturday";
            DoW[6] = "Sunday";



            if (input >= 1 && input <= 7)
            {
                Console.WriteLine(DoW[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
